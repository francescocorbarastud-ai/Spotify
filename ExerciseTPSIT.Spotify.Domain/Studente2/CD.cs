using ExerciseTPSIT.Spotify.Domain.Studente1;
using System.Text;

namespace ExerciseTPSIT.Spotify.Domain.Studente2
{
    public class CD
    {
        private string title;
        private string author;
        private List<Song> song_list;

        public CD(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.song_list = new List<Song>();
        }

        public string GetTitle() { return title; }
        public string GetAuthor() { return author; }

        public void SetTitle(string title) { this.title = title; }
        public void SetAuthor(string author) { this.author = author; }
        public void AddSong(Song s)
        {
            song_list.Add(s);
        }

        public override string ToString()
        {
            if (song_list.Count == 0) return "The CD is empty.";

            StringBuilder sb = new StringBuilder($"Titles in the CD '{title}':\n");
            foreach (Song s in song_list)
            {
                sb.AppendLine("- " + s.GetTitle());
            }
            return sb.ToString();
        }

        public int Duration()
        {
            int totalDuration = 0;
            foreach (Song s in song_list)
            {
                totalDuration += s.GetDuration();
            }
            return totalDuration;
        }
    }
}
