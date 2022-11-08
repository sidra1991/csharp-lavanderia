// See https://aka.ms/new-console-template for more information

public abstract class Programma
{
    public string Tipo { get; set; }
    public string programma { get; set; }

    public string oraInizio { get; set; }
    public string oraFine { get; set; }
    public abstract void Attiva();

}
//////            case 3:
//////                Tipo = "rinfrescante";
//////                CostoGettoni = 4;
//////                Tempo = 60;
//////                DetersivoImpiegato = 60;
//////                AmmorbidenteImpiegato = 15;
//////                break;