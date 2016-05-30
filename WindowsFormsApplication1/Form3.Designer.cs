namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.folderList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.add_folder = new System.Windows.Forms.Button();
            this.edit_Folder = new System.Windows.Forms.Button();
            this.delete_Folder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderList
            // 
            this.folderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderList.FormattingEnabled = true;
            this.folderList.Location = new System.Drawing.Point(123, 3);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(301, 332);
            this.folderList.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.folderList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 338);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.delete_Folder, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.edit_Folder, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.add_folder, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(114, 100);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // add_folder
            // 
            this.add_folder.Location = new System.Drawing.Point(3, 3);
            this.add_folder.Name = "add_folder";
            this.add_folder.Size = new System.Drawing.Size(111, 23);
            this.add_folder.TabIndex = 0;
            this.add_folder.Text = "Add Folder";
            this.add_folder.UseVisualStyleBackColor = true;
            this.add_folder.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit_Folder
            // 
            this.edit_Folder.Location = new System.Drawing.Point(3, 32);
            this.edit_Folder.Name = "edit_Folder";
            this.edit_Folder.Size = new System.Drawing.Size(111, 23);
            this.edit_Folder.TabIndex = 1;
            this.edit_Folder.Text = "Edit Folder";
            this.edit_Folder.UseVisualStyleBackColor = true;
            // 
            // delete_Folder
            // 
            this.delete_Folder.Location = new System.Drawing.Point(3, 61);
            this.delete_Folder.Name = "delete_Folder";
            this.delete_Folder.Size = new System.Drawing.Size(111, 23);
            this.delete_Folder.TabIndex = 2;
            this.delete_Folder.Text = "Delete Folder";
            this.delete_Folder.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 338);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox folderList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button add_folder;
        private System.Windows.Forms.Button edit_Folder;
        private System.Windows.Forms.Button delete_Folder;
    }
}