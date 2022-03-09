/*
 * Andre Richard
 * Cst-150
 * 2/27/2022
 * MileStone 2
 * This my own work.
 */
using System;
using System.Windows.Forms;

namespace Cst_150MileStone1ClassHack
{
    public partial class AddNewAssignment : Form
    {
        //Define properties
        public string[] assignmentList { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        /// <summary>
        /// initialization class
        /// </summary>
        public AddNewAssignment()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btn for user to go back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btnAddClickEvent(object sender, EventArgs e)
        {
            //instantiates an object of the class then display it, while
            //hiding the main class from the user
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
            
            //set the variable to our classes properties
            Color += txtBoxColor.Text;
            Name += txtBoxName.Text;
            Description += txtBoxDescription;
            Date += txtBoxDate.Text;
            Time += txtBoxTime.Text;
            Format(assignmentList, Color, Name, Description, Date, Time);

        }

        //assigns the inputs of the user to variables in this class and formats it to the array
        public void Format(string[] list, string color, string name, string description, string date, string time) 
        {      
            list[0] += color;
            list[1] += name;
            list[2] += description;
            list[3] += date;
            list[4] += time;   
        }
        //class object to transder the list array of the new assignment for the user to view
       // ViewAssignmentsMenu view = new ViewAssignmentsMenu(assignmentList, this);

    }
}
