// See https://aka.ms/new-console-template for more information

class IntensoAsciugatrice : Programma
{
    public int CostoGettoni { get; set; }
    public double Tempo { get; set; }

    public Macchina asciugatriceImpiegata;
    public IntensoAsciugatrice(Macchina macchina)
    {
        Tipo = "intenso";
        CostoGettoni = 3;
        Tempo = 30;
        asciugatriceImpiegata = macchina;
        oraInizio = DateTime.Now.TimeOfDay;
        //TimeSpan span = new TimeSpan(0, Tempo, 0);
        DateTime date = new DateTime();
        oraFine = DateTime.Now.AddMinutes(Tempo).TimeOfDay;
        macchina.programmi.Add(this);

        if (!macchina.Stato)
        {
            Attiva();
        }
    }
    public override void Attiva()
    {
        asciugatriceImpiegata.Stato = true;
        asciugatriceImpiegata.GettoniGuadagnati += CostoGettoni;
    }
}