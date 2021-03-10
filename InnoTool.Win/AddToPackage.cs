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
        private IEnumerable<PackageDefinition> packages;
        private PackageService PackService;

        public IEnumerable<IBaseItem> ItemsToAdd { get; }

        public AddToPackage(ConnectionSettings conn, IEnumerable<IBaseItem> itemsToAdd)
        {
            InitializeComponent();
            PackService = new PackageService(new InnovatorService(conn));

            var task = Task.Run(() => {
                packages = PackService.GetPackages().GetAwaiter().GetResult();
            })
                .ContinueWith((t) => {
                    this.Invoke(new MethodInvoker(delegate { PopulatePackagesList(packages); }));
                });
            ItemsToAdd = itemsToAdd;
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
            var pack = (PackageDefinition) listPackages.SelectedItem;
            var msg = "Add " + ItemsToAdd.Count() + " items to \"" + pack.Name + "\"";
            if (MessageBox.Show(msg, "Confirm package change", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    var res = PackService.AddItemToPackage(pack.Id, ItemsToAdd);
                    msg = res.ToString() + " items successfully added to \"" + pack.Name + "\"";
                    MessageBox.Show(msg);
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
            else if(packages.Any(p => p.Name.ToLower() == name.ToLower()))
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
            packages = packages.Concat(new PackageDefinition[] { newPackage });
            PopulatePackagesList(packages);
        }
    }
}
