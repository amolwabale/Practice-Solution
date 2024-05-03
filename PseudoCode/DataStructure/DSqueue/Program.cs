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

        class CustomQueue
        {
            static int[] arr;
            static int size;
            static int front;
            static int rear;
            public CustomQueue(int n)
            {
                arr = new int[n];
                size = n;
                rear = 0;
                front = 0;
            }

            public void Add(int num)
            {
                if (size == 0 || rear == size)
                    return;

                arr[rear] = num;
                rear++;
            }

            public int Remove()
            {
                if (size == 0 || rear == front)
                    return -1;
                var num = 0;
                num = arr[front];
                arr[front] = 0;
                front++;
                return num;
            }

            public int Peek()
            {
                if (size == 0 || rear == front)
                    return -1;
                var num = 0;
                num = arr[front];
                return num;
            }

            }


        static void Main(string[] args)
        {
            //1. Queue is a linear datastructure which follows the order of first in first out(FIFO).
            //2. Main operations of queue are Enqueue, Dequeue, Front, Rear.
            //3. Data is inserted from Rear also called its Tail.
            //4. Data is removed from its Front also called its Head.


            //Traditional Method of Implementation
            Queue qu = new Queue();
            qu.Enqueue(10); // Adds an object to end of queue.
            qu.Enqueue(11);
            qu.Enqueue(11);
            qu.Enqueue("John");
            qu.Enqueue("Doe");
            var dequeueData = qu.Dequeue(); //Removes and returns the object at beginnng of queue.
            var peekData = qu.Peek(); //Returns the object at beginning of queue without removing it.


            //Queue using ARRAYS
            var cq = new CustomQueue(3);

            cq.Add(1);
            cq.Add(5);
            cq.Add(6);
            cq.Add(9);

            cq.Remove();
            cq.Remove();
            cq.Remove();
            cq.Remove();


            cq = new CustomQueue(1);

            cq.Add(1);
            cq.Add(5);

            cq.Remove();
            cq.Remove();

        }
    }
}
