// See https://aka.ms/new-console-template for more information

class Macchina
{
    public string Nome { get; set; }
    public int GettoniGuadagnati { get; set; }
    public bool Stato { get; set; }

    public string Tipo { get; set; }
    public List<Programma> programmi { get; set; }

    public int Detersivo { get; set; }
    public int Ammorbidente { get; set; }
}
