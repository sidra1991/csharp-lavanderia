// See https://aka.ms/new-console-template for more information


class Intenso : Programma
{
    public string Tipo { get; set; }
    public int CostoGettoni { get; set; }
    public int Tempo { get; set; }
    public int DetersivoImpiegato { get; set; }

    public int AmmorbidenteImpiegato { get; set; }

    public Macchina lavatriceImpiegata;
    public Intenso(Macchina macchina)
    {
        Tipo = "intenso";
        CostoGettoni = 4;
        Tempo = 60;
        DetersivoImpiegato = 60;
        AmmorbidenteImpiegato = 15;
        lavatriceImpiegata = macchina;

        if (macchina.Detersivo > DetersivoImpiegato && macchina.Ammorbidente > AmmorbidenteImpiegato)
        {
            Attiva();
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