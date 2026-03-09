// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        int n = 1;

        switch (n)
        {
            case 1:
                Console.WriteLine("A");
                break;

            case 2:
                Console.WriteLine("B");
                break;

            default:
                Console.WriteLine("C");
                break;
        }

        Console.ReadLine();
    }
}
