using System;
using System.Text;
using System.Linq;

class DecryptTheMessages
{
    static void Main()
    {
        string startMesg = Console.ReadLine().ToLower();
        string message = Console.ReadLine();

        string encryptedMsg = "";
        int countMsg = 0;

        if (startMesg == "start")
        {
            while (message != "end" && message != "END")
            {
                countMsg++;
                for (int i = 0; i < message.Length; i++)
                {
                    if ((message[i] >= 65 && message[i] <= 77) || (message[i] >= 97 && message[i] <= 109))
                    {
                        encryptedMsg += (char) (message[i] + 13);
                    }
                    else if ((message[i] > 77 && message[i] <= 90) || (message[i] > 109 && message[i] <= 122))
                    {
                        encryptedMsg += (char)(message[i] - 13);
                    }
                    else if (message[i] == '+')
                    {
                        encryptedMsg += ' ';
                    }
                    else if (message[i] == '%')
                    {
                        encryptedMsg += ',';
                    }
                    else if (message[i] == '&')
                    {
                        encryptedMsg += '.';
                    }
                    else if (message[i] == '#')
                    {
                        encryptedMsg += '?';
                    }
                    else if (message[i] == '$')
                    {
                        encryptedMsg += '!';
                    }
                    else
                    {
                        encryptedMsg += message[i];
                    }
                }
                message = Console.ReadLine();
            }

            if (countMsg > 0)
            {
                char[] array = encryptedMsg.ToCharArray();
                Array.Reverse(array);

                Console.WriteLine("Total number of messages: {0}", countMsg);
                Console.WriteLine(string.Join("", array));
            }
            else
            {
                Console.WriteLine("No message received.");
            }
            
        }
    }
}

