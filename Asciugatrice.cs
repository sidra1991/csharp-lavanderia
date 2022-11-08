// See https://aka.ms/new-console-template for more information


// passo 1) inizio dallo sviluppare le classi coinvolte - lavanderia- lavatrici- asciugatrici.

// passo 2) creazione delle lavatrici dalla classe genitore

// passo 3) creazione interazioni con utente e spostare a fondo pagina le classi create


//////Lavanderia lavanderia = new Lavanderia();

//////Console.WriteLine("digita cosa vuoi fare");

//////Console.WriteLine(" 1 vedi stato lavatrici " );
//////Console.WriteLine(" 2 vedi stato asciugatrici");
//////Console.WriteLine(" 3 vedi stato di tutti i macchinari");
//////Console.WriteLine(" 4 vedi tutti i lavaggi ");
//////Console.WriteLine(" 5 incassi ");
//////int selezioneMenu = Convert.ToInt32(Console.ReadLine());


//////void menu(int selezioneMenu) {

//////    switch (selezioneMenu)
//////    {
//////        case 1:
//////            Console.WriteLine("stato lavatrici");
//////            lavanderia.MostraLavatrici();
//////            Console.WriteLine("vuoi maggiorni dettali ? si o no?");
//////            if (Console.ReadLine() == "si" || Console.ReadLine() == "s"|| Console.ReadLine() == "y"||Console.ReadLine() == "yes")
//////            {
//////                int select = 1;
//////                extraMenu(select);
//////            }
//////            else
//////            {
//////                menu(selezioneMenu);
//////            }
//////            break;
//////        case 2:
//////            Console.WriteLine("stato asciugatrici");
//////            lavanderia.MostraAsciugatrici();
//////            Console.WriteLine("vuoi maggiorni dettali ? si o no?");
//////            if (Console.ReadLine() == "si" || Console.ReadLine() == "s" || Console.ReadLine() == "y" || Console.ReadLine() == "yes")
//////            {
//////                int select = 2;
//////                extraMenu(select);
//////            }
//////            break;
//////        case 3:
//////            Console.WriteLine("stato macchinari");
//////            lavanderia.MostraAsciugatrici();
//////            lavanderia.MostraLavatrici();
//////            Console.WriteLine("vuoi maggiorni dettali ? si o no?");
//////            if (Console.ReadLine() == "si" || Console.ReadLine() == "s" || Console.ReadLine() == "y" || Console.ReadLine() == "yes")
//////            {
//////                int select = 0;
//////                extraMenu(select);
//////            }
//////            break;
//////        case 4:
//////            Console.WriteLine("lavaggi eseguiti da tutte le macchine");
//////            lavanderia.Mostralavaggi();

//////            break;
//////        case 5:
//////            Console.WriteLine( "questi sono gli incassi attuali" );
//////            lavanderia.Incassi();
//////            break;

//////        default:
//////            menu(selezioneMenu);
//////            break;
//////    }
//////}

//////void extraMenu(int select){

//////    switch (select)
//////    { 
//////        case 0:
//////            Console.WriteLine("seleziona:");
//////            Console.WriteLine("1. se vuoi le specifiche di una lavatrice");
//////            Console.WriteLine("2. se vuoi le specifiche di una asciugatrice");
//////            select = Convert.ToInt32(Console.ReadLine());
//////            extraMenu(select);
//////            break;
//////        case 1:
//////            Console.WriteLine("seleziona quale lavatrice");
//////            lavanderia.MostraLavatrici();
//////            lavanderia.dettagliLavatrice();
//////            break;
//////        case 2:
//////            Console.WriteLine("seleziona quale lavatrice");
//////            lavanderia.MostraAsciugatrici();
//////            lavanderia.dettagliAsciugatrici();
//////            break;


//////    }
//////}

//////menu(selezioneMenu);







//////class Lavanderia
//////{
//////    protected int Gettoni { get; set; }
//////    protected int DetersivoConsumato { get; set; }
//////    protected int AmmorbidenteConsumato { get; set; }

//////    public Lavatrice[] lavatrici {get; private set;}
//////    public Asciugatrice[] asciugatrici { get; private set; }


