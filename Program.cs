// See https://aka.ms/new-console-template for more information


// passo 1) inizio dallo sviluppare le classi coinvolte - lavanderia- lavatrici- asciugatrici.

// passo 2) creazione delle lavatrici dalla classe genitore

// passo 3) creazione interazioni con utente e spostare a fondo pagina le classi create


Lavanderia lavanderia = new Lavanderia();

Console.WriteLine("digita cosa vuoi fare");

Console.WriteLine(" 1 vedi stato lavatrici " );
Console.WriteLine(" 2 vedi stato asciugatrici");
Console.WriteLine(" 3 vedi stato di tutti i macchinari");
Console.WriteLine(" 4 vedi tutti i lavaggi ");


void menu() {
    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            Console.WriteLine("stato lavatrici");
            lavanderia.MostraLavatrici();
            Console.WriteLine("vuoi maggiorni dettali ? si o no?");
            if (Console.ReadLine == "si" || Console.ReadLine == "s"|| Console.ReadLine == "y"||Console.ReadLine == "yes")
            {
                extraMenu()
            }
            break;
        case 2:
            Console.WriteLine("stato asciugatrici");
            lavanderia.MostraAsciugatrici();
            break;
        case 3:
            Console.WriteLine("stato macchinari");
            lavanderia.MostraAsciugatrici();
            lavanderia.MostraLavatrici();
            break;
        case 4:
            Console.WriteLine("lavaggi eseguiti da tutte le macchine");
            lavanderia.Mostralavaggi();
            break;

        default:
            menu();
            break;
    }
}



menu();







class Lavanderia
{
    protected int GettoniUsati { get; set; }
    private float gettoniValore;
    protected int DetersivoConsumato { get; set; }
    protected int AmmorbidenteConsumato { get; set; }

    public Lavatrice[] lavatrici {get; private set;}
    public Asciugatrice[] asciugatrici { get; private set; }


    public Lavanderia()
    {
        lavatrici = new Lavatrice[5];
        asciugatrici = new Asciugatrice[5];
        this.gettoniValore = 0.50f;
        // da aggiungere la creazine delle istanze per le lavatrici e le asciugatrici

        for (int i = 0; i < lavatrici.Length ; i++)
        {
            string nome = "L" + Convert.ToString(i + 1);
            this.lavatrici[i] = new Lavatrice(nome);
        }

        for (int i = 0; i < asciugatrici.Length; i++)
        {
            string nome = "A" + Convert.ToString(i +1);
            this.asciugatrici[i] = new Asciugatrice(nome);
        }
    }

    

    // metodi da aggiungere = vedere corrispettivo guadagnato- generare 24 ore di lavoro random - avere le info delle macchine
    public void MostraLavatrici()
    {
        for (int i = 0; i < lavatrici.Length; i++)
        {
            string stato = " utilizzabile";
            if(lavatrici[i].Stato)
            {
                stato = " in uso";
            }
            Console.WriteLine((i+1) + " - " + lavatrici[i].Nome + stato + " lavvagio in corso " + lavatrici[i].AttualeLavaggio);
        }
    }

    public void MostraAsciugatrici()
    {
        for (int i = 0; i < lavatrici.Length; i++)
        {
            string stato = " utilizzabile";
            if (asciugatrici[i].Stato)
            {
                stato = " in uso";
            }
            Console.WriteLine((i + 1) + " - " + asciugatrici[i].Nome + stato);
        }
    }

    public void Mostralavaggi()
    {
        for (int i = 0; i < lavatrici.Length; i++)
        {
            for (int index = 0; index < lavatrici[i].lavaggio.Length; index++)
            {
                Console.WriteLine(lavatrici[i].lavaggio[index].Tipo);
            }
        }
    }
}

class Lavatrice
{
    public string Nome { get; set; }
    public int Detersivo { get; set; }
    public int Ammorbidente { get; set; } 
    public bool Stato { get; set; }

    public Lavaggio[] lavaggio;

    public string AttualeLavaggio {get; set; }

    public Lavatrice(string nome)
    {
        int Rand = new Random().Next( 1,5 ); 
        Nome = nome;
        Detersivo = 1000;
        Ammorbidente = 500;
        if( Rand % 2 == 1)
        {
            this.Stato = true;
            int selezionato = new Random().Next(1, 3);
            Lavaggio attuale = new Lavaggio(selezionato);
            this.AttualeLavaggio = attuale.Tipo;
            Detersivo -= attuale.DetersivoImpiegato;
        }
        else
        {
            this.Stato = false;
        }
        int arRand = new Random().Next(1, 10);

        lavaggio = new Lavaggio[arRand];
        for (int i = 0; i < lavaggio.Length; i++)
        {
            int selezionato = new Random().Next( 1, 3 );
            this.lavaggio[i] = new Lavaggio(selezionato);
            Detersivo -= lavaggio[i].DetersivoImpiegato;
        }
    }

}


class Lavaggio
{
    public string Tipo { get; set; }
    public int CostoGettoni { get; set; }
    public int Tempo { get; set; }
    public int DetersivoImpiegato { get; set; }
    public int AmmorbidenteImpiegato { get; set; }

    public Lavaggio(int selezionato)
    {
        switch (selezionato)
        {
            case 1:
                Tipo = "rinfrescante";
                CostoGettoni = 2;
                Tempo = 20;
                DetersivoImpiegato = 20;
                AmmorbidenteImpiegato = 5;
                break;
            case 2:
                Tipo = "rinnovante";
                CostoGettoni = 3;
                Tempo = 40;
                DetersivoImpiegato = 40;
                AmmorbidenteImpiegato = 10;
                break;
            case 3:
                Tipo = "rinfrescante";
                CostoGettoni = 4;
                Tempo = 60;
                DetersivoImpiegato = 60;
                AmmorbidenteImpiegato = 15;
                break;

        }
    }
}

class Asciugatura
{
    public int CostoGettoni { get; set; }
    public int Tempo { get; set; }
}
class Asciugatrice
{
    public string Nome { get; set; }

    public bool Stato { get; set; }

    public Asciugatrice(string nome)
    {
        int Rand = new Random().Next(1, 5);
        this.Nome = nome;
        if (Rand % 2 == 1)
        {
            this.Stato = true;
        }
        else
        {
            this.Stato = false;
        }

    }

  

}