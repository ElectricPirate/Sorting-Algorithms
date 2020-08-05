using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DataStructures
{
    /// <summary>
    /// Binary search tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Tree<T> where T : IComparable
    {
        /// <summary>
        /// Root of tree
        /// </summary>
        public Node<T> Root { get; private set; }

        /// <summary>
        /// Count of nodes in tree
        /// </summary>
        public int Count { get; private set; }

        public Tree() { }

        public Tree(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        /// <summary>
        /// Insert data in new node into the tree
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }

            Root.Add(data);
            Count++;
        }

        /// <summary>
        /// Prefix traverse
        /// </summary>
        /// <returns></returns>
        public List<T> Preorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Preorder(Root);
        }

        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                list.Add(node.Data);

                if (node.Left != null)
                {
                    list.AddRange(Preorder((node.Left)));
                }

                if (node.Right != null)
                {
                    list.AddRange((Preorder(node.Right)));
                }
            }

            return list;
        }

        /// <summary>
        /// Postfix traverse
        /// </summary>
        /// <returns></returns>
        public List<T> Postorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Postorder(Root);
        }

        private List<T> Postorder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Postorder((node.Left)));
                }

                if (node.Right != null)
                {
                    list.AddRange((Postorder(node.Right)));
                }

                list.Add(node.Data);
            }

            return list;
        }

        /// <summary>
        /// Infix traverse
        /// </summary>
        /// <returns></returns>
        public List<T> Inorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Inorder(Root);
        }

        private List<T> Inorder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder((node.Left)));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange((Inorder(node.Right)));
                }
            }

            return list;
        }
    }
}
