using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Queue is a linear datastructure which follows the order of first in first out.
            //2. Main operations of queue are Enqueue, Dequeue, Front, Rear.
            //3. Data is inserted from Rear also called its Tail.
            //4. Data is removed from its Front also called its Head.

            Queue qu = new Queue();
            qu.Enqueue(10); // Adds an object to end of queue.
            qu.Enqueue(11);
            qu.Enqueue(11);
            qu.Enqueue("John");
            qu.Enqueue("Doe");
            var dequeueData = qu.Dequeue(); //Removes and returns the object at beginnng of queue.
            var peekData = qu.Peek(); //Returns the object at beginning of queue without removing it.
        }
    }
}
