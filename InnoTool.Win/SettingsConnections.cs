using InnoTool.Models;
using InnoTool.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InnoTool.Win
{
    public partial class SettingsConnections : Form
    {
        public SettingsConnections()
        {
            InitializeComponent();
            mainForm = (AppForm)Application.OpenForms[0];
            settings = mainForm.Settings;
        }

        Settings settings;
        AppForm mainForm;

        void ReloadSettings()
        {
            mainForm.LoadSettings();
            settings = mainForm.Settings;
            setConnections(settings.Connections, lstSaved);

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formConnections_Load(object sender, EventArgs e)
        {
            ReloadSettings();
        }

        private void setConnections(IEnumerable<ConnectionSettings> conns, ListBox ddl)
        {
            ddl.Items.Clear();
            //ddl.SelectedIndex = -1;
            ddl.Text = "";

            if (conns.Count() == 0)
            {
                return;
            }
            ddl.Items.AddRange(conns.ToArray());
        }


        void populateSettings(ConnectionSettings conn)
        {
            if (conn == null)
            {
                return;
            }
            txtConn1Name.Text = conn.Name;
            txtConn1Url.Text = conn.Url;
            txtConn1Db.Text = conn.Database;
            txtConn1User.Text = conn.Username;
            txtConn1Pass.Text = conn.Password;
            
        }

        private async void btnConn1Test_Click(object sender, EventArgs e)
        {
            var error = "";
            if (txtConn1Url.Text == "")
            {
                error = "Missing url.";
            }
            else if (txtConn1Db.Text == "")
            {
                error = "Missing database name.";
            }
            else if (txtConn1User.Text == "")
            {
                error = "Missing username.";
            }
            else if (txtConn1Pass.Text == "")
            {
                error = "Missing password.";
            }
            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }
            var c = new ConnectionSettings {
                Url = txtConn1Url.Text,
                Database = txtConn1Db.Text,
                Username = txtConn1User.Text,
                Password = txtConn1Pass.Text
            };
            var s = new InnovatorService(c);
            try
            {
                if (await s.TestConnectionSettings())
                {
                    MessageBox.Show("Connection successful.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnConn1Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConn1Name.Text))
            {
                MessageBox.Show("Connection name is required");
                return;
            }
            var s = new ConfigService();
            var c = new ConnectionSettings
            {
                Name = txtConn1Name.Text,
                Url = txtConn1Url.Text,
                Database = txtConn1Db.Text,
                Username = txtConn1User.Text,
                Password = txtConn1Pass.Text
            };
            s.SaveConnection(c);
            ReloadSettings();
            MessageBox.Show("Connection saved successfully");
        }

        private void btnConn1Delete_Click(object sender, EventArgs e)
        {
            var s = new ConfigService();
            var c = txtConn1Name.Text;
            try
            {
                s.DeleteConnection(c);
            }
            catch (Exception)
            {

            }
            ReloadSettings();
            MessageBox.Show($"\"{c}\" removed successfully");
        }

        


        private void btnClose_Click(object sender, EventArgs e)
        {
            mainForm.LoadSettings();
            mainForm.PopulateConnections();
            Close();
        }

        private void lstSaved_DoubleClick(object sender, EventArgs e)
        {
            var list = (ListBox)sender;
            if (list.SelectedItem == null)
            {
                return;
            }
            try
            {
                var c = (ConnectionSettings) list.SelectedItem;
                populateSettings(c);
            }
            catch (Exception)
            {
            }
        }
    }
}
