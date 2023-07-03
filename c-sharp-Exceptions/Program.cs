internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(divide(4,2));
        Console.WriteLine(divide(4, 4));
       Console.WriteLine(divide(4, 0));

        loop();
    }

    private static float divide(int a, int b)
    {
        try 
        {
            return a / b;
        }
        

        catch(DivideByZeroException e)
        { 
            return 0;
        }
    }

    private static void loop()
    {
        int[] a = { 1, 2, 3 };
        try
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(a[i]); 

            }
        }

        catch (IndexOutOfRangeException z)
        {
            Console.WriteLine(z);
        }
    }


}