using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static DSqueue.Program;

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

        class CustomQueueList<T>
        {
            
            private List<T> list = new List<T>();

            public void Enque(T item)
            {
                list.Add(item);
            }

            public T DeQueue() { 
            
                if(list.Count == 0)
                {
                    throw new Exception("Queues is empty");
                }
                var item = list[0];
                list.RemoveAt(0);
                return item;
            }

        }

        public class ArrayQueue<T>
        {
            int capacity = 0;
            int front = 0;
            int rear = -1;
            T[] arr;
            int count = 0;
            public ArrayQueue(int _capacity)
            {
                capacity = _capacity;
                arr = new T[_capacity];

            }

            public void Enqueue(T item)
            {
                if (count == capacity)
                    throw new Exception("Queue full");

                rear = (rear + 1) % capacity;
                arr[rear] = item;
                count++;

            }

            public T Dequeue()
            {
                if (count == 0)
                    throw new Exception("Queue blank");

                T item = arr[front];
                front = (front + 1) % capacity;
                count--;
                return item;
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


            cq = new CustomQueue(5);

            cq.Add(1);
            cq.Add(5);

            cq.Remove();
            cq.Remove();

            var newQueue = new CustomQueueList<int>();

            newQueue.Enque(12);
            newQueue.Enque(13);
            newQueue.Enque(14);

            newQueue.DeQueue();
            newQueue.DeQueue();

            var arrQueue = new ArrayQueue<int>(6);
            arrQueue.Enqueue(12);
            arrQueue.Enqueue(13);
            arrQueue.Enqueue(14);

            var data = arrQueue.Dequeue();
            data = arrQueue.Dequeue();


        }
    }
}
