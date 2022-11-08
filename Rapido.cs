// See https://aka.ms/new-console-template for more information


class Rapido : Programma
{
    public string Tipo { get; set; }
    public int CostoGettoni { get; set; }
    public double Tempo { get; set; }

    public Macchina asciugatriceImpiegata;
    public Rapido(Macchina macchina)
    {
        Tipo = "rapido";
        CostoGettoni = 2;
        Tempo = 30;
        asciugatriceImpiegata = macchina;
        
        //TimeSpan span = new TimeSpan(0, Tempo, 0);
        DateTime date = new DateTime();
        oraInizio = DateTime.Now.TimeOfDay;
        oraFine =DateTime.Now.AddMinutes(Tempo).TimeOfDay;
        macchina.programmi.Add(this);

        if (!macchina.Stato)
        {
            Attiva();
        }
    }
    public override void Attiva()
    {
        asciugatriceImpiegata.Stato = true;
    }
}
