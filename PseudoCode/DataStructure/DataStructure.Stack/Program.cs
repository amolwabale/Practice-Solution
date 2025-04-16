//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using System.Collections;
using System.Collections.Generic;

namespace DataStructure.Stack
{
    class Program
    {

        //Problem Statement:
        //Given a string s consisting of only the characters '(', ')', '{', '}', '[', and ']', determine if the input string is valid.

        //A string is considered valid if:
        //Open brackets must be closed by the same type of brackets.
        //Open brackets must be closed in the correct order.
        //Every closing bracket must have a corresponding opening bracket before it.
        //Hack to remember - The Castle Gatekeeper Analogy 
        //To ensure everyone who enters (opens a door) also leaves (closes the same door) in the correct order.
        public static bool BalancedParanthesis(string str)
        {
            Stack<char> st = new Stack<char>();

            foreach (var item in str)
            {
                switch (item)
                {
                    case '{':
                    case '(':
                    case '[':
                        st.Push(item);
                        break;

                    case '}':
                        if (st.Count == 0 || st.Pop() != '{')
                            return false;
                        break;
                    case ')':
                        if (st.Count == 0 || st.Pop() != '(')
                            return false;
                        break;
                    case ']':
                        if (st.Count == 0 || st.Pop() != '[')
                            return false;
                        break;

                }

            }

            return true;
        }


        //ack to remember the logic - Walk backward with a stack. Pop all smaller, the top is your taller guy.
        public static int[] FindNextGreaterElements(int[] arr)
        {
            int n = arr.Length;
            int[] result = new int[n];
            Stack<int> st = new Stack<int>();

            for (int i = n - 1; i >= 0; i--)
            {
                // Pop elements that are less than or equal to current element
                while (st.Count > 0 && st.Peek() <= arr[i])
                {
                    st.Pop();
                }

                // If stack is not empty, top is the next greater element
                result[i] = (st.Count == 0) ? -1 : st.Peek();

                // Push current element to stack
                st.Push(arr[i]);
            }

            return result;
        }

        public static void PushToBottom(Stack<int> s, int n)
        {
            if (s.Count == 0)
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
            var str1 = "[{([)}([])]";
            var isBalancedParanthesis = BalancedParanthesis(str1);

            var arr = new int[] { 4, 5, 2, 25 };
            var result = FindNextGreaterElements(arr);
        }
    }
}
