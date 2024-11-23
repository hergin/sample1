namespace hello;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if(number%2==0) { // even
            Console.WriteLine(number + " is even!");
        } else {
            Console.WriteLine(number + " is odd!");
        }
    }
}
