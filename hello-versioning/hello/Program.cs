namespace hello;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The number you have entered it: "+number);
    }
}
