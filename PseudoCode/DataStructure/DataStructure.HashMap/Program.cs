using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.HashMap
{
    class Program
    {
        public class HashMap<K , V>
        {
            public class Node
            {
                public K Key;
                public V Value;

                public Node next;
                public Node(K key, V value)
                {
                    this.Key = key;
                    this.Value = value;
                }
            }

            int n = 0; //Number of node
            int N = 4;
            LinkedList<Node>[] buckets;
            int constant = 2;

            public HashMap()
            {
                buckets = new LinkedList<Node>[N];
                for(var i = 0; i< buckets.Length; i++)
                {
                    buckets[i] = new LinkedList<Node>();
                }
            }

            private int GetBucketIndex(K key)
            {
                var bi = GetHash(key);
                return bi;  
            }

            private int SearchInLL(int bi, K key)
            {
                var ll = buckets[bi];

                for(var i = 0; i<= ll.Count && ll.Count > 0 ; i++)
                {
                    if (i < ll.Count)
                    {
                        var elem = ll.ElementAt(i);
                        if (elem.Key.Equals(key))
                        {
                            return i;
                        }
                    }
                }
                return -1;
            }

            private int GetHash(K key)
            {
                var hash = key.GetHashCode();
                var cnt = Math.Abs(hash % N);
                return cnt;
            }
            public void Add(K key, V value)
            {
                var bi = GetHash(key);
                var lli = SearchInLL(bi, key);

                if(lli == -1)
                {
                    var node = new Node(key, value);
                    buckets[bi].AddLast(node);
                    n++;
                }
                else
                {
                    var node = buckets[bi].ElementAt(lli);
                    node.Value = value;
                }
            }

            public void Remove(K key)
            {
                var bi = GetHash(key);
                var lli = SearchInLL(bi, key);

                if (lli == -1)
                {
                    return;
                }
                else
                {
                    var node = buckets[bi].ElementAt(lli);
                    buckets[bi].Remove(node);
                    n--;
                }
            }

        }
        static void Main(string[] args)
        {
            HashMap<string, int> hm = new HashMap<string, int>();
            hm.Add("India", 23);
            hm.Add("USA", 12);
            hm.Add("Belgium", 42);
            hm.Add("Colorado", 83);
            hm.Add("Canada", 90);

            hm.Add("India", 897);

            hm.Remove("Belgium");
        }
    }
}
