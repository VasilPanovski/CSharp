using System;

class LightTheTorches
{
    static void Main()
    {
        int rooms = int.Parse(Console.ReadLine());
        string roomsState = Console.ReadLine();

        char[] updatedRooms = new char[rooms];
        int diff = updatedRooms.Length - roomsState.Length;

        for (int i = 0; i < updatedRooms.Length; i++)
        {
            if (diff == 0)
            {
                updatedRooms[i] = roomsState[i];
            }
            else
            {
                updatedRooms[i] = roomsState[i % (diff - 1)];
            }
        }

        string currentCommand = Console.ReadLine();

        while (currentCommand != "END")
        {
            int priestPosition = rooms / 2;
            string[] currentMove = currentCommand.Split(' ');
            int moves = 0;
            int maxMoves = 0;
            string direction = string.Empty;

            direction = currentMove[0];
            maxMoves = updatedRooms.Length - priestPosition;

            if (direction == "RIGHT" && moves == 0)
            {
                priestPosition++;
                if (updatedRooms[priestPosition] == 'L')
                {
                    updatedRooms[priestPosition] = 'D';
                }
                else
                {
                    updatedRooms[priestPosition] = 'L';
                }
            }
            else if (direction == "LEFT" && moves == 0)
            {
                priestPosition--;
                if (updatedRooms[priestPosition] == 'L')
                {
                    updatedRooms[priestPosition] = 'D';
                }
                else
                {
                    updatedRooms[priestPosition] = 'L';
                }
            }
            else if (direction == "RIGHT" && moves > maxMoves)
            {
                if (updatedRooms[0] == 'L')
                {
                    updatedRooms[0] = 'D';
                }
                else
                {
                    updatedRooms[0] = 'L';
                }
            }
            else if (direction == "LEFT" && moves > maxMoves)
            {
                if (updatedRooms[updatedRooms.Length - 1] == 'L')
                {
                    updatedRooms[updatedRooms.Length - 1] = 'D';
                }
                else
                {
                    updatedRooms[updatedRooms.Length - 1] = 'L';
                }
            }
            else
            {
                if (direction == "RIGHT")
                {
                    priestPosition += moves;
                    if (updatedRooms[priestPosition] == 'L')
                    {
                        updatedRooms[priestPosition] = 'D';
                    }
                    else
                    {
                        updatedRooms[priestPosition] = 'L';
                    }
                }
                else
                {
                    priestPosition -= moves;
                    if (updatedRooms[priestPosition] == 'L')
                    {
                        updatedRooms[priestPosition] = 'D';
                    }
                    else
                    {
                        updatedRooms[priestPosition] = 'L';
                    }
                }
            }

            currentCommand = Console.ReadLine();
        }

        
        
        

        int darkRooms = 0;

        for (int i = 0; i < updatedRooms.Length; i++)
        {
            if (updatedRooms[i] == 'D')
            {
                darkRooms++;
            }
        }
        Console.WriteLine(darkRooms * 'D');
    }
}

