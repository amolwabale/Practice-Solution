using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        public class Node
        {
            public int Val { get; set; }
            public Node next { get; set; }

        }


        public static Node ReverseIterativeLL(Node node)
        {
            Node curr = node;
            Node prev = null;
            Node next;

            while (curr != null)
            {
                next = curr.next;
                //Whejn updating such referenc evariable always decide teh priority 
                //of assigning such that right side value on top syntax is manipulated below.
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }


        public static Node ReverseRecursiveLL(Node node)
        {
            if(node == null || node.next == null){
                return node;
            }
            var newNode = ReverseRecursiveLL(node.next);
            node.next.next = node;
            node.next = null;
            return newNode;
        }

        static void Main(string[] args)
        {
            int[] nodeValue = new int[] { 1, 2, 3, 4, 5 };
            var linkedList = new Node();
            var nextNode = linkedList;
            for (var i = 0; i<nodeValue.Length; i++)
            {
                nextNode.Val = nodeValue[i];
                nextNode.next = new Node();
                nextNode = nextNode.next;
            }

            //var node = ReverseIterativeLL(linkedList);

            var node = ReverseRecursiveLL(linkedList);
        }
    }
}
