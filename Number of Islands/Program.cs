using System;

namespace NumberOfIslands
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] matrix = new char[2][] {new char []{'0','0','1' },
                                              new char []{ '0', '0', '1' } };

            int rows = matrix.Length;
            int cols = matrix[0].Length;

            Console.WriteLine("Hello World!");
        }
    }
}
