// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        int n = 1;

        switch (n)
        {
            case 1:
                Console.WriteLine("The number is 1");
                break;

            case 2:
                Console.WriteLine("The number is 2");
                break;

            default:
                Console.WriteLine("The number is not 1 or 2");
                break;
        }

        Console.ReadLine();
    }
}
