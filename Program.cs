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
}