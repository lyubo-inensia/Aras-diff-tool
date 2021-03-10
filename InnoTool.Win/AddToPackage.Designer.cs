
namespace InnoTool.Win
{
    partial class AddToPackage
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
            this.listPackages = new System.Windows.Forms.ListBox();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPackages
            // 
            this.listPackages.FormattingEnabled = true;
            this.listPackages.Location = new System.Drawing.Point(34, 62);
            this.listPackages.Name = "listPackages";
            this.listPackages.Size = new System.Drawing.Size(381, 329);
            this.listPackages.TabIndex = 0;
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(34, 30);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(267, 20);
            this.txtPackageName.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(307, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create package";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(307, 406);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(108, 23);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add to package";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(34, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddToPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 452);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.listPackages);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddToPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToPackage";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPackages;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCancel;
    }
}