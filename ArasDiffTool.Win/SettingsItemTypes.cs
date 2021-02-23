using ArasDiffTool.Models;
using ArasDiffTool.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArasDiffTool.Win
{
    public partial class SettingsItemTypes : Form
    {
        private AppForm mainForm;
        private Settings settings;

        public SettingsItemTypes()
        {
            InitializeComponent();
            mainForm = (AppForm)Application.OpenForms[0];
            LoadSettings();
            LoadGrid();
        }

        private void LoadGrid()
        {
            LoadGrid(settings.ItemTypes);
        }

        private void LoadGrid(IEnumerable<ItemTypeSetting> data)
        {
            gridTypes.Rows.Clear();
            foreach (var item in data)
            {
                gridTypes.Rows.Add(new object[] { item.ItemType, item.Property, item.Checked });
            }
        }

        private void LoadSettings()
        {
            settings = (new ConfigService()).GetSettings();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            // check if there are unsaved changes
            CloseReloadSettings();
        }

        private void CloseReloadSettings()
        {
            mainForm.LoadSettings();
            mainForm.PopulateItemTypes();
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            CloseReloadSettings();
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {

        }
    }
}
