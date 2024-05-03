//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using System.Collections.Generic;

namespace DataStructure.Stack
{
    class Program
    {

        public static void PushToBottom(Stack<int> s, int n)
        {
            if(s.Count == 0)
            {
                s.Push(n);
                return;
            }
            var pop = s.Pop();
            PushToBottom(s, n);
            s.Push(pop);
        }

        public static void Reverse(Stack<int> s)
        {
            if (s.Count == 0)
            {
                return;
            }
            var pop = s.Pop();
            Reverse(s);
            PushToBottom(s, pop);
            
        }

        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);

            //Push to botom of stack
            //PushToBottom(s, 9);
            Reverse(s);
        }
    }
}
