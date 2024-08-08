using System;
using System.Collections.Generic;

namespace MusicAppWPF
{
    internal class SongNode
    {
        public SongNode(string songName, string filePath, SongNode next, SongNode previous)
        {
            SongName = songName;
            FilePath = filePath;
            Next = next;
            Previous = previous;
        }

        public string SongName { get; set; }
        public string FilePath { get; set; }
        public SongNode Next { get; set; }
        public SongNode Previous { get; set; }
    }

    internal class Playlist
    {
        private SongNode head;
        private SongNode tail;
        public SongNode CurrentSong { get; private set; }

        public SongNode GetHead()
        {
            return head;
        }

        public void AddSong(string songName, string filePath)
        {
            var newSong = new SongNode(songName, filePath, null, null);

            if (head == null)
            {
                // The playlist is empty
                head = newSong;
                tail = newSong;
                head.Next = head; // Circular reference
                head.Previous = head; // Circular reference
                CurrentSong = head;
            }
            else
            {
                // Adding to non-empty playlist
                tail.Next = newSong;
                newSong.Previous = tail;
                newSong.Next = head;
                head.Previous = newSong;
                tail = newSong;
            }
        }

        public void PlaySong()
        {
            if (CurrentSong != null)
            {
                // Implement playback logic here
                // For example: set up volume, start playback, etc.
            }
        }

        public void ShufflePlaylist()
        {
            var songs = new List<SongNode>();
            var current = head;

            if (current == null) return;

            do
            {
                songs.Add(current);
                current = current.Next;
            } while (current != head);

            var rand = new Random();
            for (int i = songs.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                var temp = songs[i];
                songs[i] = songs[j];
                songs[j] = temp;
            }

            head = songs[0];
            tail = songs[songs.Count - 1];
            for (int i = 0; i < songs.Count; i++)
            {
                songs[i].Next = (i < songs.Count - 1) ? songs[i + 1] : head;
                songs[i].Previous = (i > 0) ? songs[i - 1] : tail;
            }
        }

        public void NextSong()
        {
            if (CurrentSong != null)
            {
                CurrentSong = CurrentSong.Next;
            }
        }

        public void PreviousSong()
        {
            if (CurrentSong != null)
            {
                CurrentSong = CurrentSong.Previous;
            }
        }
    }
}
