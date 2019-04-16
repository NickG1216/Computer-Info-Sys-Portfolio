//B7623
//Program 2
//October 22, 2017
//CIS 199-75
//This is an interactive gui application that informs the user of his or her class registration time. This program follows the 
//priority registration schedule for continuing, returning, and transfer students.  




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //This is the event handler for the OK button
        private void okButton_Click(object sender, EventArgs e)
        {
            char letter; //The variable for the first letter of the user's last name.
            string time; //The variable for registration time.
            string day; // The variable for the registration day.
            const string Time_One = "8:30"; //The first time slot.
            const string Time_Two = "10:00"; //The second time slot.
            const string Time_Three = "11:30"; //The third time slot.
            const string Time_Four = "2:00"; //The fourth tme slot.
            const string Time_Five = "4:00"; //The fifth time slot.
            const string Day_One = "Friday, November 3"; //The first day.
            const string Day_Two = "Monday, November 6"; //The second day.
            const string Day_Three = "Tuesday, November 7"; //The third day.
            const string Day_Four = "Wednesday, November 8"; //The fourth day.
            const string Day_Five = "Thursday, November 9"; //The fifth day.
            const string Day_Six = "Friday, November 10"; //The sixth and final day.
            letter = Convert.ToChar(lastNameTextBox.Text);
            letter = char.ToUpper(letter);
            if (juniorRButton.Checked || seniorRButton.Checked)
            {
                if (letter <= 'D')
                    time = Time_Two;
                else if (letter <= 'I')
                    time = Time_Three;
                else if (letter <= 'O')
                    time = Time_Four;
                else if (letter <= 'S')
                    time = Time_Five;
                else time = Time_One;
                if (juniorRButton.Checked)
                    day = Day_Two;
                else day = Day_One;
                MessageBox.Show($"Your registration date is on {day} at {time}.");
            }
            if ( freshmanRButton.Checked || sophomoreRButton.Checked)
            {
                if (letter <= 'B')
                    time = Time_Three;
                else if (letter <= 'D')
                    time = Time_Four;
                else if (letter <= 'F')
                    time = Time_Five;
                else if (letter <= 'I')
                    time = Time_One;
                else if (letter <= 'L')
                    time = Time_Two;
                else if (letter <= 'O')
                    time = Time_Three;
                else if (letter <= 'Q')
                    time = Time_Four;
                else if (letter <= 'S')
                    time = Time_Five;
                else if (letter <= 'V')
                    time = Time_One;
                else time = Time_Two;
                if (sophomoreRButton.Checked)
                    if (letter >= 'G' && letter <= 'S')
                        day = Day_Four;
                    else day = Day_Three;
                else if (letter >= 'G' && letter <= 'S')
                        day = Day_Six;
                    else day = Day_Five;
                    MessageBox.Show($"Your registration date is on {day} at {time}.");
                
            }
            



                       




            


        }
    }
}
