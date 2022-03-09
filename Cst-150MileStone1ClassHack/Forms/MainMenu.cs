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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            //hides the about desciption
            lblAbout.Hide();
        }
        /// <summary>
        /// click event handler for about button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAboutClickEvent(object sender, EventArgs e)
        {
            lblAbout.Show();
            lblAbout.Hide();
        }
        /// <summary>
        /// This btn click event will take the user to a form where they can add a new assignment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewAssignmentClickEvent(object sender, EventArgs e)
        {
            //instantiates an object of the class then display it, while
            //hiding the main class from the user
            AddNewAssignment addNewAssignment = new AddNewAssignment();
            addNewAssignment.Show();
            this.Hide();
        }

        private void btnViewAssignmentsClickEvent(object sender, EventArgs e)
        {
            //instantiates an object of the class then display it, while
            //hiding the main class from the user
            ViewAssignmentsMenu viewAssignments = new ViewAssignmentsMenu();
            viewAssignments.Show();
            this.Hide();
        }
    }
}
