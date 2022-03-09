/*
 * Andre Richard
 * Cst-150
 * 2/27/2022
 * MileStone 2
 * This my own work.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst_150MileStone1ClassHack.Classes
{
    
    internal class Assignment
    {
        //Define properties
        public string Color { get; set; }
        public string Name { get; set; }
        public  string Description { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        /// <summary>
        /// Defualt Constructor
        /// </summary>
        Assignment() 
        {
            //Initialization of properties
            Color = "";
            Name = "";
            Description = "";
            Date = "";
            Time = "";
        }

        /// <summary>
        /// Parameterized Constructor that all other sub-classes/child classes will be using
        /// </summary>
        /// <param name="color"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        
        public Assignment(string color, string name, string description, string date, string time) 
        {
            //Where we initialize the class prop and parameters
            Color=color;
            Name=name;
            Description=description;
            Date=date;
            Time=time;
        }
    }

}
