
    internal class Manat
{
    public decimal AZN { get; set; }
    public Manat(decimal azn)
    {
        AZN = azn;

    }
    public static implicit operator Manat(Dollar dollar)
    {
        return new Manat(dollar.USD * 1.7m);
    }

}


