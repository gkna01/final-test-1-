using System;
class Water{
    static void Main(string[] args){
        Console.Write("Vmax : ");
        float vmax = float.Parse(Console.ReadLine());
        Console.Write("Vfill : ");
        float vfill = float.Parse(Console.ReadLine());
        Console.Write("Vdrink : ");
        float vdrink = float.Parse(Console.ReadLine());
        Console.Write("tday : ");
        int tday = int.Parse(Console.ReadLine());
        Console.Write("tfill : ");
        int tfill = int.Parse(Console.ReadLine());
        Console.Write("tdrink : ");
        int tdrink = int.Parse(Console.ReadLine());        
            
        double v = 0;
        bool enoughWater = true;
        bool overflowWater = false;

        for (int i = 0; i < tday; i++)
        {
            if (i % (tdrink + tfill) < tdrink)
            {
                v += vdrink;

                if (v > vmax)
                {
                    overflowWater = true;
                    break;
                }
            }
            else
            {        
                v += vfill;

                if (v > vmax)
                {
                    overflowWater = true;
                    break;
                }
            }
        }

        if (overflowWater)
        {
            Console.WriteLine("Overflow Water");
        }
        else
        {
            if (v < vdrink * (tday / (tdrink + tfill)))
            {
                enoughWater = false;
            }

            if (enoughWater)
            {
                Console.WriteLine("Enough Water, {0} left", vmax - v);
            }
            else
            {
                Console.WriteLine("Not Enough Water");
            }
        }
    }
}

class treasurer
{
    static void Main()
    {
        Console.Write("B1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("B2: ");
        double b2 = double.Parse(Console.ReadLine());

        Console.Write("B3: ");
        double b3 = double.Parse(Console.ReadLine());

        double totalBalance = b1 + b2 + b3;
        double left = 0;

        Console.WriteLine();

        while (true)
        {
            Console.Write("payment (stop>>>press 0 or negative number): ");
            double payment = double.Parse(Console.ReadLine());

            if (payment <= 0)
                break;

            if (b1 >= payment)
            {
                b1 -= payment;
            }
            else if (b2 >= payment)
            {
                b2 -= payment;
            }
            else if (b3 >= payment)
            {
                b3 -= payment;
            }
            else
            {
                left += payment;
            }

            Console.WriteLine();
            Console.WriteLine("Balance:");
            Console.WriteLine("Balance 1: {0}", b1);
            Console.WriteLine("Balance 2: {0}", b2);
            Console.WriteLine("Balance 3: {0}", b3);
            Console.WriteLine("Left: {0}", left);
            Console.WriteLine();
        }
    }
}