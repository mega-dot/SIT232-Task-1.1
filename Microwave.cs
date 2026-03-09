// See https://aka.ms/new-console-template for more information



class Microwave
{
    static void Main(string[] args)
    {

        int items = Convert.ToInt32(Console.ReadLine());
        double time = Convert.ToDouble(Console.ReadLine());

        if (items == 1)
            Console.WriteLine("Heat time: " + time);
        else if (items == 2)
            Console.WriteLine("Heat time: " + (time * 1.5));
        else if (items == 3)
            Console.WriteLine("Heat time: " + (time * 2));
        else
            Console.WriteLine("Heating more than 3 items is not recommended.");
        Console.ReadLine();

    }
}