internal class Program
{
    static void Main(string[] args)
    {
        #region Upcasting-Downcasting
        Dog dog = new Dog { AvgLife = 23, Breed = "Xaski", Gender = "male", Name = "Hatiko" };
        Eagle eagle = new Eagle { AvgLife = 50, FlySpeed = 200, Gender = "female" };

        //Animal animal = dog;
        //Animal animal1= eagle;

        //Dog dog1=(Dog)animal;
        //Eagle eagle1=(Eagle)animal1;


        Animal[] animals = { eagle, dog };

        foreach (var animal in animals)
        {
            //Eagle eagle1 = (Eagle)animal;
            //Eagle eagle1 = Eagle as Animal

            //if (eagle1 != null)
            //{
            //    eagle1.Fly();
            //    // }
            //    if (animal is Eagle)
            //{
            //    Eagle eagle1 = (Eagle)animal;
            //    eagle1.Fly();
            //}
            //else
            {
                Dog dog1 = (Dog)animal;
            }
        }

        #endregion

        #region Boxing-Unboxing
        //    int a = 5;
        //    object b = a;
        //    int c=(int)b;
        //}
        //    Test test = new Test();
        //    ITest test1 = test;
        //    Test test2 = (Test)test1;

        //}
        //public struct Test() : ITest
        //{
        //    public int X { get; set; }
        //    public int Y { get; set; }
        //}
        //public interface ITest
        //{
        //    int Y { get; set; }
        //}
        #endregion

        //Dollar dollar = new(200);
        //Manat manat = new(170);

        //Dollar dollar1 = manat;
        //Console.WriteLine(dollar1.USD);
        //Manat manat1 = dollar;
        //Console.WriteLine(manat1.AZN);
    }
}
////}
//using System;
//using System.Threading;

//class Program
{
    static void Main()
    {
        // Konsol pəncərəsinin təmizlənməsi
        Console.Clear();

        string ball = "⚽";
        string goal = "|______|";

        // 1. Mərhələ: Topun qola getməsi
        for (int i = 0; i < 20; i++)
        {
            Console.Clear();
            Console.WriteLine("\n\n\n");
            Console.WriteLine(new string(' ', i) + ball + new string(' ', 20 - i) + goal);
            Thread.Sleep(50);
        }

        Console.Clear();
        Console.WriteLine("\n\n\n                     GOOOOOL!!!");
        Thread.Sleep(1000);

        // 2. Mərhələ: Ronaldo "SIUUU" Animasiyası
        string[] ronaldoFrames = {
            "   O  \n  /|\\ \n  / \\ ",   // Qaçış
            "  \\O/ \n   |  \n  / \\ ",   // Atılış
            "  __O__ \n    |  \n   / \\ ",  // Havada süzülmə
            "   [S]  \n   /|\\ \n   / \\ "   // Məşhur SIUUU duruşu!
        };

        foreach (var frame in ronaldoFrames)
        {
            Console.Clear();
            Console.WriteLine("\n\n" + frame);
            if (frame.Contains("[S]"))
            {
                Console.WriteLine("\n   SIUUUUUUUUUU!!!");
            }
            Thread.Sleep(500);
        }
    }
}
