using System;

class CurrencyCheck
{
    static void Main()
    {
        uint r = uint.Parse(Console.ReadLine());
        uint d = uint.Parse(Console.ReadLine());
        uint e = uint.Parse(Console.ReadLine());
        uint b = uint.Parse(Console.ReadLine());
        uint m = uint.Parse(Console.ReadLine());

        double rublesInLv = r * 3.5 / 100;
        double dollarInLv = d * 1.5;
        double euroinLv = e * 1.95;
        double siteBInLv = b / 2;
        double siteMInLv = (double)m;

        double minPrice = double.MaxValue;

        if (rublesInLv < minPrice)
        {
            minPrice = rublesInLv;
        }
        
        if (dollarInLv < minPrice)
        {
            minPrice = dollarInLv;
        }
        
        if (euroinLv < minPrice)
        {
            minPrice = euroinLv;
        }
        
        if (siteBInLv < minPrice)
        {
            minPrice = siteBInLv;
        }
        if (siteMInLv < minPrice)
        {
            minPrice = siteMInLv;
        }

        Console.WriteLine("{0:F2}", minPrice);
    }
}

