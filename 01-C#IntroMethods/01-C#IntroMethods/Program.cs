class Program
{
    static void Main()
    {
        Console.WriteLine(Topla(5, 1));
        Console.WriteLine(Cix(5, 5));
        Console.WriteLine(Vur(5, 7));
        Console.WriteLine(Bol(6, 3));
    }

    static int Topla(int a, int b)
    {
        return a + b;
    }

    static int Cix(int a, int b)
    {
        return a - b;
    }

    static int Vur(int a, int b)
    {
        return a * b;
    }

    static double Bol(int a, int b)
    {
        return (double)a / b;
    }
}

