using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    class Program
    {
        public class TreeInfo
        {
            public int height { get; set; }
            public int diameter { get; set; }

            public TreeInfo(int ht, int dia)
            {
                this.height = ht;
                this.diameter = dia;
            }
        }
        public class Tree
        {
            public int data { get; set; }
            public Tree left;
            public Tree right;

            public Tree(int Data)
            {
                data = Data;
                this.left = null;
                this.right = null;
            }

            static int index = -1;
            public static Tree BuildTree(int[] arr)
            {
                index++;
                if (arr[index] == -1)
                    return null;
                var newNode = new Tree(arr[index]);
                newNode.left = BuildTree(arr);
                newNode.right = BuildTree(arr);
                return newNode;
            }

            public static int count = 0;
            public static int nodeSum = 0;
            //Complexity - O(n)
            public static void PreorderTraversal(Tree node)
            {
                if (node == null)
                {
                    Console.WriteLine(-1);
                    return;
                }
                count++;
                nodeSum += node.data;
                Console.WriteLine(node.data);
                PreorderTraversal(node.left);
                PreorderTraversal(node.right);
            }

            //Complexity - O(n)
            public static void InOrderTraversal(Tree node)
            {
                if (node == null)
                {
                    return;
                }


                InOrderTraversal(node.left);
                Console.WriteLine(node.data);
                InOrderTraversal(node.right);
            }

            //Complexity - O(n)
            public static void PostOrderTraversal(Tree node)
            {
                if (node == null)
                {
                    return;
                }

                PostOrderTraversal(node.left);

                PostOrderTraversal(node.right);

                Console.WriteLine(node.data);
            }

            //Complexity - O(n)
            public static void LevelOrderTraversal(Tree node)
            {
                var queue = new Queue<Tree>();
                queue.Enqueue(node);
                while (queue.Count != 0)
                {
                    var item = queue.Dequeue();
                    Console.WriteLine(item.data);
                    if (item.left != null)
                        queue.Enqueue(item.left);
                    if (item.right != null)
                        queue.Enqueue(item.right);
                }

            }

            public static int GetCountofNodes(Tree node)
            {
                if (node == null)
                {
                    return 0;
                }

                var leftHeight = GetCountofNodes(node.left);
                var rightHeight = GetCountofNodes(node.right);

                var myHeight = leftHeight+ rightHeight + 1;
                return myHeight;
            }

            public static int GetTreeHeight(Tree node)
            {
                if(node == null)
                {
                    return 0;
                }

                var leftHeight = GetTreeHeight(node.left);
                var rightHeight = GetTreeHeight(node.right);

                var myHeight = Math.Max(leftHeight, rightHeight) + 1;
                return myHeight;
            }

            public static int GetSumofNodes(Tree node)
            {
                if (node == null)
                {
                    return 0;
                }

                var left = GetSumofNodes(node.left);
                var right = GetSumofNodes(node.right);

                //var myHeight = Math.Max(leftHeight, rightHeight) + 1;
                var sum = left + right + node.data;
                return sum;
            }


            public static TreeInfo GetDiameter(Tree node)
            {
                if(node == null)
                {
                    return new TreeInfo(0, 0);
                }

                TreeInfo leftTree = GetDiameter(node.left);
                TreeInfo rightTree = GetDiameter(node.right);

                var myHeight = Math.Max(leftTree.height, rightTree.height) + 1;

                var diam1 = leftTree.diameter;
                var diam2 = rightTree.diameter;
                var diam3 = leftTree.height + rightTree.height + 1;

                var myDiam = Math.Max(Math.Max(diam1, diam2), diam3);

                var treeInfo = new TreeInfo(myHeight, myDiam);
                return treeInfo;
            }

            public static int level = 0;
            public static int GetSumofnthNodes(Tree node, int nthLevel, int currentLevel)
            {
                if (node == null)
                {
                    return 0;
                }
                if (nthLevel == currentLevel)
                    return node.data;
                currentLevel++;
                var left = GetSumofnthNodes(node.left, nthLevel, currentLevel);
                var right = GetSumofnthNodes(node.right, nthLevel, currentLevel);

                //var myHeight = Math.Max(leftHeight, rightHeight) + 1;
                var sum = left + right;
                return sum;
            }
        }


        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,4,-1,-1,5,-1,-1,3,-1,6,-1,-1 };
            var data = Tree.BuildTree(arr);
            Tree.PreorderTraversal(data);

            var sum = Tree.GetSumofNodes(data);
            var countOfNode = Tree.GetCountofNodes(data);
            var treeHeight = Tree.GetTreeHeight(data);

            var diam = Tree.GetDiameter(data);

            //TODO
            var nthLevelSum = Tree.GetSumofnthNodes(data, 1, 1);
            //Tree.InOrderTraversal(data);
            //Tree.PostOrderTraversal(data);
            //Tree.LevelOrderTraversal(data);

        }
    }
}
