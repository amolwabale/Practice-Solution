using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSstack
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Stack is a linear data structure ordered in Last in first out or first in last out.
            //2. Its basic operation is Push, Pop, Peek.

            Stack st = new Stack();
            st.Push("John");
            st.Push("Doe");
            st.Push(40);
            st.Push(41);
            st.Push(41);
            var popData = st.Pop(); //Removes and returns the object at top of stack
            var peekData = st.Peek(); //Returns the object at top of stack without removing.
        }
    }
}
