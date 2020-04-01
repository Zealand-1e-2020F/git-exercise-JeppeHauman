namespace GitExercise
{
    class myClass
    {
        public string navn { get; set; }

        public string adresse { get; set; }

        public int postnr { get; set; }

        public string by { get; set; }

        public myClass(string navn, string adresse, int postnr)
        {
            this.navn = navn;
            this.adresse = adresse;
            this.postnr = postnr;
            this.by = by;
        }

        public override string ToString()
        {
            return $"Navn: {navn}, Adresse: {adresse}, postnr.: {postnr}";
        }
    }
}