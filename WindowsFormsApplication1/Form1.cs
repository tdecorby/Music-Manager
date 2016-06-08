using NAudio;
using NAudio.Wave;
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
using Un4seen.Bass;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public String folderList = @"C:\test\folderlist.json";
        private Dictionary<string, List<string>> directories;
        protected IrrKlang.ISoundEngine irrKlangEngine;
        protected IrrKlang.ISound currentlyPlayingSound;
        protected IWavePlayer waveOutDevice;
        protected AudioFileReader audioFileReader;
        
        protected string playingSongLoc;
        int title = 0, artist = 1, album = 2, genre = 3, track = 4, year = 5, size = 6, loc = 7, root = 8, columns = 10;

        public Form1()
        {

            InitializeComponent();
            songList.ColumnCount = columns;
            songList.Columns[title].Name = "Title";
            songList.Columns[artist].Name = "Artist";
            songList.Columns[album].Name = "Album";
            songList.Columns[genre].Name = "Genre";
            songList.Columns[track].Name = "Track";
            songList.Columns[year].Name = "Year";
            songList.Columns[size].Name = "Size";
            songList.Columns[loc].Name = "Location";
            songList.Columns[root].Name = "Root";
            songList.Columns[9].Name = "Length";
            songList.Columns[loc].Visible = false;
            songList.Columns[root].Visible = false;
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
            waveOutDevice = new WaveOut();

            songList.UserDeletingRow += songList_UserDeletingRow;
            songList.ClearSelection();

        }


        private void Play_Click(object sender, EventArgs e)
        {
            if (currentlyPlayingSound != null && !currentlyPlayingSound.Finished)
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
            if (waveOutDevice != null)
            {
                Play.Text = "Play";
                playingLabel.Text = "";
                waveOutDevice.Stop();
                
                //currentlyPlayingSound.Stop();
                int c = songList.CurrentRow.Index;
                songList.ClearSelection();
                songList.Rows[c].Selected = true;
                songList.Rows[c].Cells[0].Selected = true;
                foreach (DataGridViewRow row in songList.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        
                            cell.Style.ForeColor = Color.Black;
                            cell.Style.SelectionForeColor = Color.Black;
                        
                    }
                }
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

            if (waveOutDevice.PlaybackState == PlaybackState.Playing)
                waveOutDevice.Dispose();
            if (songInfo != null)
            {
                waveOutDevice = new WaveOut();
                Play.Text = "Pause";
                StartTime.Text = "00:00";
                ProgressBar.Value = 0;
                playingLabel.Text = songInfo[0] + " by " + songInfo[1];
                playingSongLoc = songInfo[6];
                audioFileReader = new AudioFileReader(songInfo[6]);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();

                //currentlyPlayingSound = irrKlangEngine.Play2D(playingSongLoc, false);
                ProgressBar.Maximum = (int)audioFileReader.TotalTime.TotalMilliseconds;
                TimeSpan t = audioFileReader.TotalTime;
                EndTime.Text = string.Format("{0:D2}:{1:D2}",t.Minutes,t.Seconds);
                InitTimer();
                foreach (DataGridViewRow row in songList.Rows)
                {
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        if (row.Cells[loc].Value.ToString() == playingSongLoc)
                        {
                            cell.Style.ForeColor = Color.Blue;
                            cell.Style.SelectionForeColor = Color.Blue;
                        }
                        else
                        {
                            cell.Style.ForeColor = Color.Black;
                            cell.Style.SelectionForeColor = Color.Black;
                        }
                    }
                }
                
            }else
            {
                MessageBox.Show("Error with Song address");
            }


        }

        private string[] getParsedSongData(DataGridView songList)
        {
            string[] songInfo = new string[8];
            songInfo[0] = (songList.SelectedCells[title].Value == null)? "Unknown" : songList.SelectedCells[title].Value.ToString();    //title
            songInfo[1] = (songList.SelectedCells[artist].Value == null)? "Unknown" : songList.SelectedCells[artist].Value.ToString();    //artist
            songInfo[2] = (songList.SelectedCells[album].Value == null) ? "Unknown" : songList.SelectedCells[album].Value.ToString();   //album
            songInfo[3] = (songList.SelectedCells[genre].Value == null) ? "Unknown" : songList.SelectedCells[genre].Value.ToString();   //genre
            songInfo[4] = (songList.SelectedCells[track].Value == null) ? "0" : songList.SelectedCells[track].Value.ToString();         // track
            songInfo[5] = (songList.SelectedCells[year].Value == null) ? "0" : songList.SelectedCells[year].Value.ToString();         //year
            songInfo[6] = (songList.SelectedCells[loc].Value == null) ? null : songList.SelectedCells[loc].Value.ToString();        //location
            songInfo[7] = (songList.SelectedCells[root].Value == null) ? null : songList.SelectedCells[root].Value.ToString();        //root
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
            if (waveOutDevice != null)
            {
                long x = (long)(e.X / (double)ProgressBar.Width) * (ProgressBar.Maximum - ProgressBar.Minimum);
                TimeSpan t = new TimeSpan(x);
                
                ProgressBar.Value = t.Milliseconds;
                //waveOutDevice.Dispose();
                //waveOutDevice = new WaveOut();
                //audioFileReader.Position += audioFileReader.WaveFormat.AverageBytesPerSecond * t.Milliseconds;
                audioFileReader.CurrentTime = audioFileReader.CurrentTime.Add(t);
                //waveOutDevice.Init(audioFileReader);
                //waveOutDevice.Play();
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
            timer1.Interval = 1; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (waveOutDevice != null)
            {
                try
                {
                    if (waveOutDevice.PlaybackState == PlaybackState.Stopped && Play.Text == "Pause")
                    {
                        playSong(fileLookup.getNextSong());
                    }
                    ProgressBar.Value = (int)audioFileReader.CurrentTime.TotalMilliseconds;
                    TimeSpan t = audioFileReader.CurrentTime;
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
