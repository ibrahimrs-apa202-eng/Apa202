using _06_InterfaceAbstraction;


public class calculation : ICalculation
{
    public double Calculate(double a, double b, string operation)
    {
        switch (operation)
        {
            case "+":
                return a + b;

            case "-":
                return a - b;

            case "*":
                return a * b;

            case "/":
                if (b == 0)
                {
                    throw new DivideByZeroException("xeta");
                }
                return a / b;

            default:
                throw new InvalidOperationException("dzzzzz");
        }
    }
}
