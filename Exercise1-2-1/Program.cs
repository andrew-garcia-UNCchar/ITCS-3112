namespace Exercise1_2_1;

class Program
{
    static void Main(string[] args)
    {
        Accumulator myAccumulator = new(startingTotal: 10);
        
        Console.WriteLine("Accumulator's Total: {0}", myAccumulator.Total);
        
        myAccumulator.Add(amount:5);
        
        Console.WriteLine("Accumulator's Total: {0}", myAccumulator.Total);
    }
}