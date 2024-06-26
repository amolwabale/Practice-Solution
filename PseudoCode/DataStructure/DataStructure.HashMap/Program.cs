﻿using System;
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

            private void reHash()
            {
                N = N * 2;

                var newBucket = new LinkedList<Node>[N];

                for(var i = 0; i < newBucket.Count(); i++)
                {
                    newBucket[i] = new LinkedList<Node>();

                }

                for (var i = 0; i < buckets.Count(); i++)
                {
                    foreach(var item in buckets[i])
                    {
                        var bi = GetHash(item.Key);
                        newBucket[bi].AddLast(item);
                    }

                }
                buckets = newBucket;
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

                if ((n / N) > constant)
                    reHash();
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

        //NOTES:
        //HASHING: It is a technique of identifying an object within a group of similar object.
        //How to Hash: Take hash of your key and than find the modulus by total number of items.
        //E.g. Student in school has roll number which is unique and can help to get his entire details.
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
