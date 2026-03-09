// See https://aka.ms/new-console-template for more information
class SwitchStatement
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number (as integer):");
        int num = Convert.ToInt32(Console.ReadLine());

        switch (num)
        {
            case 1: Console.WriteLine("ONE"); break;
            case 2: Console.WriteLine("TWO"); break;
            case 3: Console.WriteLine("THREE"); break;
            case 4: Console.WriteLine("FOUR"); break;
            case 5: Console.WriteLine("FIVE"); break;
            case 6: Console.WriteLine("SIX"); break;
            case 7: Console.WriteLine("SEVEN"); break;
            case 8: Console.WriteLine("EIGHT"); break;
            case 9: Console.WriteLine("NINE"); break;
            default: Console.WriteLine("Error: enter number 1-9"); break;
        }

        Console.ReadLine();
    }
}
