// See https://aka.ms/new-console-template for more information
class DoCasting
{
    static void Main(string[] args)
    {
        int sum = 17;
        int count = 5;

        int intAverage = sum / count;
        Console.WriteLine("Integer Average: " + intAverage);

        double doubleAverage = sum / count;
        Console.WriteLine("Double Average without casting: " + doubleAverage);

        doubleAverage = (double)sum / count;
        Console.WriteLine("Double Average with casting: " + doubleAverage);

        Console.ReadLine();
    }
}
