internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What grade do you expect to get in ISM 4300?");
        try
        {
            decimal grade = decimal.Parse(Console.ReadLine());

            if (grade >= 90m)
            {
                Console.WriteLine("Your grade is an A");
                Console.ReadKey(true);
            }
            else if ((grade < 90m) && (grade >= 80m))
            {
                Console.WriteLine("Your grade is an B");
                Console.ReadKey(true);
            }
            else if ((grade < 80m) && (grade >= 70m))
            {
                Console.WriteLine("Your grade is an C");
                Console.ReadKey(true);
            }
            else if ((grade < 70m) && (grade >= 60m))
            {
                Console.WriteLine("Your grade is an D");
                Console.ReadKey(true);
            }
            else if(grade < 60m)
            {
                Console.WriteLine("Your grade is an F");
                Console.WriteLine("You Failed");
                Console.ReadKey(true);
            }
        }
        catch
        {
            Console.WriteLine("Please enter a number value");
            Console.ReadKey(true);

        }

    }
}