using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class EncryptTheMessages
{
    static void Main()
    {
        string command = Console.ReadLine();

        while (command.ToLower() != "start")
        {
            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        int countMessages = 0;
        string encryptMessage = string.Empty;

        while (command.ToLower() != "end")
        {
            if (!string.IsNullOrWhiteSpace(command))
            {
                countMessages++;

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    if ((command[i] >= 'A' && command[i] <= 'M') || (command[i] >= 'a' && command[i] <= 'm'))
                    {
                        encryptMessage += (char)(command[i] + 13);
                    }
                    else if ((command[i] >= 'N' && command[i] <= 'Z') || (command[i] >= 'n' && command[i] <= 'z'))
                    {
                        encryptMessage += (char)(command[i] - 13);
                    }
                    else if (command[i] >= '0' && command[i] <= '9')
                    {
                        encryptMessage += command[i];
                    }
                    else
                    {
                        switch (command[i])
                        {
                            case ' ': encryptMessage += '+'; break;
                            case ',': encryptMessage += '%'; break;
                            case '.': encryptMessage += '&'; break;
                            case '?': encryptMessage += '#'; break;
                            case '!': encryptMessage += '$'; break;
                            default:
                                break;
                        }
                    }
                }
            }
            encryptMessage += '\n';

            command = Console.ReadLine();
        }

        if (countMessages == 0)
        {
            Console.WriteLine("No messages sent.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", countMessages);
            Console.Write(encryptMessage);
        }
    }
}

