// See https://aka.ms/new-console-template for more information

public class Score
{
    public static void Main(string[] args)
    {
        double score = 40;

        if (score > 40)
        {
            Console.WriteLine("You passed the exam!");
        }
        else
        {
            Console.WriteLine("You failed the exam!");
        }

        Console.ReadLine();
    }
}
