using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int i = 10;

        // Named method.
        Parallel.For(0, i, DoWork);

        // Anonymous method
        Parallel.For(0, i, delegate (int j)
        {
            Console.WriteLine($"Anonymous method: {j}");
        });

        // Lambda expression.
        Parallel.For(0, i, j =>
        {
            Console.WriteLine($"Lambda expression: {j}");
        });

        Console.ReadLine();
    }

    static void DoWork(int j)
    {
        Console.WriteLine($"Named method: {j}");
    }
}
