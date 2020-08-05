using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DataStructures
{
    /// <summary>
    /// Node of binary tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T> : IComparable where T: IComparable
    {
        public T Data { get; private set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }

        public Node(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Add data in new node into the tree
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }

        public int CompareTo(object? obj)
        {
            if (obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new Exception("Types not equals.");
            }
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
