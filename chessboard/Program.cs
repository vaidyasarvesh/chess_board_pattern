using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessboard
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            int size = 10; // Size of the chessboard (8x8);
            int row;
            int col;

            for ( row = 0; row < size; row++)
            {
                for ( col = 0; col < size; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.Write("██"); // Black square
                    }
                    else
                    {
                        Console.Write("  "); // White square
                    }
                }

                Console.WriteLine(); // Move to the next line for the next row
            }

            Console.ReadLine(); // Wait for user input to close the console window
        }
    }
}
