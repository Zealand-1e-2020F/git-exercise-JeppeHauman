namespace GitExercise
{
    class myClass
    {
        public string navn { get; set; }

        public string adresse { get; set; }

        public int postnr { get; set; }

        public myClass(string navn, string adresse)
        {
            this.navn = navn;
            this.adresse = adresse;
        }

        public override string ToString()
        {
            return $"Navn: {navn}, Adresse: {adresse}, postnr.: {postnr}";
        }
    }
}