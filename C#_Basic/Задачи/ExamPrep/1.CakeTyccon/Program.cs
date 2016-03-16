using System;

class Program
{
    static void Main()
    {
        ulong cakes = ulong.Parse(Console.ReadLine());
        double flourNeeded = double.Parse(Console.ReadLine());
        uint flourAviable = uint.Parse(Console.ReadLine());
        uint truffelsAviable = uint.Parse(Console.ReadLine());
        uint trufflePrice = uint.Parse(Console.ReadLine());

        ulong truffleCost = (ulong)truffelsAviable * trufflePrice;
        double caksesMaded = Math.Floor(flourAviable / flourNeeded);

        if (caksesMaded < cakes)
        {
            double totalFlour = (cakes * flourNeeded) - flourAviable;
            Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", caksesMaded, totalFlour);
        }
        else
        {
            double cakeCost = ((double)truffleCost / cakes) * 1.25d;
            Console.WriteLine("All products available, price of a cake: {0:F2}", cakeCost);
        }
    }
}

