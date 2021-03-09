
namespace ArasDiffTool.Win
{
    partial class AppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCompare = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.comType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChangeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMod1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comMod2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreated1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreated2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkTo1 = new System.Windows.Forms.CheckBox();
            this.chkFrom1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnReload = new System.Windows.Forms.Button();
            this.conn2Group = new System.Windows.Forms.GroupBox();
            this.ddlConnection2 = new System.Windows.Forms.ComboBox();
            this.lblDb2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUrl2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.conn1Group = new System.Windows.Forms.GroupBox();
            this.ddlConnection1 = new System.Windows.Forms.ComboBox();
            this.lblDb1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUrl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabChanges = new System.Windows.Forms.TabPage();
            this.gridCheck = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddlConnection3 = new System.Windows.Forms.ComboBox();
            this.lblDb3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUrl3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateCheckTo = new System.Windows.Forms.DateTimePicker();
            this.dateCheckFrom = new System.Windows.Forms.DateTimePicker();
            this.btnCheck = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.itemTypesGroup = new System.Windows.Forms.GroupBox();
            this.chkItemTypes = new System.Windows.Forms.CheckedListBox();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.imgLoadingCompare = new System.Windows.Forms.PictureBox();
            this.imgLoadingCheck = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabCompare.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel2.SuspendLayout();
            this.conn2Group.SuspendLayout();
            this.conn1Group.SuspendLayout();
            this.tabChanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheck)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.itemTypesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadingCompare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadingCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChanges);
            this.tabControl1.Controls.Add(this.tabCompare);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1090, 715);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCompare
            // 
            this.tabCompare.Controls.Add(this.panel3);
            this.tabCompare.Controls.Add(this.panel2);
            this.tabCompare.Location = new System.Drawing.Point(4, 22);
            this.tabCompare.Name = "tabCompare";
            this.tabCompare.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompare.Size = new System.Drawing.Size(1082, 689);
            this.tabCompare.TabIndex = 0;
            this.tabCompare.Text = "Compare";
            this.tabCompare.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1076, 581);
            this.panel3.TabIndex = 10;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comType,
            this.comName,
            this.colChangeType,
            this.colMod1,
            this.comMod2,
            this.colCreated1,
            this.colCreated2});
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(1076, 581);
            this.grid.TabIndex = 20;
            // 
            // comType
            // 
            this.comType.FillWeight = 200F;
            this.comType.HeaderText = "Type";
            this.comType.Name = "comType";
            this.comType.ReadOnly = true;
            this.comType.Width = 200;
            // 
            // comName
            // 
            this.comName.FillWeight = 200F;
            this.comName.HeaderText = "Name";
            this.comName.Name = "comName";
            this.comName.ReadOnly = true;
            this.comName.Width = 200;
            // 
            // colChangeType
            // 
            this.colChangeType.HeaderText = "Change";
            this.colChangeType.Name = "colChangeType";
            this.colChangeType.ReadOnly = true;
            // 
            // colMod1
            // 
            this.colMod1.HeaderText = "Modified 1";
            this.colMod1.Name = "colMod1";
            this.colMod1.ReadOnly = true;
            // 
            // comMod2
            // 
            this.comMod2.HeaderText = "Modiefied 2";
            this.comMod2.Name = "comMod2";
            this.comMod2.ReadOnly = true;
            // 
            // colCreated1
            // 
            this.colCreated1.HeaderText = "Created 1";
            this.colCreated1.Name = "colCreated1";
            this.colCreated1.ReadOnly = true;
            // 
            // colCreated2
            // 
            this.colCreated2.HeaderText = "Created 2";
            this.colCreated2.Name = "colCreated2";
            this.colCreated2.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.imgLoadingCompare);
            this.panel2.Controls.Add(this.chkTo1);
            this.panel2.Controls.Add(this.chkFrom1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.conn2Group);
            this.panel2.Controls.Add(this.conn1Group);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 102);
            this.panel2.TabIndex = 12;
            // 
            // chkTo1
            // 
            this.chkTo1.AutoSize = true;
            this.chkTo1.Location = new System.Drawing.Point(895, 50);
            this.chkTo1.Name = "chkTo1";
            this.chkTo1.Size = new System.Drawing.Size(15, 14);
            this.chkTo1.TabIndex = 5;
            this.chkTo1.UseVisualStyleBackColor = true;
            this.chkTo1.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkFrom1
            // 
            this.chkFrom1.AutoSize = true;
            this.chkFrom1.Location = new System.Drawing.Point(896, 18);
            this.chkFrom1.Name = "chkFrom1";
            this.chkFrom1.Size = new System.Drawing.Size(15, 14);
            this.chkFrom1.TabIndex = 3;
            this.chkFrom1.UseVisualStyleBackColor = true;
            this.chkFrom1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "From:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "\"\"";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(689, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.Tag = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(689, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2021, 2, 18, 0, 0, 0, 0);
            // 
            // btnReload
            // 
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(920, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(156, 102);
            this.btnReload.TabIndex = 15;
            this.btnReload.Text = "COMPARE";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // conn2Group
            // 
            this.conn2Group.Controls.Add(this.ddlConnection2);
            this.conn2Group.Controls.Add(this.lblDb2);
            this.conn2Group.Controls.Add(this.label5);
            this.conn2Group.Controls.Add(this.lblUrl2);
            this.conn2Group.Controls.Add(this.label7);
            this.conn2Group.Location = new System.Drawing.Point(305, 4);
            this.conn2Group.Name = "conn2Group";
            this.conn2Group.Size = new System.Drawing.Size(333, 90);
            this.conn2Group.TabIndex = 4;
            this.conn2Group.TabStop = false;
            this.conn2Group.Text = "Connection 2";
            // 
            // ddlConnection2
            // 
            this.ddlConnection2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlConnection2.FormattingEnabled = true;
            this.ddlConnection2.Location = new System.Drawing.Point(9, 19);
            this.ddlConnection2.Name = "ddlConnection2";
            this.ddlConnection2.Size = new System.Drawing.Size(247, 21);
            this.ddlConnection2.TabIndex = 2;
            this.ddlConnection2.SelectedIndexChanged += new System.EventHandler(this.ddlConnection2_SelectedIndexChanged);
            // 
            // lblDb2
            // 
            this.lblDb2.AutoSize = true;
            this.lblDb2.Location = new System.Drawing.Point(68, 67);
            this.lblDb2.Name = "lblDb2";
            this.lblDb2.Size = new System.Drawing.Size(0, 13);
            this.lblDb2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Database:";
            // 
            // lblUrl2
            // 
            this.lblUrl2.AutoSize = true;
            this.lblUrl2.Location = new System.Drawing.Point(68, 54);
            this.lblUrl2.Name = "lblUrl2";
            this.lblUrl2.Size = new System.Drawing.Size(0, 13);
            this.lblUrl2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Url:";
            // 
            // conn1Group
            // 
            this.conn1Group.Controls.Add(this.ddlConnection1);
            this.conn1Group.Controls.Add(this.lblDb1);
            this.conn1Group.Controls.Add(this.label4);
            this.conn1Group.Controls.Add(this.lblUrl1);
            this.conn1Group.Controls.Add(this.label1);
            this.conn1Group.Location = new System.Drawing.Point(13, 4);
            this.conn1Group.Name = "conn1Group";
            this.conn1Group.Size = new System.Drawing.Size(286, 90);
            this.conn1Group.TabIndex = 0;
            this.conn1Group.TabStop = false;
            this.conn1Group.Text = "Connection 1";
            // 
            // ddlConnection1
            // 
            this.ddlConnection1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlConnection1.FormattingEnabled = true;
            this.ddlConnection1.Location = new System.Drawing.Point(9, 19);
            this.ddlConnection1.Name = "ddlConnection1";
            this.ddlConnection1.Size = new System.Drawing.Size(247, 21);
            this.ddlConnection1.TabIndex = 1;
            this.ddlConnection1.SelectedIndexChanged += new System.EventHandler(this.ddlConnection1_SelectedIndexChanged);
            // 
            // lblDb1
            // 
            this.lblDb1.AutoSize = true;
            this.lblDb1.Location = new System.Drawing.Point(68, 67);
            this.lblDb1.Name = "lblDb1";
            this.lblDb1.Size = new System.Drawing.Size(0, 13);
            this.lblDb1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Database:";
            // 
            // lblUrl1
            // 
            this.lblUrl1.AutoSize = true;
            this.lblUrl1.Location = new System.Drawing.Point(68, 49);
            this.lblUrl1.Name = "lblUrl1";
            this.lblUrl1.Size = new System.Drawing.Size(0, 13);
            this.lblUrl1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url:";
            // 
            // tabChanges
            // 
            this.tabChanges.Controls.Add(this.gridCheck);
            this.tabChanges.Controls.Add(this.panel1);
            this.tabChanges.Location = new System.Drawing.Point(4, 22);
            this.tabChanges.Name = "tabChanges";
            this.tabChanges.Padding = new System.Windows.Forms.Padding(3);
            this.tabChanges.Size = new System.Drawing.Size(1082, 689);
            this.tabChanges.TabIndex = 1;
            this.tabChanges.Text = "View changes";
            this.tabChanges.UseVisualStyleBackColor = true;
            // 
            // gridCheck
            // 
            this.gridCheck.AllowUserToAddRows = false;
            this.gridCheck.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridCheck.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCheck.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCheck.Location = new System.Drawing.Point(3, 105);
            this.gridCheck.Name = "gridCheck";
            this.gridCheck.ReadOnly = true;
            this.gridCheck.Size = new System.Drawing.Size(1076, 581);
            this.gridCheck.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 200F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 200F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Modified";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Created";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgLoadingCheck);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dateCheckTo);
            this.panel1.Controls.Add(this.dateCheckFrom);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 102);
            this.panel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddlConnection3);
            this.groupBox1.Controls.Add(this.lblDb3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblUrl3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 90);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // ddlConnection3
            // 
            this.ddlConnection3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlConnection3.FormattingEnabled = true;
            this.ddlConnection3.Location = new System.Drawing.Point(9, 19);
            this.ddlConnection3.Name = "ddlConnection3";
            this.ddlConnection3.Size = new System.Drawing.Size(247, 21);
            this.ddlConnection3.TabIndex = 10;
            this.ddlConnection3.SelectedIndexChanged += new System.EventHandler(this.ddlConnection3_SelectedIndexChanged);
            // 
            // lblDb3
            // 
            this.lblDb3.AutoSize = true;
            this.lblDb3.Location = new System.Drawing.Point(68, 67);
            this.lblDb3.Name = "lblDb3";
            this.lblDb3.Size = new System.Drawing.Size(0, 13);
            this.lblDb3.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Database:";
            // 
            // lblUrl3
            // 
            this.lblUrl3.AutoSize = true;
            this.lblUrl3.Location = new System.Drawing.Point(68, 49);
            this.lblUrl3.Name = "lblUrl3";
            this.lblUrl3.Size = new System.Drawing.Size(0, 13);
            this.lblUrl3.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Url:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(634, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "From:";
            // 
            // dateCheckTo
            // 
            this.dateCheckTo.CustomFormat = "\"\"";
            this.dateCheckTo.Location = new System.Drawing.Point(669, 46);
            this.dateCheckTo.Name = "dateCheckTo";
            this.dateCheckTo.Size = new System.Drawing.Size(200, 20);
            this.dateCheckTo.TabIndex = 12;
            this.dateCheckTo.Tag = "";
            // 
            // dateCheckFrom
            // 
            this.dateCheckFrom.Location = new System.Drawing.Point(669, 12);
            this.dateCheckFrom.Name = "dateCheckFrom";
            this.dateCheckFrom.Size = new System.Drawing.Size(200, 20);
            this.dateCheckFrom.TabIndex = 11;
            this.dateCheckFrom.Value = new System.DateTime(2021, 2, 18, 0, 0, 0, 0);
            // 
            // btnCheck
            // 
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(920, 0);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(156, 102);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1290, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionsToolStripMenuItem,
            this.itemTypesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.connectionsToolStripMenuItem.Text = "Connections";
            this.connectionsToolStripMenuItem.Click += new System.EventHandler(this.connectionsToolStripMenuItem_Click);
            // 
            // itemTypesToolStripMenuItem
            // 
            this.itemTypesToolStripMenuItem.Name = "itemTypesToolStripMenuItem";
            this.itemTypesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.itemTypesToolStripMenuItem.Text = "Item Types";
            this.itemTypesToolStripMenuItem.Click += new System.EventHandler(this.itemTypesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.itemTypesGroup);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1090, 24);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(200, 715);
            this.panel4.TabIndex = 12;
            // 
            // itemTypesGroup
            // 
            this.itemTypesGroup.Controls.Add(this.chkItemTypes);
            this.itemTypesGroup.Controls.Add(this.btnCheckAll);
            this.itemTypesGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemTypesGroup.Location = new System.Drawing.Point(10, 10);
            this.itemTypesGroup.Margin = new System.Windows.Forms.Padding(10);
            this.itemTypesGroup.Name = "itemTypesGroup";
            this.itemTypesGroup.Padding = new System.Windows.Forms.Padding(10);
            this.itemTypesGroup.Size = new System.Drawing.Size(180, 695);
            this.itemTypesGroup.TabIndex = 4;
            this.itemTypesGroup.TabStop = false;
            this.itemTypesGroup.Text = "Item Types";
            // 
            // chkItemTypes
            // 
            this.chkItemTypes.CheckOnClick = true;
            this.chkItemTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkItemTypes.FormattingEnabled = true;
            this.chkItemTypes.Location = new System.Drawing.Point(10, 46);
            this.chkItemTypes.Margin = new System.Windows.Forms.Padding(10);
            this.chkItemTypes.Name = "chkItemTypes";
            this.chkItemTypes.Size = new System.Drawing.Size(160, 639);
            this.chkItemTypes.Sorted = true;
            this.chkItemTypes.TabIndex = 14;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckAll.Location = new System.Drawing.Point(10, 23);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(160, 23);
            this.btnCheckAll.TabIndex = 13;
            this.btnCheckAll.Tag = "0";
            this.btnCheckAll.Text = "Uncheck all";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // imgLoadingCompare
            // 
            this.imgLoadingCompare.Image = global::ArasDiffTool.Win.Properties.Resources.loader;
            this.imgLoadingCompare.Location = new System.Drawing.Point(752, 78);
            this.imgLoadingCompare.Name = "imgLoadingCompare";
            this.imgLoadingCompare.Size = new System.Drawing.Size(158, 16);
            this.imgLoadingCompare.TabIndex = 12;
            this.imgLoadingCompare.TabStop = false;
            this.imgLoadingCompare.Visible = false;
            // 
            // imgLoadingCheck
            // 
            this.imgLoadingCheck.Image = global::ArasDiffTool.Win.Properties.Resources.loader;
            this.imgLoadingCheck.Location = new System.Drawing.Point(711, 78);
            this.imgLoadingCheck.Name = "imgLoadingCheck";
            this.imgLoadingCheck.Size = new System.Drawing.Size(158, 16);
            this.imgLoadingCheck.TabIndex = 13;
            this.imgLoadingCheck.TabStop = false;
            this.imgLoadingCheck.Visible = false;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 739);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "AppForm";
            this.Text = "Innovator Diff Tool";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCompare.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.conn2Group.ResumeLayout(false);
            this.conn2Group.PerformLayout();
            this.conn1Group.ResumeLayout(false);
            this.conn1Group.PerformLayout();
            this.tabChanges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCheck)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.itemTypesGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadingCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadingCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChanges;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabCompare;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn comType;
        private System.Windows.Forms.DataGridViewTextBoxColumn comName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChangeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMod1;
        private System.Windows.Forms.DataGridViewTextBoxColumn comMod2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreated1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreated2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox conn2Group;
        private System.Windows.Forms.Label lblDb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUrl2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox conn1Group;
        private System.Windows.Forms.Label lblDb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUrl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chkTo1;
        private System.Windows.Forms.CheckBox chkFrom1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateCheckTo;
        private System.Windows.Forms.DateTimePicker dateCheckFrom;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox itemTypesGroup;
        private System.Windows.Forms.CheckedListBox chkItemTypes;
        private System.Windows.Forms.DataGridView gridCheck;
        private System.Windows.Forms.ComboBox ddlConnection2;
        private System.Windows.Forms.ComboBox ddlConnection1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ddlConnection3;
        private System.Windows.Forms.Label lblDb3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUrl3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox imgLoadingCompare;
        private System.Windows.Forms.PictureBox imgLoadingCheck;
        private System.Windows.Forms.Button btnCheckAll;
    }
}

