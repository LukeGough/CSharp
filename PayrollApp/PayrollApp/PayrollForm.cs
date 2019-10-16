using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollApp
{
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }

        // create the tree
        Tree<string> tree = new Tree<string>();

        #region Add Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(tbStaffName.Text)))
                {
                    // using tbStaffName text insert data into tree
                    tree.Insert(tbStaffName.Text);
                }
                else
                {
                    ssErrorMessage.Text = "Please enter a staff member.";
                }
            }
            catch (Exception)
            {
                ssErrorMessage.Text = "That staff member already exists.";
            }

            // call the Display method
            DisplayTree();
            
            // clear tbStaffName
            tbStaffName.Clear();
        }
        #endregion

        #region Remove Button
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // call the Remove method
                tree.Remove(tbStaffName.Text);
                ssErrorMessage.Text = "Staff member removed successfully.";
                DisplayTree();
            }
            catch (Exception)
            {
                ssErrorMessage.Text = "Staff member not found.";
            }
        }
        #endregion

        #region Search Button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ssErrorMessage.Text = ("Staff member \"" + tree.Search(tbStaffName.Text).ToString() + "\" found.");
                DisplayTree();
            }
            catch (Exception)
            {
                ssErrorMessage.Text = "Unable to find staff member.";
            }
        }
        #endregion

        #region Display Method
        private void DisplayTree()
        {
            // clear all items in lstStaffname
            lstStaffNames.Items.Clear();

            // call WalkTree method and for each node display the nodeData ToString
            foreach (object node in tree.WalkTree())
            {
                lstStaffNames.Items.Add(node.ToString());
            }
        }
        #endregion

        #region FindLeftMost Button
        private void btnFindLeftMost_Click(object sender, EventArgs e)
        {
            try
            {
                tbFindLeftMost.Text = tree.FindLeftMost().ToString();
            }
            catch (Exception)
            {
                ssErrorMessage.Text = "Unable to find the Left Most Node.";
            }
        }
        #endregion

        #region FindRightMost Button
        private void btnFindRightMost_Click(object sender, EventArgs e)
        {
            try
            {
                tbFindRightMost.Text = tree.FindRightMost().ToString();
            }
            catch (Exception)
            {
                ssErrorMessage.Text = "Unable to find the Right Most Node.";
            }
        }
        #endregion

        #region ToolTips
        private void PayrollForm_Load(object sender, EventArgs e)
        {
            ttToolTip.SetToolTip(btnAdd, "Enter the staff members name into the \"Staff Members Name\" box then click to add.");
            ttToolTip.SetToolTip(btnRemove, "Enter the staff members name into the \"Staff Members Name\" box then click to remove.");
            ttToolTip.SetToolTip(btnSearch, "Enter the staff members name into the \"Staff Members Name\" box then click to search.");
        }
        #endregion
    }
}
