using System;
using System.Linq;
using System.Text;

class PetarsGame
{
    static void Main()
    {
        ulong startNum = ulong.Parse(Console.ReadLine());
        ulong endNum = ulong.Parse(Console.ReadLine());
        string replacementStr = Console.ReadLine();

        ulong sum = 0;
        string sumLength = string.Empty;
        StringBuilder result = new StringBuilder(25);

        for (ulong currentDigit = startNum; currentDigit < endNum; currentDigit++)
        {
            if (currentDigit % 5 == 0)
            {
                sum += currentDigit;
            }
            else
            {
                sum += (currentDigit % 5);
            }
        }

        sumLength = sum.ToString();

        if (sum % 2 == 0)
        {
            string firstDigit = sumLength[0].ToString();

            for (int i = 0; i < sumLength.Length; i++)
            {
                if (sumLength[i].ToString() == firstDigit)
                {
                    result.Append(replacementStr);
                }
                else
                {
                    result.Append(sumLength[i]);
                }
            }
        }
        else
        {
            string lastDigit = (sum % 10).ToString();
            for (int i = 0; i < sumLength.Length; i++)
            {
                if (sumLength[i].ToString() == lastDigit)
                {
                    result.Append(replacementStr);
                }
                else
                {
                    result.Append(sumLength[i]);
                }
            }
        }
        Console.WriteLine(result);
    }
}

