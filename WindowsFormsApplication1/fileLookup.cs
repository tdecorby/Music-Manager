using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class fileLookup {
        private static string storedSongsLoc = @"C:/test/savedSongList.json";
        private static Dictionary<string, List<string>> storedSongs = new Dictionary<string, List<string>> { };
        private static List<string> playlist;
        private static int playlistCounter;

        public static void getMusicFiles(DataGridView dgv,KeyValuePair<string,List<string>> dir)
        {
            
            bool removedSong = false;
            
            storedSongs = new Dictionary<string, List<string>> { };
            foreach (String file in System.IO.Directory.GetFiles(@dir.Key, "*.*", System.IO.SearchOption.AllDirectories))
            {
                FileInfo f = new FileInfo(file);
                if (String.Compare(f.Extension, ".mp3", StringComparison.OrdinalIgnoreCase) == 0 
                    || String.Compare(f.Extension, ".wav", StringComparison.OrdinalIgnoreCase) == 0 
                    || String.Compare(f.Extension, ".flac", StringComparison.OrdinalIgnoreCase) == 0 
                    //|| String.Compare(f.Extension, ".aiff", StringComparison.OrdinalIgnoreCase) == 0
                    || String.Compare(f.Extension, ".m4a", StringComparison.OrdinalIgnoreCase) == 0)
                    //|| String.Compare(f.Extension, ".ogg", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    foreach (String rsong in dir.Value)
                    {
                        if (rsong == f.FullName)
                            removedSong = true;
                    }
                    if (!removedSong)
                    {
                        TagLib.File meta = TagLib.File.Create(f.FullName);
                        TimeSpan t = TimeSpan.FromMilliseconds(meta.Properties.Duration.TotalMilliseconds);
                        dgv.Rows.Add(meta.Tag.Title, 
                            meta.Tag.FirstAlbumArtist, 
                            meta.Tag.Album,
                            meta.Tag.FirstGenre,
                            meta.Tag.Track,
                            meta.Tag.Year,
                            Math.Round(f.Length / 1048576.0, 2) + " Mb", 
                            f.FullName, 
                            dir.Key, 
                            string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds));
                        
                            storedSongs.Add(f.FullName, new List<string> {
                                meta.Tag.Title,
                                meta.Tag.FirstAlbumArtist,
                                meta.Tag.Album,
                                meta.Tag.FirstGenre,
                                meta.Tag.Track.ToString(),
                                meta.Tag.Year.ToString(),
                                Math.Round(f.Length / 1048576.0, 2) + " Mb",
                                dir.Key,
                                string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds) });
                    }
                    removedSong = false;
                }
                
            }
           // if (!System.IO.File.Exists(storedSongsLoc))
            //{
                System.IO.File.WriteAllText(storedSongsLoc, JsonConvert.SerializeObject(storedSongs, Formatting.Indented));
            //}
        }

        public static void getStoredSongsList(DataGridView dgv, KeyValuePair<string, List<string>> dir)
        {
            //if (System.IO.File.Exists(storedSongsLoc))
            //{
            //    storedSongs = JsonConvert.DeserializeObject<Dictionary<string,List<string>>>(System.IO.File.ReadAllText(storedSongsLoc));
            //    foreach(KeyValuePair<string,List<string>> kvp in storedSongs)
            //    {
            //        string[] array = kvp.Value.ToArray();
           //         dgv.Rows.Add(array[0], array[1], array[2], array[3], array[4], array[5], array[6], kvp.Key, array[7], array[8]);
            //    }
            //}
            //else
          //  {
                getMusicFiles(dgv,dir);
           // }
        }

        public static void editMeta(Form1 form1,Form form2, string[] songData)
        {
            TagLib.File meta = TagLib.File.Create(new System.IO.FileInfo(songData[6]).FullName);
            meta.Tag.Title = songData[0];
            meta.Tag.Performers = new[] { songData[1] };
            meta.Tag.AlbumArtists = new[] { songData[1]};
            meta.Tag.Album =  songData[2];
            meta.Tag.Genres = new[] { songData[3] };
            meta.Tag.Track = Convert.ToUInt32(songData[4]);
            meta.Tag.Year = Convert.ToUInt32(songData[5]);
            meta.Save();
            form1.getSongs();
            form2.Close();
            
        }

        public static List<string> getGeneralPlaylist(List<string> sortedSongs)
        {
            playlist = new List<string> { };
            playlist = sortedSongs.ConvertAll(x => x);
            return playlist;
        }

        public static void initializePlaylist(string currentSong, List<string> playlist, bool doShuffle)
        {
            playlistCounter = 0;
            foreach(string str in playlist)
            {
                if(str == currentSong)
                    break;
                playlistCounter++;
            }
            if (doShuffle)
                shufflePlaylist();
        }
        public static string[] getNextSong()
        {
            playlistCounter = (playlistCounter < (playlist.Count-1)) ? ++playlistCounter : 0;
            return getSongInfo(playlist[playlistCounter]);

        }
        public static string[] getPrevSong()
        {
            playlistCounter = (playlistCounter > 0) ? --playlistCounter : (playlist.Count-1);
            return getSongInfo(playlist[playlistCounter]);
        }
        public static string[] getSongInfo(string str)
        {
            foreach (KeyValuePair<string,List<string>> kvp in storedSongs)
            {
                //Console.WriteLine(str+"    "+kvp.Key);
                if(str == kvp.Key)
                {
                    string[] raw = kvp.Value.ToArray();
                    string[] songInfo = new string[8];
                    songInfo[0] = (raw[0] == "") ? "Unknown" : raw[0];    //title
                    songInfo[1] = (raw[0] == "") ? "Unknown" : raw[1];    //artist
                    songInfo[2] = (raw[0] == "") ? "Unknown" : raw[2];   //album
                    songInfo[3] = (raw[0] == "") ? "Unknown" : raw[3];   //genre
                    songInfo[4] = (raw[0] == "") ? "0" : raw[4];         // track
                    songInfo[5] = (raw[0] == "") ? "0" : raw[5];         //year
                    songInfo[6] = str;       //location
                    songInfo[7] = (raw[0] == "") ? "" : raw[6];        //root
                    return songInfo;
                }
            }
            return null;
        }
        public static void shuffleSelect(string currentSong, List<string> playlist, bool doShuffle)
        {
            if (playlist.Any() && doShuffle)
            {
                shufflePlaylist();
            }else
            {
                initializePlaylist(currentSong,getGeneralPlaylist(playlist),doShuffle);
            }
        }
        public static void shufflePlaylist()
        {
            string currentSong = playlist[playlistCounter];
            Random rand = new Random();
            int r;
            List<string> temp = new List<string> { };
            while(playlist.Count > 1)
            {
                r = rand.Next(playlist.Count);
                temp.Add(playlist[r]);
                playlist.Remove(playlist[r]);
            }
            temp.Add(playlist[0]);
            playlist = temp.ConvertAll(x => x);
            playlistCounter = 0;
            foreach (string str in playlist)
            {
                if (str == currentSong)
                    break;
                playlistCounter++;
            }
        }
    }
}
