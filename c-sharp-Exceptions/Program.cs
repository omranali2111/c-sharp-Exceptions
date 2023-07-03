internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(divide(4,2));
        Console.WriteLine(divide(4, 4));
       Console.WriteLine(divide(4, 0));

        loop();


       
        Age();
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
    private static void Age() 
    {
        try
        {
          Console.WriteLine("enter your age");
            int b = int.Parse(Console.ReadLine());
            if(b<0)
            {
                throw new ArgumentException("number should be positive");
            }
            else
            Console.WriteLine(b);
        }

        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
           
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("error "+e.Message);
        }
      
    }

}