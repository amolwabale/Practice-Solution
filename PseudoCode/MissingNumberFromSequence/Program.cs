using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberFromSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = { 1, 4, 3, 6, 7 , 5, 8, 9};
            var idealSum = ((seq.Length + 1)*(seq.Length + 2)) / 2;
            var actualSum = seq.Sum();
            var missingNum = idealSum - actualSum;
        }
    }
}
