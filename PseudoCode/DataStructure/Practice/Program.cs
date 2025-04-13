using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Flatten Array
            var values = new[]
            {
                new int[]{1,2 },
                new int[]{3,4 },
                new int[]{5,6 }
            };

            int[] arr = new int[values.Length * values[0].Length];
            var counter = 0;
            for(var i=0; i< values.Length; i++)
            {
                for(var k=0; k< values[i].Length; k++)
                {
                    arr[counter] = values[i][k];
                    counter++;
                }
            }
            //Time Complexity: O(m * n)
            //Space Complexity: O(m * n)

            //REVERSE WORD
            //Write a program to reverse each word in a given input string without using any built-in string reversal methods or library functions
            //The order of the words in the sentence must remain unchanged, but the characters in each word should be reversed individually.

            var sentence = "dotnet interview question";

            var wordArr = sentence.Split(new char[] { ' ' });

            StringBuilder sb = new StringBuilder("");

            for(var i =0; i< wordArr.Length; i++)
            {
                StringBuilder childSb = new StringBuilder("");
                var word = wordArr[i];
                for(var j = word.Length - 1; j>-1; j--)
                {
                    childSb.Append(word[j]);
                }
                sb.Append(childSb);
                if (i != (wordArr.Length - 1))
                {
                    sb.Append(" ");
                }
            }
            sentence = sb.ToString();
            //Time Complexity: O(n)
            //Space Complexity: O(n)


            int[] bstArr = new int[] { 5, 3, 4, 1, 0, 7, 4 };
            BstTree btr = null;
            for (var i = 0; i< bstArr.Length; i++)
            {
                btr = BstTree.BuidTree(btr, bstArr[i]);
            }

            var sum = BstTree.SumOfNodes(btr);

            var treeHeight = BstTree.GetTreeHeight(btr);

            var numberOfNodes = BstTree.GetNumberofNodes(btr);

            var isPresentInBst = BstTree.isPresentInBst(btr, 70);

            var somOfNthLevel = BstTree.GetSumOfNthLevel(btr, 3, 1);

            Console.WriteLine("PreorderTraversal");
            BstTree.PreorderTraversal(btr);

            Console.WriteLine("InorderTraversal");
            BstTree.InorderTraversal(btr);

            Console.WriteLine("PostorderTraversal");
            BstTree.PostorderTraversal(btr);
        }

        public class BstTree
        {
            public int data { get; set; }
            public BstTree left { get; set; }
            public BstTree right { get; set; }


            public static BstTree BuidTree(BstTree tree, int val)
            {
                if (tree == null)
                {
                    tree = new BstTree();
                    tree.data = val;
                    return tree;
                }
                if (val < tree.data)
                {
                    tree.left =  BuidTree(tree.left, val);
                }
                else
                {
                    tree.right = BuidTree(tree.right, val);
                }

                return tree;
            }

            public static int SumOfNodes(BstTree tree)
            {
                if(tree == null)
                {
                    return 0;
                }
                var left = SumOfNodes(tree.left);
                var right = SumOfNodes(tree.right);
                var sum = left + right + tree.data;
                return sum;
            }

            public static int GetTreeHeight(BstTree tree)
            {
                if(tree == null)
                {
                    return -1; //return 0 if you prefer counting number of nodes as your height.
                }

                var left = GetTreeHeight(tree.left);
                var right = GetTreeHeight(tree.right);
                var height = Math.Max(left, right) + 1;
                return height;
            }

            public static int GetNumberofNodes(BstTree bst)
            {
                if (bst == null)
                    return 0;

                var left = GetNumberofNodes(bst.left);
                var right = GetNumberofNodes(bst.right);
                var number = left + right + 1;
                return number;
            }

            public static bool isPresentInBst(BstTree bst, int val)
            {
                if (bst == null)
                    return false;
                if (bst.data == val)
                    return true;
                else if (val < bst.data)
                    return isPresentInBst(bst.left, val);
                else
                    return isPresentInBst(bst.right, val);
                return false;
            }

            public static int GetSumOfNthLevel(BstTree bst, int nthLevel, int currentLevel)
            {
                if (bst == null)
                    return 0;

                if(nthLevel == currentLevel)
                {
                    return bst.data;
                }
                ;
                var left = BstTree.GetSumOfNthLevel(bst.left, nthLevel, currentLevel+1);
                var right = BstTree.GetSumOfNthLevel(bst.right, nthLevel, currentLevel+1);
                var sum = left + right;
                return sum;
            }

            public static void PreorderTraversal(BstTree bst)
            {
                if (bst == null)
                    return;
                Console.WriteLine(bst.data);
                PreorderTraversal(bst.left);
                PreorderTraversal(bst.right);
            }

            public static void InorderTraversal(BstTree bst)
            {
                if (bst == null)
                    return;
                InorderTraversal(bst.left);
                Console.WriteLine(bst.data);
                InorderTraversal(bst.right);
            }

            public static void PostorderTraversal(BstTree bst)
            {
                if (bst == null)
                    return;

                PostorderTraversal(bst.left);
                PostorderTraversal(bst.right);
                Console.WriteLine(bst.data);
            }
        }

        
    }
}
