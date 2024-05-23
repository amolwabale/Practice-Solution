using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Trie
{
    class Program
    {
        public class Node
        {
            public Node[] Children { get; set; }
            public bool EndOfNode { get; set; }

            public Node() {
                EndOfNode = false;
                Children = new Node[26];
                for (var i = 0; i< Children.Length; i++)
                {
                    Children[i] = null;
                }
            }
        }
    
        public static Node rootNode = new Node();

        public static void Insert(string word)
        {
            var node = rootNode;
            for (var i=0; i < word.Length; i++)
            {
                var ind = word.ToLower()[i] - 'a'; //get index of charaters in alphabet
                if(node.Children[ind] == null)
                {
                    node.Children[ind] = new Node();
                }
                if (i == (word.Length - 1))
                {
                    node.Children[ind].EndOfNode = true;
                }
                else
                {
                    node = node.Children[ind];
                }
            }
        }

        public static bool Search(string word)
        {
            var node = rootNode;

            for (var i = 0; i < word.Length; i++)
            {
                var ind = word.ToLower()[i] - 'a'; //get index of charaters in alphabet
                if (node.Children[ind] == null)
                    return false;
                if (i == (word.Length - 1) && node.Children[ind].EndOfNode == false)
                    return false;
                node = node.Children[ind];
            }
            return true;
        }

        public static bool StartsWith(string word)
        {
            var node = rootNode;

            for (var i = 0; i < word.Length; i++)
            {
                var ind = word.ToLower()[i] - 'a'; //get index of charaters in alphabet
                if (node.Children[ind] == null)
                    return false;
                node = node.Children[ind];
            }
            return true;
        }

        public static int CountUniqueSubString(Node node)
        {
            var count = 0;
            for (var i = 0; i < rootNode.Children.Length; i++)
            {
                if (node.Children[i] != null)
                    count += CountUniqueSubString(node.Children[i]);
            }
            return count + 1;
        }

        public static bool isWordBreakPresent(string word)
        {
            var from = 0;
            var to = 0;
            var result = "";
            while (from < word.Length)
            {
                to++;
                var subStr = word.Substring(from,to);
                var isPresent = Search(subStr);
                if (isPresent)
                {
                    from += to;
                    to = 0;
                    result += subStr;
                }

            }
            return word == result;
        }

        public static bool isWordBreakPresentRecursion(string word)
        {
            if(word.Length == 0)
            {
                return true;
            }

            for(var i = 1; i<= word.Length; i++)
            {
                var firstPart = word.Substring(0, i);
                var secondPart = word.Substring(i);
                if(Search(firstPart) && isWordBreakPresentRecursion(secondPart))
                {
                    return true;
                }
            }
            return false;
        }

        public static string result = "";
        public static void GetLongestWordWithAllPrefixes(Node node, StringBuilder sb)
        {
            if(rootNode == null)
            {
                return;
            }
            for(var i = 0; i < 26; i++)
            {
                if(node.Children[i] != null && node.Children[i].EndOfNode == true)
                {
                    var ch = (char)(i+'a');
                    sb.Append(ch);
                    if(sb.ToString().Length > result.Length) //here it is checked greater than because if it is equal it might be in desc lexicographically.
                    {
                        result = sb.ToString();
                    }
                    GetLongestWordWithAllPrefixes(node.Children[i], sb);
                    sb.Remove(sb.ToString().Length - 1, 1);
                }

            }
        }

        static void Main(string[] args)
        {
            string[] words = new string[] { "the", "there", "their","i","like","samsung","ace" };
            foreach (var item in words)
            {
                Insert(item);
            }

            //var isPresent = Search("the ");

            //WORD BREAK PROBLEM

            string str = "isamsungAce";
            var data = isWordBreakPresent(str);
            var data1 = isWordBreakPresentRecursion(str);

            //WORD STARTS WITH
            var data2 = StartsWith("samz");


            //Count Unique Sub String
            rootNode = new Node();
            string str1 = "ababa";
            for (var i = 0; i < str1.Length; i++) {
                var substr = str1.Substring(i);
                Insert(substr);
            }
            var count = CountUniqueSubString(rootNode);


            //Find Longest Word with all prefixes
            rootNode = new Node();
            string[] prefixWords = new string[] { "a", "banana","app","ap","apply", "appl" };
            foreach(var item in prefixWords)
            {
                Insert(item);
            }
            StringBuilder sb = new StringBuilder("");
            GetLongestWordWithAllPrefixes(rootNode, sb);
            Console.WriteLine(result);

        }
    }
}
