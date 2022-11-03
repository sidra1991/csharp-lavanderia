// See https://aka.ms/new-console-template for more information


// passo 1) inizio dallo sviluppare le classi coinvolte - lavanderia- lavatrici- asciugatrici.

class lavanderia
{
    protected int GettoniUsati { get; set; }
    private float gettoniValore;
    protected int DetersivoConsumato { get; set; }
    protected int AmmorbidenteConsumato { get; set; }

    private int[] lavatrici;

    private int[] asciugatrici;

    private lavanderia()
    {
        this.gettoniValore = 0.50f;
        this.lavatrici = new int[5];
        this.asciugatrici = new int[5];

        // da aggiungere la creazine delle istanze per le lavatrici e le asciugatrici
    }

    // metodi da aggiungere = vedere corrispettivo guadagnato- generare 24 ore di lavoro random - avere le info delle macchine

}

class lavatrice
{
    public string Nome { get; set; }

    public bool stato { get; set; }


    // metodi da aggiungere = inserire i 3 programmi di lavoro delle lavatrici
}

class asciugatrice
{
    public string Nome { get; set; }

    public bool stato { get; set; }


    // metodi da aggiungere = inserire i 3 programmi di lavoro delle lavatrici
}