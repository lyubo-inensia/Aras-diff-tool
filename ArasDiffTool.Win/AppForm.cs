using ArasDiffTool.Models;
using ArasDiffTool.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArasDiffTool.Win
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            LoadSettings();
            InitializeComponent();
        }

        public void LoadSettings()
        {
            Settings = (new ConfigService()).GetSettings();
        }

        public ConnectionSettings Connection1 { get; set; }
        public ConnectionSettings Connection2 { get; set; }
        public ConnectionSettings Connection3 { get; set; }
        public Settings Settings { get; set; }
        private void formMain_Load(object sender, EventArgs e)
        {
            PopulateItemTypes();
            PopulateConnections();
            dateCheckFrom.Value = DateTime.Now.AddDays(-7);
            if (Settings.Connections.Count() == 0)
            {
                MessageBox.Show("You have no saved connections. Use Settings menu to create Innovator connections.", 
                    "Innovator connections", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
        public void PopulateConnections()
        {
            string[] tmp = Settings.Connections.Select(c => c.Name).ToArray();
            
            ddlConnection1.Items.Clear();
            ddlConnection2.Items.Clear();
            ddlConnection3.Items.Clear();
            
            if (tmp.Count() == 0)
            {
                return;
            }
            ddlConnection1.Items.AddRange(tmp);
            ddlConnection2.Items.AddRange(tmp);
            ddlConnection3.Items.AddRange(tmp);
        }
        public void PopulateItemTypes()
        {
            chkItemTypes.Items.Clear();
            foreach (var item in Settings.ItemTypes)
            {
                chkItemTypes.Items.Add(item, item.Checked);
            }
        }

        IEnumerable<ItemTypeSetting> GetSelectedTypes()
        {
            foreach (var item in chkItemTypes.CheckedItems)
            {
                yield return (ItemTypeSetting)item;
            }
        }

        public void SetConn1(ConnectionSettings conn)
        {
            Connection1 = conn;
            lblUrl1.Text = Connection1.Url;
            lblDb1.Text = Connection1.Database;
            if (!string.IsNullOrWhiteSpace(Connection1.Name))
            {
                conn1Group.Text += " (" + Connection1.Name + ")";
            }
        }
        public void SetConn2(ConnectionSettings conn)
        {
            Connection2 = conn;
            lblUrl2.Text = Connection2.Url;
            lblDb2.Text = Connection2.Database;
            if (!string.IsNullOrWhiteSpace(Connection2.Name))
            {
                conn2Group.Text += " (" + Connection2.Name + ")";
            }
            
        }

        public async Task LoadDataAsync()
        {
            try
            {
                var inn1 = new InnovatorService(Connection1);
                var inn2 = new InnovatorService(Connection2);
                var itemTypes = GetSelectedTypes();
                DateTime? from = null;
                DateTime? to = null;
                if (chkFrom1.Checked) from = dateTimePicker1.Value;
                if (chkTo1.Checked) to = dateTimePicker2.Value;
                var diff = (new DiffService()).CompareItems(
                    await inn1.GetItemsAsync(itemTypes),
                    await inn2.GetItemsAsync(itemTypes),
                    from,
                    to
                    );
                this.BeginInvoke((Action)(() =>
                {
                    BindDiffGrid(diff);
                    imgLoadingCompare.Visible = false;
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void BindDiffGrid(IEnumerable<DiffItem> diffs)
        {
            gridCompare.DataSource = diffs;
            foreach(DataGridViewRow r in gridCompare.Rows)
            {
                var color = Color.LightGreen;
                var item = (DiffItem) r.DataBoundItem;
                if (item.ChangeType == ItemChangeType.Deleted)
                {
                    color = Color.LightSalmon;
                }
                else if (item.ChangeType == ItemChangeType.Modified)
                {
                    color = Color.LightSkyBlue;
                }
                r.DefaultCellStyle.BackColor = color;
            }
        }

        public async Task LoadData2Async()
        {
            try
            {
                var inn1 = new InnovatorService(Connection3);
                var itemTypes = GetSelectedTypes();
                DateTime from = dateCheckFrom.Value;
                DateTime to = dateCheckTo.Value;

                var res = (new DiffService()).ListItems(
                    await inn1.GetItemsAsync(itemTypes),
                    from,
                    to
                    );
                this.BeginInvoke((Action) (() => {
                    BindCheckGrid(res);
                    imgLoadingCheck.Visible = false;
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void BindCheckGrid(IEnumerable<SingleItem> res)
        {
            gridChanges.DataSource = res;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SettingsConnections();
            f.ShowDialog();
        }

        private void itemTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SettingsItemTypes();
            f.ShowDialog();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            var error = "";
            if (chkItemTypes.CheckedItems.Count == 0)
            {
                error = "Please select at least one item type.";
            }
            else if (Connection1 == null)
            {
                error = "Please select connection 1";
            }
            else if (Connection2 == null)
            {
                error = "Please select connection 2";
            }
            else if (Connection1 == Connection2)
            {
                error = "Please select different connections";
            }
            
            if (error != "")
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            imgLoadingCompare.Visible = true;
            await Task.Run(() => LoadDataAsync());
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = ((CheckBox)sender).Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = ((CheckBox)sender).Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            dateCheckFrom.Enabled = ((CheckBox)sender).Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           dateCheckTo.Enabled = ((CheckBox)sender).Checked;
        }

        private void ddlConnection1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ddl = (ComboBox)sender;
            var conn = Settings.Connections.FirstOrDefault(c => c.Name == ddl.SelectedItem.ToString());
            Connection1 = conn;
            lblUrl1.Text = conn?.Url ?? "";
            lblDb1.Text = conn?.Database ?? "";
        }

        private void ddlConnection2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ddl = (ComboBox)sender;
            var conn = Settings.Connections.FirstOrDefault(c => c.Name == ddl.SelectedItem.ToString());
            Connection2 = conn;
            lblUrl2.Text = conn?.Url ?? "";
            lblDb2.Text = conn?.Database ?? "";
        }

        private void ddlConnection3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ddl = (ComboBox)sender;
            var conn = Settings.Connections.FirstOrDefault(c => c.Name == ddl.SelectedItem.ToString());
            Connection3 = conn;
            lblUrl3.Text = conn?.Url ?? "";
            lblDb3.Text = conn?.Database ?? "";
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            var error = "";
            if (chkItemTypes.CheckedItems.Count == 0)
            {
                error = "Please select at least one item type.";
            }
            else if (Connection3 == null)
            {
                error = "Please select connection";
            }

            if (error != "")
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            imgLoadingCheck.Visible = true;
            await Task.Run(() => LoadData2Async());
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            var isChecked = false;
            var txt = "Check all";
            var tag = "1";
            if (btn.Tag.ToString() == "1")
            {
                tag = "0";
                txt = "Uncheck all";
                isChecked = true;
            }
            btn.Tag = tag;
            btn.Text = txt;
            for (int i = 0; i < chkItemTypes.Items.Count; i++)
            {
                ((ItemTypeSetting)chkItemTypes.Items[i]).Checked = isChecked;
                chkItemTypes.SetItemChecked(i, isChecked);
            } 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new About();
            f.ShowDialog();
        }

        private void AddToPackage(DataGridView grid, ConnectionSettings conn)
        {
            if (grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nothing selected.");
                return;
            }
            if (conn == null)
            {
                MessageBox.Show("Select connection.");
                return;
            }
            var items = new List<IBaseItem>();
            foreach(var r in grid.SelectedRows)
            {
                var row = (DataGridViewRow)r;
                var item = (IBaseItem)row.DataBoundItem;
                if (string.IsNullOrWhiteSpace(item.Id))
                {
                    continue;
                }
                items.Add(item);
            }
            var f = new AddToPackage(conn, items);
            f.ShowDialog();
        }
        private void btnPackage1_Click(object sender, EventArgs e)
        {
            AddToPackage(gridChanges, Connection3);
        }

        private void btnPackage2_Click(object sender, EventArgs e)
        {
            AddToPackage(gridCompare, Connection1);
        }
    }
}
