using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Program
    {
        public static int[] GetArray(int[,] arr)
        {
            var totalLength = arr.Length;

            var topRow = 0;
            var lastRow = arr.GetLength(1)-1;
            var firstColumn = 0;
            var lastColumn = arr.GetLength(0)-1;

            var counter = 0;

            int[] newArray = new int[totalLength];
            while (topRow <= lastRow && firstColumn <= lastColumn)
            {
                for (var i = topRow; i <= lastColumn; i++)
                {
                    newArray[counter] = arr[topRow, i];
                    counter++;
                }
                topRow++;
                for (var i = topRow; i <= lastRow; i++)
                {
                    newArray[counter] = arr[i, lastColumn];
                    counter++;
                }
                lastColumn--;
                for (var i = lastColumn; i >= firstColumn; i--)
                {
                    newArray[counter] = arr[lastRow, i];
                    counter++;
                }
                lastRow--;
                for (var i = lastRow; i >= topRow; i--)
                {
                    newArray[counter] = arr[i,firstColumn];
                    counter++;
                }
                firstColumn++;
            }
            return newArray;
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[,] {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
                {13,14,15,16}
            };
            var data = GetArray(arr);
        }
    }
}
