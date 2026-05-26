using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTPSIT.Spotify.Domain.Studente1
{
    public class Artist
    { 
        public string StageName { get; init; }
        public string MusicGenre { get; init; }

        public List<Song> Songs { get; private set; } = new List<Song>();

        public Artist(string stageName, string musicGenre)
        {
            if (string.IsNullOrWhiteSpace(stageName))
                throw new ArgumentException("Stage name cannot be null or empty.", nameof(stageName));

            StageName = stageName;
            MusicGenre = string.IsNullOrWhiteSpace(musicGenre) ? "Unknown" : musicGenre;
        }

        public void AddSong(Song song)
        {
            if (song != null)
            {
                Songs.Add(song);
            }
        }

        public override string ToString()
        {
            return $"Artist: {StageName} | Genre: {MusicGenre} | Total Songs: {Songs.Count}";
        }
    }
}
