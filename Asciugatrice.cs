// See https://aka.ms/new-console-template for more information

class Asciugatrice : Macchina
{
    public Asciugatrice(string nome)
    {
        
        Tipo = "asciugatrice";
        programmi = new List<Programma>();
        Nome = nome;
        GettoniGuadagnati = 0;
        Stato = false;
    }
}
