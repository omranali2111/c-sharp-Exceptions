internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(divide(4,2));
        Console.WriteLine(divide(4, 4));
       Console.WriteLine(divide(4, 0));//DivideByZeroException was unhandled error

        loop();
    }

    private static float divide(int a, int b)
    {
        return a / b;
    }

    private static void loop()
    {
        int[] a = { 1, 2, 3 };

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(a[i]); //Index was outside the bounds of the array.'

        }
    }


}