using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZS.FindCircularLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = new Node(1, null);
            var node2 = new Node(2, node1);
            var node3 = new Node(3, node2);
            var node4 = new Node(4, node3);
            var node5 = new Node(5, node4);
            node1.SetLink(node5);

            var result = IsCircular(node1,node1);
        }

        public static bool IsCircular(Node node, Node FirstNode)
        {
            while (true)
            {
                if (node.Link == null)
                    return false;
                if (node.Link == FirstNode)
                    return true;
                node = node.Link;
            }
        }

        public class Node
        {
            public int Value;
            public Node Link;

            public Node(int value, Node node)
            {
                this.Value = value;
                this.Link = node;
            }

            public void SetLink(Node _node)
            {
                this.Link = _node;
            }

            public Node GetLink()
            {
                return this.Link;
            }
        }
    }
}
