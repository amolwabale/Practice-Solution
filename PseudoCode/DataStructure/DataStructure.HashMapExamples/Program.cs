using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.HashMapExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ticket = new Dictionary<string, string>()
            {
                { "Chennai", "Banglore" },
                { "Mumbai", "Delhi" },
                { "Goa", "Chennai" },
                { "Delhi", "Goa" }
            };

            Dictionary<string, string> reverseTicket = new Dictionary<string, string>();
            foreach (var item in ticket.Keys)
            {
                reverseTicket.Add(ticket[item], item);
            }

            var start = "";
            var to = "";

            foreach (var item in ticket.Keys)
            {
                if (!reverseTicket.ContainsKey(item)) {
                    start = item;
                    to = ticket[item];
                    start += " => " + to;
                    break;
                }
            }

            foreach (var item in ticket.Keys)
            {
                if (ticket.ContainsKey(to))
                {
                    to = ticket[to];
                    start += " => "+ to;
                }
            }
            Console.WriteLine(start);

        }
    }
}
