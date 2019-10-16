using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    class TreeNode<T>
    {
        #region Properties
        // parent node
        public T NodeData { get; set; }
        
        // child nodes
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        #endregion

        #region Constructor
        public TreeNode(T nodeData)
        {
            this.NodeData = nodeData;
        }
        #endregion

        #region ToString Method (override)
        public override string ToString()
        {
            return this.NodeData.ToString();
        }
        #endregion
    }
}
