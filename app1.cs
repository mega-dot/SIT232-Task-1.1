// See https://aka.ms/new-console-template for more information



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number (as integer):");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 1)
            Console.WriteLine("ONE");
        else if (num == 2)
            Console.WriteLine("TWO");
        else if (num == 3)
            Console.WriteLine("THREE");
        else if (num == 4)
            Console.WriteLine("FOUR");
        else if (num == 5)
            Console.WriteLine("FIVE");
        else if (num == 6)
            Console.WriteLine("SIX");
        else if (num == 7)
            Console.WriteLine("SEVEN");
        else if (num == 8)
            Console.WriteLine("EIGHT");
        else if (num == 9)
            Console.WriteLine("NINE");
        else
            Console.WriteLine("Error: enter number 1-9");

        Console.ReadLine();
    }
}

