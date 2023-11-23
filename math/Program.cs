internal class Program
{
    private static void Main(string[] args)
    {
        string nameChild, symbol;
        int randNum1, randNum2, lineLength;
        
        Console.Clear();
        Console.WriteLine("Welcome to math program for kids !!!\n");
        Console.WriteLine("Please enter child name : ");
        nameChild = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Child name {nameChild}\n");
        Console.WriteLine("Please enter starting random number : ");
        randNum1 = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Child name {nameChild}\n");
        Console.WriteLine("Please enter ending random number : ");
        randNum2 = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Child name {nameChild}\n");
        Console.WriteLine($"Chosen numbers are {randNum1} and {randNum2} \n");
        Console.WriteLine("Please enter mathematical symbol : ");
        symbol = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Child name {nameChild}\n");
        Console.WriteLine($"Chosen numbers are {randNum1} and {randNum2} \n");
        Console.WriteLine($"Math symbol {symbol}\n");
        Console.WriteLine("Please number for math exercises : ");
        lineLength = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Child name {nameChild}\n");
        Console.WriteLine($"Chosen numbers are {randNum1} and {randNum2} \n");
        Console.WriteLine($"Math symbol {symbol}\n");
        Console.WriteLine($"Math exercises {lineLength}\n");
        Console.WriteLine("\n\tExecuted...\n");
        Console.WriteLine(nameChild);

        for (int i = 0; i < lineLength; i++)
        {
            Random random = new Random();
            int num1 = random.Next(randNum1, randNum2);
            int num2 = random.Next(randNum1, randNum2);
            int num3 = random.Next(randNum1, randNum2);
            int num4 = random.Next(randNum1, randNum2);
            Console.WriteLine($"{num1} {symbol} {num2} = \t\t\t {num3} {symbol} {num4} = ");
        }
        
    }
}