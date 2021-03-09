
namespace ArasDiffTool.Win
{
    partial class SettingsConnections
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
            this.pnlConn1 = new System.Windows.Forms.GroupBox();
            this.txtConn1Name = new System.Windows.Forms.TextBox();
            this.btnConn1Test = new System.Windows.Forms.Button();
            this.btnConn1Delete = new System.Windows.Forms.Button();
            this.btnConn1Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConn1Db = new System.Windows.Forms.TextBox();
            this.txtConn1User = new System.Windows.Forms.TextBox();
            this.txtConn1Pass = new System.Windows.Forms.TextBox();
            this.txtConn1Url = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupSaved = new System.Windows.Forms.GroupBox();
            this.lstSaved = new System.Windows.Forms.ListBox();
            this.pnlConn1.SuspendLayout();
            this.groupSaved.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConn1
            // 
            this.pnlConn1.Controls.Add(this.txtConn1Name);
            this.pnlConn1.Controls.Add(this.btnConn1Test);
            this.pnlConn1.Controls.Add(this.btnConn1Delete);
            this.pnlConn1.Controls.Add(this.btnConn1Save);
            this.pnlConn1.Controls.Add(this.label5);
            this.pnlConn1.Controls.Add(this.label4);
            this.pnlConn1.Controls.Add(this.label3);
            this.pnlConn1.Controls.Add(this.label2);
            this.pnlConn1.Controls.Add(this.label1);
            this.pnlConn1.Controls.Add(this.txtConn1Db);
            this.pnlConn1.Controls.Add(this.txtConn1User);
            this.pnlConn1.Controls.Add(this.txtConn1Pass);
            this.pnlConn1.Controls.Add(this.txtConn1Url);
            this.pnlConn1.Location = new System.Drawing.Point(291, 33);
            this.pnlConn1.Name = "pnlConn1";
            this.pnlConn1.Size = new System.Drawing.Size(274, 329);
            this.pnlConn1.TabIndex = 0;
            this.pnlConn1.TabStop = false;
            this.pnlConn1.Text = "Connection settings";
            // 
            // txtConn1Name
            // 
            this.txtConn1Name.Location = new System.Drawing.Point(24, 51);
            this.txtConn1Name.Name = "txtConn1Name";
            this.txtConn1Name.Size = new System.Drawing.Size(224, 20);
            this.txtConn1Name.TabIndex = 1;
            // 
            // btnConn1Test
            // 
            this.btnConn1Test.Location = new System.Drawing.Point(24, 287);
            this.btnConn1Test.Name = "btnConn1Test";
            this.btnConn1Test.Size = new System.Drawing.Size(55, 23);
            this.btnConn1Test.TabIndex = 6;
            this.btnConn1Test.Text = "Test";
            this.btnConn1Test.UseVisualStyleBackColor = true;
            this.btnConn1Test.Click += new System.EventHandler(this.btnConn1Test_Click);
            // 
            // btnConn1Delete
            // 
            this.btnConn1Delete.Location = new System.Drawing.Point(173, 287);
            this.btnConn1Delete.Name = "btnConn1Delete";
            this.btnConn1Delete.Size = new System.Drawing.Size(75, 23);
            this.btnConn1Delete.TabIndex = 8;
            this.btnConn1Delete.Text = "Delete";
            this.btnConn1Delete.UseVisualStyleBackColor = true;
            this.btnConn1Delete.Click += new System.EventHandler(this.btnConn1Delete_Click);
            // 
            // btnConn1Save
            // 
            this.btnConn1Save.Location = new System.Drawing.Point(92, 287);
            this.btnConn1Save.Name = "btnConn1Save";
            this.btnConn1Save.Size = new System.Drawing.Size(75, 23);
            this.btnConn1Save.TabIndex = 7;
            this.btnConn1Save.Text = "Save";
            this.btnConn1Save.UseVisualStyleBackColor = true;
            this.btnConn1Save.Click += new System.EventHandler(this.btnConn1Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Url";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // txtConn1Db
            // 
            this.txtConn1Db.Location = new System.Drawing.Point(24, 146);
            this.txtConn1Db.Name = "txtConn1Db";
            this.txtConn1Db.Size = new System.Drawing.Size(224, 20);
            this.txtConn1Db.TabIndex = 3;
            // 
            // txtConn1User
            // 
            this.txtConn1User.Location = new System.Drawing.Point(24, 193);
            this.txtConn1User.Name = "txtConn1User";
            this.txtConn1User.Size = new System.Drawing.Size(224, 20);
            this.txtConn1User.TabIndex = 4;
            // 
            // txtConn1Pass
            // 
            this.txtConn1Pass.Location = new System.Drawing.Point(24, 240);
            this.txtConn1Pass.Name = "txtConn1Pass";
            this.txtConn1Pass.Size = new System.Drawing.Size(224, 20);
            this.txtConn1Pass.TabIndex = 5;
            // 
            // txtConn1Url
            // 
            this.txtConn1Url.Location = new System.Drawing.Point(24, 99);
            this.txtConn1Url.Name = "txtConn1Url";
            this.txtConn1Url.Size = new System.Drawing.Size(224, 20);
            this.txtConn1Url.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(490, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupSaved
            // 
            this.groupSaved.Controls.Add(this.lstSaved);
            this.groupSaved.Location = new System.Drawing.Point(31, 33);
            this.groupSaved.Name = "groupSaved";
            this.groupSaved.Size = new System.Drawing.Size(242, 329);
            this.groupSaved.TabIndex = 4;
            this.groupSaved.TabStop = false;
            this.groupSaved.Text = "Saved connections";
            // 
            // lstSaved
            // 
            this.lstSaved.FormattingEnabled = true;
            this.lstSaved.Location = new System.Drawing.Point(17, 35);
            this.lstSaved.Name = "lstSaved";
            this.lstSaved.Size = new System.Drawing.Size(209, 277);
            this.lstSaved.TabIndex = 0;
            this.lstSaved.DoubleClick += new System.EventHandler(this.lstSaved_DoubleClick);
            // 
            // SettingsConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 434);
            this.Controls.Add(this.groupSaved);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlConn1);
            this.MaximizeBox = false;
            this.Name = "SettingsConnections";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connections";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formConnections_Load);
            this.pnlConn1.ResumeLayout(false);
            this.pnlConn1.PerformLayout();
            this.groupSaved.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlConn1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtConn1Db;
        private System.Windows.Forms.TextBox txtConn1User;
        private System.Windows.Forms.TextBox txtConn1Pass;
        private System.Windows.Forms.TextBox txtConn1Url;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConn1Delete;
        private System.Windows.Forms.Button btnConn1Save;
        private System.Windows.Forms.Button btnConn1Test;
        private System.Windows.Forms.TextBox txtConn1Name;
        private System.Windows.Forms.GroupBox groupSaved;
        private System.Windows.Forms.ListBox lstSaved;
    }
}