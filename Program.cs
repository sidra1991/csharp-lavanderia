// See https://aka.ms/new-console-template for more information


// passo 1) inizio dallo sviluppare le classi coinvolte - lavanderia- lavatrici- asciugatrici.

// passo 2) creazione delle lavatrici dalla classe genitore

class Lavanderia
{
    protected int GettoniUsati { get; set; }
    private float gettoniValore;
    protected int DetersivoConsumato { get; set; }
    protected int AmmorbidenteConsumato { get; set; }

    private int[] lavatrici;

    private int[] asciugatrici;

    private Lavanderia()
    {
        this.gettoniValore = 0.50f;
        this.lavatrici = new int[5];
        this.asciugatrici = new int[5];

        // da aggiungere la creazine delle istanze per le lavatrici e le asciugatrici

        for (int i = 0; i < (this.lavatrici.Length -1) ; i++)
        {
            string nome = "L" + Convert.ToString(i - 1);
            Lavatrice lavatrice = new Lavatrice(nome);
        }

        for (int i = 0; i < (this.asciugatrici.Length - 1); i++)
        {
            string nome = "A" + Convert.ToString(i - 1);
            Asciugatrice asciugatrice = new Asciugatrice(nome);
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