//////    public Lavanderia()
//////    {
//////        lavatrici = new Lavatrice[5];
//////        asciugatrici = new Asciugatrice[5];
//////        // da aggiungere la creazine delle istanze per le lavatrici e le asciugatrici


//////        //TODO__ DA SPOSTARE FUORI
//////        for (int i = 0; i < lavatrici.Length ; i++)
//////        {
//////            string nome = "L" + Convert.ToString(i + 1);
//////            this.lavatrici[i] = new Lavatrice(nome);
//////            Gettoni += lavatrici[i].GettoniGuadagnati;
//////        }

//////        for (int i = 0; i < asciugatrici.Length; i++)
//////        {
//////            string nome = "A" + Convert.ToString(i +1);
//////            this.asciugatrici[i] = new Asciugatrice(nome);
//////            Gettoni += asciugatrici[i].GettoniGuadagnati;
//////        }
//////    }

//////    public void Incassi()
//////    {
//////        Console.WriteLine(" i gettoni guadagnati sono " + Gettoni);
//////        int valore = Gettoni / 2;
//////        Console.WriteLine();
//////        Console.WriteLine("il guadagno in euro è " + valore + "€");
//////    }


//////    // metodi da aggiungere = vedere corrispettivo guadagnato- generare 24 ore di lavoro random - avere le info delle macchine

//////    //TODO__ DA SPOSTARE FUORI
//////    public void MostraLavatrici()
//////    {
//////        for (int i = 0; i < lavatrici.Length; i++)
//////        {
//////            string stato = " utilizzabile";
//////            if(lavatrici[i].Stato)
//////            {
//////                stato = " in uso";
//////            }
//////            Console.WriteLine((i+1) + " - " + lavatrici[i].Nome + stato + " lavvagio in corso " + lavatrici[i].AttualeLavaggio);
//////        }
//////    }

//////    //TODO__ DA SPOSTARE FUORI
//////    public void dettagliLavatrice()
//////    {
//////        int outParse = 1;
//////        int Lava = Convert.ToInt32(int.TryParse(Console.ReadLine(),out outParse ));
//////        if( Lava >= 0|| Lava < lavatrici.Length)
//////        {  
//////            Lava -= 1;
//////        }
//////        else
//////        {
//////           Lava = 1;
//////        }
//////        string stato = " utilizzabile";
//////        if (lavatrici[Lava].Stato)
//////        {
//////            stato = " in uso";
//////            Console.WriteLine("lavaggio in esecuzione " + lavatrici[Lava].AttualeLavaggio);
//////        }
//////        Console.WriteLine("nome della macchina " + lavatrici[Lava].Nome);
//////        Console.WriteLine("stato della macchina " + stato);
//////        Console.WriteLine("stato dell' ammorbidente residuo " + lavatrici[Lava].Ammorbidente);
//////        Console.WriteLine("stato del detersivo residuo " + lavatrici[Lava].Detersivo);
//////        Console.WriteLine("lavaggi effettuati " + lavatrici[Lava].lavaggio.Length);
//////        Console.WriteLine("gettoni guadagnati " + lavatrici[Lava].GettoniGuadagnati);


//////    }

//////    //TODO__ DA SPOSTARE FUORI
//////    public void dettagliAsciugatrici()
//////    {
//////        int Lava = Convert.ToInt32(Console.ReadLine()) - 1;
//////        string stato = " utilizzabile";
//////        if (asciugatrici[Lava].Stato)
//////        {
//////            stato = " in uso";
//////            Console.WriteLine("asciugatura in esecuzione " + asciugatrici[Lava].Attivita);
//////        }
//////        Console.WriteLine("nome della macchina " + asciugatrici[Lava].Nome);
//////        Console.WriteLine("stato della macchina " + stato);
//////        Console.WriteLine("asciugature effettuate " + asciugatrici[Lava].asciugature.Length);

//////    }

//////    //TODO__ DA SPOSTARE FUORI
//////    public void MostraAsciugatrici()
//////    {
//////        for (int i = 0; i < lavatrici.Length; i++)
//////        {
//////            string stato = " utilizzabile";
//////            if (asciugatrici[i].Stato)
//////            {
//////                stato = " in uso";
//////            }
//////            Console.WriteLine((i + 1) + " - " + asciugatrici[i].Nome + stato);
//////        }
//////    }


