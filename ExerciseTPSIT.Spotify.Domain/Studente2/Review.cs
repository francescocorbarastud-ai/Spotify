namespace ExerciseTPSIT.Spotify.Domain.Studente2
{
    public class Review
    {
        public int Rating { get; private set; }
        public string Comment { get; private set; }

        public Review(int rating, string comment)
        {
            Rating = Math.Clamp(rating, 1, 5);
            if (string.IsNullOrWhiteSpace(comment))
            {
                Comment = "Nessun commento fornito.";
            }
            else
            {
                Comment = comment;
            }
        }

        public override string ToString()
        {
            string stelle = new string('★', Rating).PadRight(5, '☆');

            return $"[{stelle}] {Comment}";
        }
    }
}
