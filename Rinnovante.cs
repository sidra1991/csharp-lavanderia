// See https://aka.ms/new-console-template for more information


class Rinnovante : Programma
{
    public int CostoGettoni { get; set; }
    public double Tempo { get; set; }
    public int DetersivoImpiegato { get; set; }

    public int AmmorbidenteImpiegato { get; set; }

    public Macchina lavatriceImpiegata;
    public Rinnovante(Macchina macchina)
    {
        Tipo = "rinnovante";
        CostoGettoni = 3;
        Tempo = 40;
        DetersivoImpiegato = 40;
        AmmorbidenteImpiegato = 10;
        lavatriceImpiegata = macchina;
        oraInizio = DateTime.Now.TimeOfDay;
        //TimeSpan span = new TimeSpan(0, Tempo, 0);
        DateTime date = new DateTime();
        oraFine = DateTime.Now.AddMinutes(Tempo).TimeOfDay;





        macchina.programmi.Add(this);
        if (!macchina.Stato)
        {
            if (macchina.Detersivo > DetersivoImpiegato && macchina.Ammorbidente > AmmorbidenteImpiegato)
            {
                Attiva();
            }
        }
    }
    public override void Attiva()
    {
        lavatriceImpiegata.GettoniGuadagnati += CostoGettoni;
        lavatriceImpiegata.Stato = true;
        lavatriceImpiegata.Detersivo -= DetersivoImpiegato;
        lavatriceImpiegata.Ammorbidente -= AmmorbidenteImpiegato;
    }
}
//////            case 3:
//////                Tipo = "rinfrescante";
//////                CostoGettoni = 4;
//////                Tempo = 60;
//////                DetersivoImpiegato = 60;
//////                AmmorbidenteImpiegato = 15;
//////                break;