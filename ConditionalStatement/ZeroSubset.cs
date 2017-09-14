using System;
using System.Linq;

class ZeroSubset
{
    static void Main()
    {
        Console.Write("Insert five numbers separated by space: ");
        string input = Console.ReadLine();
        string[] stringNumbers = input.Split();
        int[] numbers = stringNumbers.Select(int.Parse).ToArray();

        bool isSubset = false;

        for (int i1 = 0; i1 < numbers.Length; i1++)
        {
            for (int i2 = i1 + 1; i2 < numbers.Length; i2++)
            {
                  if (numbers[i1] + numbers[i2] == 0)
                        {
                            Console.WriteLine("{0} + {1} = 0", numbers[i1], numbers[i2]);
                            isSubset = true;
                        }
                for (int i3 = i2 + 1; i3 < numbers.Length; i3++)
                {
                    if (numbers[i1] + numbers[i2] + numbers[i3] == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", numbers[i1], numbers[i2], numbers[i3]);
                        isSubset = true;
                    }
                    for (int i4 = i3 + 1; i4 < numbers.Length; i4++)
                    {
                        if (numbers[i1] + numbers[i2] + numbers[i3] + numbers[i4] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[i1], numbers[i2], numbers[i3], numbers[i4]);
                            isSubset = true;
                        }
                        for (int i5 = 4; i5 < numbers.Length; i5++)
                        {
                            if (numbers[i1] + numbers[i2] + numbers[i3] + numbers [i4] + numbers[i5] == 0)
                            {
                               Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[i1], numbers[i2], numbers[i3], numbers[i4], numbers[i5]);
                               isSubset = true;
                            }
                        }
                    }
                }
            }
        }
        if (isSubset == false)
        {
            Console.WriteLine("no zero subset");
        }
    }
}

