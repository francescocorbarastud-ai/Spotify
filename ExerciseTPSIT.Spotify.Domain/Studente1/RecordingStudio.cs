using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTPSIT.Spotify.Domain.Studente1
{
    public class RecordingStudio
    {
        public string StudioName { get; init; }
        public string City { get; init; }

        public List<Song> RecordedSongs { get; private set; } = new List<Song>();

        public RecordingStudio(string studioName, string city)
        {
            if (string.IsNullOrWhiteSpace(studioName))
                throw new ArgumentException("Studio name cannot be null or empty.", nameof(studioName));

            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City cannot be null or empty.", nameof(city));

            StudioName = studioName;
            City = city;
        }

        public void RecordSong(Song song)
        {
            if (song == null)
                throw new ArgumentNullException(nameof(song), "Cannot record a null song.");

            if (!RecordedSongs.Contains(song))
            {
                RecordedSongs.Add(song);
            }
        }

        public override string ToString()
        {
            return $"Studio: '{StudioName}' located in {City} | Tracks Recorded: {RecordedSongs.Count}";
        }
    }
}
