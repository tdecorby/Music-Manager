using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.songListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToCurrentQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.songList = new System.Windows.Forms.DataGridView();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.Next = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.playingLabel = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Edit = new System.Windows.Forms.Button();
            this.Select_Folder = new System.Windows.Forms.Button();
            this.EndTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.shuffleCheck = new System.Windows.Forms.CheckBox();
            this.songListMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // songListMenu
            // 
            this.songListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.editToolStripMenuItem,
            this.addToCurrentQueueToolStripMenuItem,
            this.addToPlaylistToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.songListMenu.Name = "songListMenu";
            this.songListMenu.Size = new System.Drawing.Size(192, 114);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.Edit_Click);
            // 
            // addToCurrentQueueToolStripMenuItem
            // 
            this.addToCurrentQueueToolStripMenuItem.Name = "addToCurrentQueueToolStripMenuItem";
            this.addToCurrentQueueToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addToCurrentQueueToolStripMenuItem.Text = "Add to Current Queue";
            // 
            // addToPlaylistToolStripMenuItem
            // 
            this.addToPlaylistToolStripMenuItem.Name = "addToPlaylistToolStripMenuItem";
            this.addToPlaylistToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addToPlaylistToolStripMenuItem.Text = "Add to Playlist";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // songList
            // 
            this.songList.AllowUserToAddRows = false;
            this.songList.AllowUserToOrderColumns = true;
            this.songList.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            this.songList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.songList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.songList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.songList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.songList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songList.ContextMenuStrip = this.songListMenu;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.songList.DefaultCellStyle = dataGridViewCellStyle8;
            this.songList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.songList.Location = new System.Drawing.Point(128, 78);
            this.songList.Name = "songList";
            this.songList.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.songList.RowHeadersVisible = false;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            this.songList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.songList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.songList.ShowCellToolTips = false;
            this.songList.Size = new System.Drawing.Size(776, 477);
            this.songList.TabIndex = 0;
            this.songList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.songList_CellContentDoubleClick);
            this.songList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.songList_MouseDown);
            // 
            // VolumeBar
            // 
            this.VolumeBar.AllowDrop = true;
            this.VolumeBar.LargeChange = 10;
            this.VolumeBar.Location = new System.Drawing.Point(269, 3);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(104, 45);
            this.VolumeBar.SmallChange = 5;
            this.VolumeBar.TabIndex = 7;
            this.VolumeBar.TickFrequency = 5;
            this.VolumeBar.Value = 75;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            this.VolumeBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volumeMouseClick);
            // 
            // Next
            // 
            this.Next.AutoSize = true;
            this.Next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Next.Location = new System.Drawing.Point(159, 3);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(39, 23);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Stop
            // 
            this.Stop.AutoSize = true;
            this.Stop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Stop.Location = new System.Drawing.Point(114, 3);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(39, 23);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Play
            // 
            this.Play.AutoSize = true;
            this.Play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Play.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Play.Location = new System.Drawing.Point(48, 3);
            this.Play.MinimumSize = new System.Drawing.Size(60, 0);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(60, 23);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Prev
            // 
            this.Prev.AutoSize = true;
            this.Prev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Prev.Location = new System.Drawing.Point(3, 3);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(39, 23);
            this.Prev.TabIndex = 5;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // playingLabel
            // 
            this.playingLabel.AutoSize = true;
            this.playingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playingLabel.Location = new System.Drawing.Point(59, 0);
            this.playingLabel.MinimumSize = new System.Drawing.Size(780, 0);
            this.playingLabel.Name = "playingLabel";
            this.playingLabel.Size = new System.Drawing.Size(780, 13);
            this.playingLabel.TabIndex = 2;
            this.playingLabel.Text = "Playing Label";
            this.playingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartTime
            // 
            this.StartTime.AutoSize = true;
            this.StartTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.StartTime.Location = new System.Drawing.Point(3, 0);
            this.StartTime.MinimumSize = new System.Drawing.Size(50, 0);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(50, 13);
            this.StartTime.TabIndex = 8;
            this.StartTime.Text = "00:00";
            this.StartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.Edit);
            this.flowLayoutPanel1.Controls.Add(this.Select_Folder);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(119, 477);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Edit
            // 
            this.Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit.AutoSize = true;
            this.Edit.Location = new System.Drawing.Point(3, 3);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(116, 23);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Select_Folder
            // 
            this.Select_Folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Select_Folder.AutoSize = true;
            this.Select_Folder.Location = new System.Drawing.Point(3, 32);
            this.Select_Folder.Name = "Select_Folder";
            this.Select_Folder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Select_Folder.Size = new System.Drawing.Size(116, 23);
            this.Select_Folder.TabIndex = 3;
            this.Select_Folder.Text = "Select Folders";
            this.Select_Folder.UseVisualStyleBackColor = true;
            this.Select_Folder.Click += new System.EventHandler(this.Select_Folder_Click);
            // 
            // EndTime
            // 
            this.EndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EndTime.Location = new System.Drawing.Point(845, 0);
            this.EndTime.MinimumSize = new System.Drawing.Size(50, 0);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(50, 13);
            this.EndTime.TabIndex = 9;
            this.EndTime.Text = "00:00";
            this.EndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.songList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 558);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ProgressBar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(901, 69);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.White;
            this.ProgressBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressBar.Location = new System.Drawing.Point(3, 28);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(895, 9);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 4;
            this.ProgressBar.Value = 100;
            this.ProgressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.StartTime);
            this.flowLayoutPanel2.Controls.Add(this.playingLabel);
            this.flowLayoutPanel2.Controls.Add(this.EndTime);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 6);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(898, 13);
            this.flowLayoutPanel2.TabIndex = 5;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.Prev);
            this.flowLayoutPanel3.Controls.Add(this.Play);
            this.flowLayoutPanel3.Controls.Add(this.Stop);
            this.flowLayoutPanel3.Controls.Add(this.Next);
            this.flowLayoutPanel3.Controls.Add(this.shuffleCheck);
            this.flowLayoutPanel3.Controls.Add(this.VolumeBar);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(262, 43);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(376, 51);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // shuffleCheck
            // 
            this.shuffleCheck.AutoSize = true;
            this.shuffleCheck.Location = new System.Drawing.Point(204, 3);
            this.shuffleCheck.Name = "shuffleCheck";
            this.shuffleCheck.Size = new System.Drawing.Size(59, 17);
            this.shuffleCheck.TabIndex = 8;
            this.shuffleCheck.Text = "Shuffle";
            this.shuffleCheck.UseVisualStyleBackColor = true;
            this.shuffleCheck.CheckedChanged += new System.EventHandler(this.shuffleCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(907, 558);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Music Manager";
            this.songListMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ContextMenuStrip songListMenu;
        private ToolStripMenuItem playToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addToCurrentQueueToolStripMenuItem;
        private ToolStripMenuItem addToPlaylistToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private DataGridView songList;
        private Label StartTime;
        private Label playingLabel;
        private Button Prev;
        private Button Play;
        private Button Stop;
        private Button Next;
        private TrackBar VolumeBar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Edit;
        private Button Select_Folder;
        private TableLayoutPanel tableLayoutPanel1;
        private Label EndTime;
        private ProgressBar ProgressBar;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private CheckBox shuffleCheck;
    }
}

