using _06_InterfaceAbstraction;
using System;

class Program
{
    static void Main(string[] args)
    {
        ICalculation calculator = new calculation();

        Console.Write("Birinci ededi daxil edin: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci ededi daxil edin: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("emeliyyatı seçin (+, -, *, /): ");
        string op = Console.ReadLine();

        try
        {
            double result = calculator.Calculate(a, b, op);
            Console.WriteLine("Nəticə: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Xəta: " + ex.Message);
        }
    }
}
