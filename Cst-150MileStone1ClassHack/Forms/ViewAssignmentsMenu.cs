/*
 * Andre Richard
 * Cst-150
 * 2/27/2022
 * MileStone 2
 * This my own work.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cst_150MileStone1ClassHack
{
    public partial class ViewAssignmentsMenu : Form
    {
        //define properties
        public string[] AssignmentList { get; set;}

        /// <summary>
        /// Defualt Constructor
        /// </summary>
        public ViewAssignmentsMenu()
        {
            
        }

        /// <summary>
        /// constructor parameterized
        /// </summary>
        /// <param name="assignmentList"></param>
        public ViewAssignmentsMenu(string[] assignmentList, AddNewAssignment addNewAssignment)
        {
            InitializeComponent();
            AssignmentList = assignmentList;
        }

        /// <summary>
        /// on load method for this class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewAssignmentMenu_Load(object sender, EventArgs e)
        {
            DisplayExample(AssignmentList);
        }

        /// <summary>
        /// method that add the array to a label as an example for this milestone
        /// </summary>
        /// <param name="example"></param>
        public void DisplayExample(string [] example) 
        {
            for (int i = 0; i <= example.Length; i++) 
            {
                lblExample.Text += example[i];
            }
            
        }

        /// <summary>
        /// btn click event for going back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackClickEvent(object sender, EventArgs e)
        {
            //instantiates an object of the class then display it, while
            //hiding the main class from the user
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
