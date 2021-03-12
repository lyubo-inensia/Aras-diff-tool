using InnoTool.Models;
using InnoTool.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnoTool.Win
{
    public partial class AddToPackage : Form
    {
        private IEnumerable<PackageDefinition> Packages;
        private IPackageService PackService;
        private readonly InnovatorService innService;

        public IEnumerable<IBaseItem> ItemsToAdd { get; set; }
        public DataGridView ItemsGrid { get; }

        public AddToPackage(IPackageService packService, InnovatorService innService, IEnumerable<IBaseItem> itemsToAdd, DataGridView itemsGrid)
        {
            PackService = packService;
            this.innService = innService;
            ItemsToAdd = itemsToAdd;
            ItemsGrid = itemsGrid;
            InitializeComponent();
        }
        private void AddToPackage_Load(object sender, EventArgs e)
        {
            LoadPacks();
        }
        private TreeNode PopulateTreeNode(IBaseItem item, TreeNode node = null, HashSet<string> visited = null)
        {
            if (node == null)
            {
                node = new TreeNode();
            }
            if (visited == null)
            {
                visited = new HashSet<string>();
            }
            node.Text = item.Name;
            node.Tag = item;
            node.Checked = true;
            visited.Add(item.Id);
            foreach (var i in item.Dependencies)
            {
                if (visited.Contains(i.Id))
                {
                    continue;
                }
                visited.Add(i.Id);
                var n = new TreeNode();
                n = PopulateTreeNode(i, n, visited);
                n.Checked = true;
                node.Nodes.Add(n);
            }

            return node;
        }
        private void LoadPacks()
        {
            var task = Task.Run(() =>
            {
                Packages = PackService.GetPackages().GetAwaiter().GetResult();
            })
            .ContinueWith((t) =>
            {
                this.Invoke(new MethodInvoker(delegate { PopulatePackagesList(Packages); }));
            });
        }
        private void PopulatePackagesList(IEnumerable<PackageDefinition> packs)
        {
            listPackages.Items.Clear();
            listPackages.Items.AddRange(packs.ToList().OrderBy(e => e.Name, StringComparer.CurrentCultureIgnoreCase).ToArray());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (listPackages.SelectedItem == null)
            {
                MessageBox.Show("No package selected");
                return;
            }
            var items = ItemsToAdd.ToList();
            if (items.Count == 0)
            {
                MessageBox.Show("No items selected.");
                return;
            }
            var pack = (PackageDefinition)listPackages.SelectedItem;

            var msg = "Add " + items.Count() + " items to \"" + pack.Name + "\"";
            if (MessageBox.Show(msg, "Confirm package change", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    var res = PackService.AddItemsToPackage(pack.Id, items, pack.Name, chkMoveItems.Checked);
                    msg = res.Count().ToString() + " items successfully added to \"" + pack.Name + "\"";
                    MessageBox.Show(msg);
                    ((AppForm)ItemsGrid.FindForm()).UpdateItemsPackages(res, ItemsGrid);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding items: " + ex.Message);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var name = txtPackageName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Package name cannot be empty.");
                return;
            }
            else if (Packages.Any(p => p.Name.ToLower() == name.ToLower()))
            {
                MessageBox.Show("Package already exists.");
                return;
            }

            var newPackage = PackService.AddPackage(name);
            if (newPackage == null)
            {
                MessageBox.Show("Error creating package.");
                return;
            }
            Packages = Packages.Concat(new PackageDefinition[] { newPackage });
            PopulatePackagesList(Packages);
        }

        private void txtPackageName_TextChanged(object sender, EventArgs e)
        {
            var s = txtPackageName.Text;
            var tmpPacks = new List<PackageDefinition>(Packages);
            if (!string.IsNullOrWhiteSpace(s))
            {
                tmpPacks = tmpPacks.Where(p => p.Name.ToLower().Contains(s.ToLower())).ToList();
            }
            PopulatePackagesList(tmpPacks);
        }

    }
}
