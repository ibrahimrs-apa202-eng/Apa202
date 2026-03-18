

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3 };

        numbers = ArrayResize(numbers, 4, 5, 6, 7);

        foreach (var num in numbers)
        {
            Console.Write(num);
        }
    }

    static int[] ArrayResize(int[] numbers, params int[] newNumbers)
    {
        int oldLength = numbers.Length;
        int newLength = oldLength + newNumbers.Length;

        int[] result = new int[newLength];

        // köhnə elementləri kopyala
        for (int i = 0; i < oldLength; i++)
        {
            result[i] = numbers[i];
        }

        // yeni elementləri əlavə et
        for (int i = 0; i < newNumbers.Length; i++)
        {
            result[oldLength + i] = newNumbers[i];
        }

        return result;
    }
}