//////    //TODO__ DA SPOSTARE FUORI
//////    public void Mostralavaggi()
//////    {
//////        for (int i = 0; i < lavatrici.Length; i++)
//////        {
//////            for (int index = 0; index < lavatrici[i].lavaggio.Length; index++)
//////            {
//////                Console.WriteLine(lavatrici[i].lavaggio[index].Tipo);
//////            }
//////        }
//////    }
//////}

//////class Lavatrice
//////{
//////    public string Nome { get; set; }
//////    public int Detersivo { get; set; }
//////    public int Ammorbidente { get; set; } 

//////    public int GettoniGuadagnati { get; set; }
//////    public bool Stato { get; set; }

//////    List <Lavaggio> lavaggio;

//////    public Lavaggio AttualeLavaggio {get; set; }

//////    public Lavatrice(string nome)
//////    {
//////        Nome = nome;
//////        Detersivo = 1000;
//////        Ammorbidente = 500;
//////        GettoniGuadagnati = 0;
//////        lavaggio = new List <Lavaggio>();
//////    }

//////}


//////public abstract class Lavaggio 
//////{
//////    public abstract void lava();
//////}

//////class Rinfrescante : Lavaggio
//////{
//////    public override void lava()
//////    {
//////        throw new NotImplementedException();
//////    }
//////}


//////class Lavaggio
//////{
//////    public string Tipo { get; set; }
//////    public int CostoGettoni { get; set; }
//////    public int Tempo { get; set; }
//////    public int DetersivoImpiegato { get; set; }
//////    public int AmmorbidenteImpiegato { get; set; }

//////    public Lavaggio(int selezionato)
//////    {
//////        switch (selezionato)
//////        {
//////            case 1:
//////                Tipo = "rinfrescante";
//////                CostoGettoni = 2;
//////                Tempo = 20;
//////                DetersivoImpiegato = 20;
//////                AmmorbidenteImpiegato = 5;
//////                break;
//////            case 2:
//////                Tipo = "rinnovante";
//////                CostoGettoni = 3;
//////                Tempo = 40;
//////                DetersivoImpiegato = 40;
//////                AmmorbidenteImpiegato = 10;
//////                break;
//////            case 3:
//////                Tipo = "rinfrescante";
//////                CostoGettoni = 4;
//////                Tempo = 60;
//////                DetersivoImpiegato = 60;
//////                AmmorbidenteImpiegato = 15;
//////                break;

//////        }
//////    }
//////}

//////class Asciugatura
//////{
//////    public string Tipo { get; set; }
//////    public int CostoGettoni { get; set; }
//////    public int Tempo { get; set; }

//////    public Asciugatura(int selezionato )
//////    {
//////        switch (selezionato)
//////        {
//////            case 1:
//////                Tipo = "rapido";
//////                CostoGettoni = 2;
//////                Tempo = 30;
//////                break;
//////            case 2:
//////                Tipo = "intensso";
//////                CostoGettoni = 4;
//////                Tempo = 60;
//////                break;
//////        }
//////    }
//////}
//////class Asciugatrice
//////{
//////    public string Nome { get; set; }

//////    public int GettoniGuadagnati {get; set; }

//////    public string Attivita {get; set; }
//////    public bool Stato { get; set; }

//////    public Asciugatura[] asciugature;

//////    public Asciugatrice(string nome)
//////    {
//////        int Rand = new Random().Next(1, 5);
//////        this.Nome = nome;
//////        if (Rand % 2 == 1)
//////        {
//////            this.Stato = true;
//////            int selezionato = new Random().Next(1, 3);
//////            Asciugatura attuale = new Asciugatura(selezionato);
//////            this.Attivita = attuale.Tipo;
//////            GettoniGuadagnati += attuale.CostoGettoni;
//////        }
//////        else
//////        {
//////            this.Stato = false;

//////        }
//////        int arRand = new Random().Next(1, 10);

//////        asciugature = new Asciugatura[arRand];
//////        for (int i = 0; i < asciugature.Length; i++)
//////        {
//////            int selezionato = new Random().Next(1, 3);
//////            this.asciugature[i] = new Asciugatura(selezionato);
//////            GettoniGuadagnati += asciugature[i].CostoGettoni;
//////        }
//////    }



//////}
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
