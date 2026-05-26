namespace ExerciseTPSIT.Spotify.Domain.Studente2
{
    public enum CaseMaterial
    {
        StandardPlastic, 
        Cardboard,       
        Digipak,         
        Steelbook       
    }

    public class Case
    {
        public CaseMaterial Material { get; private set; }
        public bool HasLyricBooklet { get; private set; }

        public Case(CaseMaterial material, bool hasLyricBooklet)
        {
            Material = material;
            HasLyricBooklet = hasLyricBooklet;
        }

        public override string ToString()
        {
            string bookletStatus = HasLyricBooklet ? "con libretto testi" : "senza libretto";
            return $"Custodia formato {Material}, {bookletStatus}.";
        }
    }
}
