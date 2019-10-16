using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    class Tree<T>
    {
        #region Properties
        public TreeNode<T> Root { get; set; }
        public List<T> ListOfNodes = new List<T>();
        #endregion

        #region Constructors
        public Tree()
        { this.Root = null; }
        #endregion

        #region Insert Methods
        // Insert
        public void Insert(T data)
        {
            this.Root = Insert(data, this.Root);
        }

        // Inserting the data into a node
        protected TreeNode<T> Insert(T data, TreeNode<T> node)
        {
            // if the node is null insert the data
            if (node == null)
            {
                node = new TreeNode<T>(data);
            }
            // insert data into nodes Left node
            //else if ((data as IComparable).CompareTo(node.NodeData) < 0)
            else if ((data as IComparable).CompareTo(node.NodeData) < 0)
            {
                node.Left = Insert(data, node.Left);
            }
            // insert data into nodes Right node
            else if ((data as IComparable).CompareTo(node.NodeData) > 0)
            {
                node.Right = Insert(data, node.Right);
            }
            else
            {
                // this needs to be changed
                throw new Exception("Duplicate Item.");
            }

            // return the node
            return node;
        }
        #endregion

        #region Remove Methods
        public void Remove(T data)
        {
            this.Root = Remove(data, this.Root);
        }

        public void RemoveLeftMost()
        {
            this.Root = RemoveLeftMost(this.Root);
        }

        private TreeNode<T> Remove(T data, TreeNode<T> node)
        {
            if (node == null)
            {
                throw new Exception("Item not found");
            }
            else if ((data as IComparable).CompareTo(node.NodeData) < 0)
            {
                node.Left = Remove(data, node.Left);
            }
            else if ((data as IComparable).CompareTo(node.NodeData) > 0)
            {
                node.Right = Remove(data, node.Right);
            }
            else if (node.Left != null && node.Right != null)
            {
                node.NodeData = FindLeftMost(node.Right).NodeData;
                node.Right = RemoveLeftMost(node.Right);
            }
            else
            {
                node = (node.Left != null) ? node.Left : node.Right;
            }

            return node;
        }

        private TreeNode<T> RemoveLeftMost(TreeNode<T> node)
        {
            if(node == null)
            {
                throw new Exception("Item not found");
            }
            else if (node.Left != null)
            {
                node.Left = RemoveLeftMost(node.Left);
                return node;
            }
            else
            {
                return node.Right;
            }
        }
        #endregion

        #region ToString Method
        // Override ToString
        public override string ToString()
        {
            return this.Root.ToString();
        }
        #endregion

        #region Walk Methods
        // WalkTree
        public List<T> WalkTree()
        {
            ListOfNodes.Clear();
            return WalkTree(Root, ListOfNodes);
        }

        private List<T> WalkTree(TreeNode<T> node, List<T> list)
        {
            if (node != null)
            {
                WalkTree(node.Left, list);
                list.Add(node.NodeData);
                WalkTree(node.Right, list);
            }
            return list;
        }
        #endregion

        #region NodeDataAt Method
        private T NodeDataAt(TreeNode<T> t)
        {
            return t == null ? default(T) : t.NodeData;
        }
        #endregion

        #region Search Methods
        public T Search(T data)
        {
            return NodeDataAt(Search(data, this.Root));
        }

        private TreeNode<T> Search(T data, TreeNode<T> node)
        {
            while (data != null)
            {
                if ((data as IComparable).CompareTo(node.NodeData) < 0)
                {
                    node = node.Left;
                }
                else if ((data as IComparable).CompareTo(node.NodeData) > 0)
                {
                    node = node.Right;
                }
                else
                {
                    return node;
                }
            }

            return null;
        }
        #endregion

        #region Find Left Most Methods
        public T FindLeftMost()
        {
            return NodeDataAt(FindLeftMost(this.Root));
        }

        private TreeNode<T> FindLeftMost(TreeNode<T> node)
        {
            if (node != null)
            {
                while (node.Left != null)
                {
                    node = node.Left;
                }
            }

            return node;
        }
        #endregion

        #region Find Right Most Methods
        public T FindRightMost()
        {
            return NodeDataAt(FindRightMost(this.Root));
        }

        private TreeNode<T> FindRightMost(TreeNode<T> node)
        {
            if (node != null)
            {
                while (node.Right != null)
                {
                    node = node.Right;
                }
            }

            return node;
        }
        #endregion
    }
}
