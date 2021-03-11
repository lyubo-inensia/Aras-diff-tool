using InnoTool.Models;
using InnoTool.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnoTool.Win
{
    public partial class SettingsItemTypes : Form
    {
        private AppForm mainForm;
        private AppSettings settings;
        private bool gridDirty = false;

        public SettingsItemTypes()
        {
            InitializeComponent();
            mainForm = (AppForm)Application.OpenForms[0];
        }

        private void SettingsItemTypes_Load(object sender, EventArgs e)
        {

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
            gridDirty = false;
        }

        private void LoadSettings()
        {
            settings = (new ConfigService()).Settings;
        }

        bool IsGridDirty(DataGridView grid)
        {
            var ret = false;
            foreach(var obj in grid.Rows)
            {
                var row = (DataRowView) obj;
                if (row.Row.RowState == DataRowState.Added || row.Row.RowState == DataRowState.Modified)
                {

                }
            }

            return ret;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // check if there are unsaved changes
            CloseReloadSettings();
        }

        private void CloseReloadSettings()
        {
            mainForm.LoadSettings(true);
            mainForm.PopulateItemTypes();
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<ItemTypeSetting> types = new List<ItemTypeSetting>();
            var confService = new ConfigService();
            foreach (var item in gridTypes.Rows)
            {
                var row = ((DataGridViewRow)item);
                if (row.Cells[0].Value == null)
                {
                    continue;
                }
                try
                {
                    types.Add(new ItemTypeSetting
                    {
                        ItemType = ((DataGridViewTextBoxCell)row.Cells[0]).Value.ToString(),
                        Property = ((DataGridViewTextBoxCell)row.Cells[1]).Value.ToString(),
                        Checked = Convert.ToBoolean(((DataGridViewCheckBoxCell)row.Cells[2]).Value ?? "true")
                    });
                    
                }
                catch { }
            }
            settings.ItemTypes = types;
            confService.SaveSettings(settings);

            CloseReloadSettings();
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<IEnumerable<ItemTypeSetting>>(File.ReadAllText("default_item_types.json"));
                LoadGrid(data);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
