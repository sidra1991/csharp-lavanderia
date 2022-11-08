// See https://aka.ms/new-console-template for more information

using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
Lavanderia lavanderia = new Lavanderia();

//creazione macchine
for (int i = 0; i < 5; i++)
{
    string nome = "L" + i;
    Lavatrice lavatrice = new Lavatrice(nome);
    lavanderia.macchine.Add(lavatrice);
}
for (int i = 0; i < 5; i++)
{
    string nome = "A" + i;
    Asciugatrice asciugatrice = new Asciugatrice(nome);
    lavanderia.macchine.Add(asciugatrice);
}

//modifica stato random
Random random = new Random();
for (int i = 0; i < lavanderia.macchine.Count; i++)
{
    int clar = random.Next(1, 10);
    Macchina macchina = lavanderia.macchine[i];
    if (lavanderia.macchine[i].Tipo == "lavatrice") { 
        clar = clar % 4;
        switch (clar)
        {
            case 0:
                Rinfrescante rinfrescante = new Rinfrescante(macchina);
                macchina.programmi.Add(rinfrescante);
                break;
            case 1:
                Rinnovante rinnovante = new Rinnovante(macchina);
                macchina.programmi.Add(rinnovante);
                break;
            case 2:
                Intenso intenso = new Intenso(macchina);
                macchina.programmi.Add(intenso);
                break;
            default:
                break;
        } 
    } 
    else if(lavanderia.macchine[i].Tipo == "asciugatrice")
    {
        clar = clar % 3;
        switch (clar)
        {
            case 0:

                Rapido rinnovante = new Rapido(macchina);
                macchina.programmi.Add(rinnovante);
                break;
            case 1:
                IntensoAsciugatrice intenso = new IntensoAsciugatrice(macchina);
                macchina.programmi.Add(intenso);
                break;
            default:
                break;
        }
    }
}

//funzioniutili
int testNumero()
{

    int libero;

    string tester = Console.ReadLine();
    int number;

    bool success = int.TryParse(tester, out number);
    if (success)
    {
        libero = Convert.ToInt32(tester);
    }
    else
    {
        Console.WriteLine("mi spiace non è un numero");
        libero = testNumero();
    }


    return libero;
}

//contolla le risposte affermative o negative del utente
bool siOno()
{
    string testo = Convert.ToString(Console.ReadLine());
    if (testo == "si" || testo == "yes" || testo == "y" || testo == "s")
    {
        return true;
    }
    else
    {
        return false;
    }

}


//generatore


void menu()
{
    Console.WriteLine("chi sta usando il programma");
    Console.WriteLine("1. un utente ");
    Console.WriteLine("2. il gestore");

    int scelta = testNumero();

    switch(scelta)
    {
        case 1:
            menuCliente();
            break;
        case 2:
            menuGestore();
            break;
    }


}


void menuCliente()
{
    Console.WriteLine("cosa devi fare? ");
    Console.WriteLine("1. guarda stato macchine ");
    Console.WriteLine("2. guarda dettaglio macchine ");

    int scelta = testNumero();

    switch (scelta)
    {
        case 1:
            statoMacchine();
            menuCliente();
            break;
        case 2:
            dettaioMacchine();
            break;
    }
}

void dettaioMacchine()
{
   Macchina macchina= ricercaMacchina();
    string status;
    if (macchina.Stato)
    {
        status = "in funzione";
    }else
    {
        status = "inattiva";
    }

    Console.WriteLine("nome "+ macchina.Nome);
    Console.WriteLine("tipo macchina " + macchina.Tipo);
    Console.WriteLine("stato -----" + status);
    Console.WriteLine("gettoni incassati " + macchina.GettoniGuadagnati);
    if (macchina.Stato) {
        Console.WriteLine("programma attivo " + macchina.programmi[macchina.programmi.Count - 1].programma);
        Console.WriteLine("ora inizio programma attivo " + macchina.programmi[macchina.programmi.Count - 1].oraInizio);
        Console.WriteLine("ora inizio programma attivo " + macchina.programmi[macchina.programmi.Count - 1].oraFine);
    }
    
}

Macchina ricercaMacchina()
{
    Console.WriteLine("digita nome della macchina che vuoi vedere");
    List<Macchina> trovate = new List<Macchina>();
    string nome = Console.ReadLine();

    for (int i = 0; i < lavanderia.macchine.Count;i++)
    {
        if (lavanderia.macchine[i].Nome == nome)
        {
            trovate.Add(lavanderia.macchine[i]);
        }
    }

    if (trovate.Count == 0)
    {
        Console.WriteLine("macchina non trovata riprova");
        return ricercaMacchina();
    }else if(trovate.Count > 1)
    {
        Console.WriteLine("scegli la macchina mediante");
        for (int i = 0; i < trovate.Count; i++)
        {
            Console.WriteLine( "1. " + trovate[i].Nome + " "+ trovate[i].Tipo);
        }
        int selezione = testNumero();

        if (selezione > trovate.Count)
        {
            selezione = 1;
        }

        return trovate[selezione - 1];
    }
    else { return trovate[0]; }

    
}

void menuGestore()
{
    Console.WriteLine("1. guarda stato macchine ");
    Console.WriteLine("2. guarda dettaglio macchine ");

    int scelta = testNumero();

    switch (scelta)
    {
        case 1:
            statoMacchine();
            menuGestore();
            break;
        case 2:
            dettaioMacchine();
            break;
    }
}

void statoMacchine()
{
    for (int i = 0; i < lavanderia.macchine.Count; i++)
    {
        TimeSpan ora = DateTime.Now.TimeOfDay;
        
        Console.WriteLine(TimeSpan.Compare(lavanderia.macchine[i].programmi[lavanderia.macchine[i].programmi.Count - 1].oraFine, ora));

        string stato;
        if (lavanderia.macchine[i].Stato)
        {
            stato = "in funzione";
        }
        else
        {
            stato = "inattiva";
        }
        Console.WriteLine("la macchina " + lavanderia.macchine[i].Tipo + " " + lavanderia.macchine[i].Nome);
        Console.WriteLine("la macchina è " + stato);
        Console.WriteLine("----------------------------------------------");

    }
}




menu();
