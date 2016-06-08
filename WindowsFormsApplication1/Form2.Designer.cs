namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Title = new System.Windows.Forms.Label();
            this.Title_textBox = new System.Windows.Forms.TextBox();
            this.Artist = new System.Windows.Forms.Label();
            this.Artist_textBox = new System.Windows.Forms.TextBox();
            this.Album = new System.Windows.Forms.Label();
            this.Album_textBox = new System.Windows.Forms.TextBox();
            this.Track = new System.Windows.Forms.Label();
            this.Track_textBox = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.Label();
            this.Genre_textBox = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.Label();
            this.Year_textBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Title_textBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Artist, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Artist_textBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Album, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Album_textBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Track, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Track_textBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Genre, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Genre_textBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Year, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Year_textBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Cancel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Save, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 251);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(3, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title";
            // 
            // Title_textBox
            // 
            this.Title_textBox.Location = new System.Drawing.Point(145, 3);
            this.Title_textBox.Name = "Title_textBox";
            this.Title_textBox.Size = new System.Drawing.Size(100, 20);
            this.Title_textBox.TabIndex = 0;
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.Location = new System.Drawing.Point(3, 26);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(30, 13);
            this.Artist.TabIndex = 3;
            this.Artist.Text = "Artist";
            // 
            // Artist_textBox
            // 
            this.Artist_textBox.Location = new System.Drawing.Point(145, 29);
            this.Artist_textBox.Name = "Artist_textBox";
            this.Artist_textBox.Size = new System.Drawing.Size(100, 20);
            this.Artist_textBox.TabIndex = 8;
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.Location = new System.Drawing.Point(3, 52);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(36, 13);
            this.Album.TabIndex = 5;
            this.Album.Text = "Album";
            // 
            // Album_textBox
            // 
            this.Album_textBox.Location = new System.Drawing.Point(145, 55);
            this.Album_textBox.Name = "Album_textBox";
            this.Album_textBox.Size = new System.Drawing.Size(100, 20);
            this.Album_textBox.TabIndex = 9;
            // 
            // Track
            // 
            this.Track.AutoSize = true;
            this.Track.Location = new System.Drawing.Point(3, 78);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(75, 13);
            this.Track.TabIndex = 7;
            this.Track.Text = "Track Number";
            // 
            // Track_textBox
            // 
            this.Track_textBox.Location = new System.Drawing.Point(145, 81);
            this.Track_textBox.Name = "Track_textBox";
            this.Track_textBox.Size = new System.Drawing.Size(100, 20);
            this.Track_textBox.TabIndex = 10;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(3, 104);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(36, 13);
            this.Genre.TabIndex = 4;
            this.Genre.Text = "Genre";
            // 
            // Genre_textBox
            // 
            this.Genre_textBox.Location = new System.Drawing.Point(145, 107);
            this.Genre_textBox.Name = "Genre_textBox";
            this.Genre_textBox.Size = new System.Drawing.Size(100, 20);
            this.Genre_textBox.TabIndex = 11;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(3, 130);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 15;
            this.Year.Text = "Year";
            // 
            // Year_textBox
            // 
            this.Year_textBox.Location = new System.Drawing.Point(145, 133);
            this.Year_textBox.Name = "Year_textBox";
            this.Year_textBox.Size = new System.Drawing.Size(100, 20);
            this.Year_textBox.TabIndex = 14;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(3, 159);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Close_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(145, 159);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 258);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Title_textBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.Label Album;
        private System.Windows.Forms.Label Track;
        private System.Windows.Forms.TextBox Artist_textBox;
        private System.Windows.Forms.TextBox Album_textBox;
        private System.Windows.Forms.TextBox Track_textBox;
        private System.Windows.Forms.TextBox Genre_textBox;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox Year_textBox;
        private System.Windows.Forms.Label Year;
    }
}