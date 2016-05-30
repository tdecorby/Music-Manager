using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public String folderList = @"C:\test\folderlist.json";
        private Dictionary<string, List<string>> directories;
        protected IrrKlang.ISoundEngine irrKlangEngine;
        protected IrrKlang.ISound currentlyPlayingSound;
        protected string playingSongLoc;

        public Form1()
        {

            InitializeComponent();
            songList.ColumnCount = 9;
            songList.Columns[0].Name = "Title";
            songList.Columns[1].Name = "Artist";
            songList.Columns[2].Name = "Album";
            songList.Columns[3].Name = "Genre";
            songList.Columns[4].Name = "Track";
            songList.Columns[5].Name = "Year";
            songList.Columns[6].Name = "Size";
            songList.Columns[7].Name = "Location";
            songList.Columns[8].Name = "Root";
            songList.Columns[7].Visible = false;
            songList.Columns[8].Visible = false;
            songList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            songList.MultiSelect = true;

            if (!System.IO.File.Exists(folderList))
            {
                directories = new Dictionary<string, List<string>>
                {
                    {@"C:/test", new List<string> { }}
                };

                System.IO.File.WriteAllText(folderList, JsonConvert.SerializeObject(directories, Formatting.Indented));
            }
            else
            {
                directories = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(System.IO.File.ReadAllText(folderList));
            }

            getSongs();

            irrKlangEngine = new IrrKlang.ISoundEngine();
            

            songList.UserDeletingRow += songList_UserDeletingRow;
            songList.ClearSelection();

        }


        private void Play_Click(object sender, EventArgs e)
        {
            if (currentlyPlayingSound != null && !currentlyPlayingSound.)
			{
				if (currentlyPlayingSound.Paused)
                {
                    Play.Text = "Pause";
                    currentlyPlayingSound.Paused = false;
                }
                else
                {
                    Play.Text = "Play";
                    currentlyPlayingSound.Paused = true;
                }	
			}
            else
            {
                string[] si = getParsedSongData(songList);
                fileLookup.initializePlaylist(si[6], fileLookup.getGeneralPlaylist(getSortedList()), shuffleCheck.Checked);
                playSong(si);
            }

        }


        private void Edit_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = songList.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount == 0)
            {
                MessageBox.Show("Please select a Song");
            }else if (selectedCellCount <= songList.ColumnCount)
            {
                Form2 editForm = new Form2(this, getParsedSongData(songList));
                editForm.Show();  
            }else
            {
                MessageBox.Show("Please select only one Song");
            }

        }

        private void songList_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string[] songData = getParsedSongData(songList);
            DialogResult result = MessageBox.Show("Do you want to delete '" 
                + songData[0]
                +" by "
                + songData[1]
                + "'?", "Song Deletion", MessageBoxButtons.YesNoCancel);

            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (result == System.Windows.Forms.DialogResult.Yes)
            {
                File.Delete(songData[6]);
            }else
            {
                Dictionary<string, List<string>> jsonList = JsonConvert.DeserializeObject<Dictionary<string,List<string>>>(System.IO.File.ReadAllText(folderList));
                foreach(KeyValuePair<string, List<string>> d in jsonList)
                {
                    if(d.Key == songData[7])
                    {
                        d.Value.Add(songData[6]);
                        break;
                    }
                }
                System.IO.File.WriteAllText(folderList, JsonConvert.SerializeObject(jsonList, Formatting.Indented));

            }
            
        }

        public void getSongs()
        {
            songList.Rows.Clear();
            foreach (KeyValuePair<string, List<string>> d in directories)
            {
                fileLookup.getStoredSongsList(songList, d);
            }
            songList.Sort(songList.Columns[0], ListSortDirection.Ascending);
        }

        private void Select_Folder_Click(object sender, EventArgs e)
        {
            Form3 folderSelect = new Form3(this, directories);
            folderSelect.Show();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (currentlyPlayingSound != null)
            {
                Play.Text = "Play";
                playingLabel.Text = "";
                currentlyPlayingSound.Stop();
                int c = songList.CurrentRow.Index;
                songList.ClearSelection();
                songList.Rows[c].Selected = true;
                songList.Rows[c].Cells[0].Selected = true;
            }
                
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            if (currentlyPlayingSound != null)
                currentlyPlayingSound.Volume = VolumeBar.Value / 100.0f;
            
        }

        private void Next_Click(object sender, EventArgs e)
        {
            playSong(fileLookup.getNextSong());
        }

        private void playSong(string[] songInfo)
        {
            
            if (currentlyPlayingSound != null)
                currentlyPlayingSound.Stop();
            if (songInfo != null)
            {
                Play.Text = "Pause";
                StartTime.Text = "00:00";
                ProgressBar.Value = 0;
                playingLabel.Text = songInfo[0] + " by " + songInfo[1];
                playingSongLoc = songInfo[6];
                currentlyPlayingSound = irrKlangEngine.Play2D(playingSongLoc, false);
                ProgressBar.Maximum = (int)currentlyPlayingSound.PlayLength;
                TimeSpan t = TimeSpan.FromMilliseconds(currentlyPlayingSound.PlayLength);
                EndTime.Text = string.Format("{0:D2}:{1:D2}",t.Minutes,t.Seconds);
                InitTimer();
            }else
            {
                MessageBox.Show("Error with Song address");
            }


        }

        private string[] getParsedSongData(DataGridView songList)
        {
            string[] songInfo = new string[8];
            songInfo[0] = (songList.SelectedCells[0].Value == null)? "Unknown" : songList.SelectedCells[0].Value.ToString();    //title
            songInfo[1] = (songList.SelectedCells[1].Value == null)? "Unknown" : songList.SelectedCells[1].Value.ToString();    //artist
            songInfo[2] = (songList.SelectedCells[2].Value == null) ? "Unknown" : songList.SelectedCells[2].Value.ToString();   //album
            songInfo[3] = (songList.SelectedCells[3].Value == null) ? "Unknown" : songList.SelectedCells[3].Value.ToString();   //genre
            songInfo[4] = (songList.SelectedCells[4].Value == null) ? "0" : songList.SelectedCells[4].Value.ToString();         // track
            songInfo[5] = (songList.SelectedCells[5].Value == null) ? "0" : songList.SelectedCells[5].Value.ToString();         //year
            songInfo[6] = (songList.SelectedCells[7].Value == null) ? null : songList.SelectedCells[7].Value.ToString();        //location
            songInfo[7] = (songList.SelectedCells[8].Value == null) ? null : songList.SelectedCells[8].Value.ToString();        //root
            return songInfo;
        }

        private void songList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] si = getParsedSongData(songList);
            fileLookup.initializePlaylist(si[6], fileLookup.getGeneralPlaylist(getSortedList()), shuffleCheck.Checked);
            playSong(si);
        }


        private void ProgressBarClick(object sender, MouseEventArgs e)
        {
            if (currentlyPlayingSound != null)
            {
                uint x = Convert.ToUInt32(((double)e.X / (double)ProgressBar.Width) * (ProgressBar.Maximum - ProgressBar.Minimum));
                currentlyPlayingSound.PlayPosition = x;
                ProgressBar.Value = (int)x;
            }
                
        }

        private void volumeMouseClick(object sender, MouseEventArgs e)
        {
            if (currentlyPlayingSound != null)
            {
                float x = (float)(e.X / VolumeBar.Width) * (VolumeBar.Maximum - VolumeBar.Minimum);
                currentlyPlayingSound.Volume = x / 100.0f;
                VolumeBar.Value = (int)(x);
            }
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentlyPlayingSound != null)
            {
                try
                {
                    ProgressBar.Value = (int)currentlyPlayingSound.PlayPosition;
                    TimeSpan t = TimeSpan.FromMilliseconds(currentlyPlayingSound.PlayPosition);
                    StartTime.Text = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
                }
                catch (Exception error)
                {
                    Console.Write(error);
                }
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] si = getParsedSongData(songList);
            fileLookup.initializePlaylist(si[6], fileLookup.getGeneralPlaylist(getSortedList()),shuffleCheck.Checked);
            playSong(si);
        }

        private void songList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = songList.HitTest(e.X, e.Y);
                songList.ClearSelection();
                songList.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            playSong(fileLookup.getPrevSong());
        }
        private List<string> getSortedList()
        {
            List<string> temp = new List<string> { };
            foreach (DataGridViewRow row in songList.Rows)
            {
                temp.Add(row.Cells[7].Value.ToString());
            }
            return temp;
        }

        private void shuffleCheck_CheckedChanged(object sender, EventArgs e)
        {
            fileLookup.shuffleSelect(playingSongLoc, fileLookup.getGeneralPlaylist(getSortedList()), shuffleCheck.Checked);
        }
    }
}
