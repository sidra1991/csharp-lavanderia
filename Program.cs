// See https://aka.ms/new-console-template for more information


// passo 1) inizio dallo sviluppare le classi coinvolte - lavanderia- lavatrici- asciugatrici.

// passo 2) creazione delle lavatrici dalla classe genitore

// passo 3) creazione interazioni con utente e spostare a fondo pagina le classi create


Lavanderia lavanderia = new Lavanderia();

Console.WriteLine("digita cosa vuoi fare");

Console.WriteLine(" 1 usa una lavatrice ");

void menu() {
    switch ( Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            Console.WriteLine("1 scegli lavatrice");
            lavanderia.MostraLavatrici();
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

    private Lavatrice[] lavatrici;
    private Asciugatrice[] asciugatrici;


    public Lavanderia()
    {
        lavatrici = new Lavatrice[5];
        asciugatrici = new Asciugatrice[5];
        this.gettoniValore = 0.50f;
        // da aggiungere la creazine delle istanze per le lavatrici e le asciugatrici

        for (int i = 0; i < lavatrici.Length ; i++)
        {
            string nome = "L " + Convert.ToString(i);
            this.lavatrici[i] = new Lavatrice(nome);
        }

        for (int i = 0; i < asciugatrici.Length; i++)
        {
            string nome = "A " + Convert.ToString(i);
            this.asciugatrici[i] = new Asciugatrice(nome);
        }
    }

    public void UsoLavatrici(int gettoni, int detersivo , int ammorbidente)
    {
        this.GettoniUsati += gettoni;
        this.DetersivoConsumato += detersivo;
        this.AmmorbidenteConsumato += ammorbidente;

    }
    public void UsoAsciugatrici(int gettoni)
    {
        this.GettoniUsati += gettoni;
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
            Console.WriteLine("1 - " + lavatrici[i].Nome + stato);
        }
    }
}

class Lavatrice
{
    public string Nome { get; set; }

    public bool Stato { get; set; }

    public Lavatrice(string nome)
    {
        int Rand = new Random().Next( 1,5 ); 
        this.Nome = nome;
        if( Rand % 2 == 1)
        {
            this.Stato = true;
        }
        else
        {
            this.Stato = false;
        }

    }


    // metodi da aggiungere = inserire i 3 programmi di lavoro delle lavatrici
    //Rinfrescante, costo di 2 gettoni, durata di 20 minuti, consumo di 20ml di detersivo e 5ml di ammorbidente.
    void Rinfrescante(Lavanderia lavanderia)
    {
        // TODO aggiungere orario di fine usando i 20 minuti
        if (this.Stato == false) 
        { 
        this.Stato = !this.Stato;
        }
        else
        {
            Console.WriteLine("questa lavatrice è gia in uso");
        }
        int gettoni = 2;
        int detersivo = 20;
        int ammorbidente = 5;
        lavanderia.UsoLavatrici(gettoni , detersivo , ammorbidente);
        
    }


    //   Rinnovante, costo di 3 gettoni, durata di 40 minuti, consumo di 40ml di detersivo e 10ml di ammorbidente.
    void Rinnovante(Lavanderia lavanderia)
    {
        // TODO aggiungere orario di fine usando i 40 minuti
        if (this.Stato == false)
        {
            this.Stato = !this.Stato;
        }
        else
        {
            Console.WriteLine("questa lavatrice è gia in uso");
        }
        int gettoni = 3;
        int detersivo = 40;
        int ammorbidente = 10;
        lavanderia.UsoLavatrici(gettoni, detersivo, ammorbidente);

    }
    //Sgrassante, costo di 4 gettoni, durata di 60 minuti, consumo di 60 ml di detersivo e 15ml di ammorbidente.
    void Sgrassante(Lavanderia lavanderia)
    {
        // TODO aggiungere orario di fine usando i 60 minuti
        if (this.Stato == false)
        {
            this.Stato = !this.Stato;
        }else
        {
            Console.WriteLine("questa lavatrice è gia in uso");
        }
        int gettoni = 4;
        int detersivo = 60;
        int ammorbidente = 15;
        lavanderia.UsoLavatrici(gettoni, detersivo, ammorbidente);

    }
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

    // metodi da aggiungere = inserire i 3 programmi di lavoro delle lavatrici
    //, rapido 2 gettoni e intenso 4 gettoni della durata di 30 minuti e 60 minuti rispettivamente.

    void Rapido(Lavanderia lavanderia)
    {
        // TODO aggiungere orario di fine usando i 30 minuti
        if (this.Stato == false)
        {
            this.Stato = !this.Stato;
        }
        else
        {
            Console.WriteLine("questa lavatrice è gia in uso");
        }
        int gettoni = 2;
        lavanderia.UsoAsciugatrici(gettoni);

    }

}