using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        public class Node
        {
            public Node(int _val)
            {
                Val = _val;
            }
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

        public static bool isLinkedListPalindrome(Node node)
        {
            if (node == null)
                return false;

            Stack<int> stk = new Stack<int>();
            Node temp = node;
            while (temp != null)
            {
                stk.Push(temp.Val);
                temp = temp.next;
            }

            while(node != null)
            {
                var pop = stk.Pop();

                if (pop != node.Val)
                    return false;
                else
                    node = node.next;
            }

            return true;
        }

        //time complexity - o(n) | space complexity - o(1)
        public static bool isLinkedListCircular(Node node)
        {

            var slow = node;
            var fast = node;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return true;
            }

            return false;
        }

        public static Node ConcatLinkList(Node head1, Node head2)
        {
            var n1 = head1;

            while(n1.next != null)
            {
                n1 = n1.next;
            }
            n1.next = head2;
            return head1;
        } 

        static void Main(string[] args)
        {
            int[] nodeValue = new int[] { 1, 2, 3,4,5,6,7};
            var linkedList = new Node(nodeValue[0]);
            var nextNode = linkedList;
            for (var i = 1; i<nodeValue.Length; i++)
            {
                nextNode.next = new Node(nodeValue[i]);
                nextNode = nextNode.next;
            }

            //var node = ReverseIterativeLL(linkedList);

            var node = ReverseRecursiveLL(linkedList);

            var isPalindrome = isLinkedListPalindrome(nextNode);


            nodeValue = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            linkedList = new Node(nodeValue[0]);
            nextNode = linkedList;
            for (var i = 1; i < nodeValue.Length; i++)
            {
                nextNode.next = new Node(nodeValue[i]);
                nextNode = nextNode.next;
            }
            nextNode.next = linkedList;

            isLinkedListCircular(linkedList);


            //CONCAT 2 LINKED LIST
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = new int[] { 8, 9, 10, 11, 12 };
            var h1 = new Node(arr1[0]);
            var h2 = new Node(arr2[0]);
            var ll1 = h1;
            var ll2 = h2;
            for(var i=1; i<arr1.Length; i++)
            {
                ll1.next = new Node(arr1[i]);
                ll1 = ll1.next;
            }

            for (var i = 1; i < arr2.Length; i++)
            {
                ll2.next = new Node(arr2[i]);
                ll2 = ll2.next;
            }

            var data = ConcatLinkList(h1, h2);

        }
    }
}
