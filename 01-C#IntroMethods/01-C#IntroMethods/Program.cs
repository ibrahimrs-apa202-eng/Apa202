

class Program
{
    
    static void Calculate(double a, double b)
    {
        Console.WriteLine("Toplama: " + (a + b));
        Console.WriteLine("Çıxma: " + (a - b));
        Console.WriteLine("Vurma: " + (a * b));

        if (b != 0)
            Console.WriteLine("Bölme: " + (a / b));
        else
            Console.WriteLine("0-a bölmek olmaz!");
    }

    
    static void FindEvenOdd(int[] arr)
    {
        Console.WriteLine("Cüt ededler:");
        foreach (int num in arr)
        {
            if (num % 2 == 0)
                Console.Write(num + " ");
        }

        Console.WriteLine("Tek ededler:");
        foreach (int num in arr)
        {
            if (num % 2 != 0)
                Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static int SumDivisibleBy4And5(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            if (num % 4 == 0 && num % 5 == 0)
                sum += num;
        }
        return sum;
    }
    static int CountChar(string sentence, char ch)
    {
        int count = 0;
        foreach (char c in sentence)
        {
            if (c == ch)
                count++;
        }
        return count;
    }

    static void Main(string[] args)
    {
        
        Calculate(10, 5);

        
        int[] numbers = { 14, 20, 35, 40, 57, 60, 100 };
        FindEvenOdd(numbers);

        int sum = SumDivisibleBy4And5(numbers);
        Console.WriteLine( sum);

 
        string sentence = "ibo samandarov";
        char ch = 'a';
        int count = CountChar(sentence, ch);
        Console.WriteLine($"'{ch}' simvolunun sayı: " + count);
    }
}



