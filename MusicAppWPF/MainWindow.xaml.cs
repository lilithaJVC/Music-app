using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MusicAppWPF
{
    public partial class MainWindow : Window
    {
        private Playlist playlist;

        public MainWindow()
        {
            InitializeComponent();
            playlist = new Playlist();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            // Add a song to the playlist
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string songPath = openFileDialog.FileName;
                string songName = System.IO.Path.GetFileNameWithoutExtension(songPath);
                playlist.AddSong(songName, songPath);
                UpdatePlaylistUI();
            }
        }

        private void UpdatePlaylistUI()
        {
            listsong.Items.Clear();
            SongNode current = playlist.GetHead();
            if (current != null)
            {
                do
                {
                    listsong.Items.Add(current.SongName);
                    current = current.Next;
                } while (current != playlist.GetHead());
            }
        }

        private void playbtn_Click(object sender, RoutedEventArgs e)
        {
            if (playlist.CurrentSong != null)
            {
                try
                {
                    MDelement.Source = new Uri(playlist.CurrentSong.FilePath, UriKind.Absolute);
                    MDelement.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error playing media: " + ex.Message);
                }
            }
        }

        private void nextbtn_Click(object sender, RoutedEventArgs e)
        {
            playlist.NextSong();
            playbtn_Click(sender, e);
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            playlist.PreviousSong();
            playbtn_Click(sender, e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Implement shuffle functionality
            playlist.ShufflePlaylist();
            UpdatePlaylistUI();
        }

        // Event handlers for MediaElement
        private void MDelement_MediaOpened(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Media Opened");
        }

        private void MDelement_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("Failed to load media: " + e.ErrorException.Message);
        }

        private void MDelement_MediaEnded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Media Ended");
        }

        private void backbtn_Click_1(object sender, RoutedEventArgs e)
        {
            playlist.PreviousSong();
            playbtn_Click(sender, e);
        }
    }
}
