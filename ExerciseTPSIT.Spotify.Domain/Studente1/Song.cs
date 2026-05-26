namespace ExerciseTPSIT.Spotify.Domain.Studente1
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }

        public Song(string title, string artist, int duration)
        {
            this.Title = title;
            this.Artist = artist;
            this.Duration = duration;
        }

        public string GetTitle() { return Title; }
        public string GetArtist() { return Artist; }
        public int GetDuration() { return Duration; }

        public void SetTitle(string title) { this.Title = title; }
        public void SetArtist(string artist) { this.Artist = artist; }
        public void SetDuration(int duration) { this.Duration = duration; }

        public override string ToString()
        {
            return $"Song: '{Title}' by {Artist} ({Duration} seconds)";
        }

        public bool ShortSong(int maxDuration)
        {
            return Duration < maxDuration;
        }
    }
}
