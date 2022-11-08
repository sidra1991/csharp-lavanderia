// See https://aka.ms/new-console-template for more information

class Lavatrice : Macchina
{
    public Lavatrice(string nome)
    {
        programmi = new List<Programma>();
        Tipo = "lavatrice";
        Nome = nome;
        Detersivo = 1000;
        Ammorbidente = 500;
        GettoniGuadagnati = 0;
        Stato = false;
    }

}
