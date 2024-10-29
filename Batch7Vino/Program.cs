namespace Batch7Vino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of y");
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else if (y > x)
            {
                Console.WriteLine("y is greater than x");
            }
            else
            {
                Console.WriteLine("x and y are equal");
            }
        }
    }
}
