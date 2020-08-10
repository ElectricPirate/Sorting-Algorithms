using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithm.DataStructures;

namespace Algorithm
{
    /// <summary>
    /// Binary search tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TreeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        /// <summary>
        /// Root of tree
        /// </summary>
        public Node<T> Root { get; private set; }

        /// <summary>
        /// Count of nodes in tree
        /// </summary>
        public int Count { get; private set; }

        public TreeSort() { }

        public TreeSort(IEnumerable<T> items)
        {
            var list = items.ToList();

            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                Items.Add(item);

                var node = new Node<T>(item, i);
                Add(node);
            }
        }

        /// <summary>
        /// Insert data in new node into the tree
        /// </summary>
        /// <param name="data"></param>
        public void Add(Node<T> node)
        {
            if (Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }

            Add(Root, node);
            Count++;
        }

        /// <summary>
        /// Add data in new node into the tree
        /// </summary>
        /// <param name="data"></param>
        public void Add(Node<T> node, Node<T> newNode)
        {
            if (Compare(node.Data, newNode.Data) == 1)
            {
                if (node.Left == null)
                {

                    node.Left = newNode;
                }
                else
                {

                    Add(node.Left, newNode);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = newNode;
                }
                else
                {
                    Add(node.Right, newNode);
                }
            }
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
        
        protected override void MakeSort()
        {
            var result = Inorder(Root);

            Items.AddRange(result.Select(i => i.Data));

            for (int i = 0; i < result.Count; i++)
            {
                Swop(i, result.Count + i);
            }

            Items.RemoveRange(result.Count, result.Count);
        }

        /// <summary>
        /// Infix traverse
        /// </summary>
        /// <returns></returns>
        private List<Node<T>> Inorder(Node<T> node)
        {
            var list = new List<Node<T>>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }

                list.Add(node);

                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
            }

            return list;
        }
    }
}
