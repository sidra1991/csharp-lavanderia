// See https://aka.ms/new-console-template for more information


class Rinfrescante : Programma
{
    public int CostoGettoni { get; set; }
    public int Tempo { get; set; }
    public int DetersivoImpiegato { get; set; }

    public int AmmorbidenteImpiegato { get; set; }

    public Macchina lavatriceImpiegata;
    public Rinfrescante(Macchina macchina)
    {
        Tipo = "rinfrescante";
        CostoGettoni = 2;
        Tempo = 20;
        DetersivoImpiegato = 20;
        AmmorbidenteImpiegato = 5;
        lavatriceImpiegata = macchina;
        oraInizio = DateTime.Now.TimeOfDay.ToString();
        TimeSpan span = new TimeSpan(0, Tempo, 0);
        oraFine = oraInizio + span;
        macchina.programmi.Add(this);

        if ( !macchina.Stato)
        {
            if (macchina.Detersivo > DetersivoImpiegato && macchina.Ammorbidente > AmmorbidenteImpiegato )
            {
                Attiva();
            }
        }
    }
    public override void Attiva()
    {
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