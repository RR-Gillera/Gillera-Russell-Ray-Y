using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            switch (txtInput.Text)
            {
                case "1":
                    lbl1.Text = "Maintain silence, proper decorum, and discipline inside the laboratory. Mobile phones, walkmans and other personal pieces of equipment must be switched off.";
                    break;
                case "2":
                    lbl1.Text = "Games are not allowed inside the lab. This includes computer-related games, card games and other games that may disturb the operation of the lab.";
                    break;
                case "3":
                    lbl1.Text = "Surding the Internet is allowed only with the permission of the instructor. Downloading and installing of software are strictly prohibited.";
                    break;
                case "4":
                    lbl1.Text = "Getting access to other websites not related to the course (especially pornographic and illicit sites) is strictly prohibited.";
                    break;
                case "5":
                    lbl1.Text = "Deleting computer files and changing the set-up of the computer is a major offense.";
                    break;
                case "6":
                    lbl1.Text = "Observe computer time usage carefully. A fifteen-minute allowance is given for each use. Otherwise, the unit will be given to those who wish to \"sit-in\".";
                    break;
                case "7":
                    lbl1.Text = "OBserve proper decorum while inside the laboratory. a. \tDo not get inside the lab unless the instructor is present. b. \tAll bags, knapsacks, and the likes must be deposited at the counter. " +
                        "c. \tFollow the seating arrangement of your instructor. d. \tAt the end of class, all software programs must be closed. e. \tReturn all chairs to their proper places after using.";
                    break;
                case "8":
                    lbl1.Text = "CHewing gum, eating, drinking, smoking, and other forms of vandalism are prohibited inside the lab.";
                    break;
                case "9":
                    lbl1.Text = "Anyone causing a continual distubance will be asked to leave the lab. Acts or gestures offensive to the members of the community, including public display of physical intimacy, are not tolerated.";
                    break;
                case "10":
                    lbl1.Text = "Persons exhibiting hostile or threatening behavior such as yelling, swearing, or disregarding requests made by lab personnel will be asked to leave the lab.";
                    break;
                case "11":
                    lbl1.Text = "For serous offense, the lab personnel may call the Civil Security Office (CSU) for assistance.";
                    break;
                case "12":
                    lbl1.Text = "Any technical problem or difficulty must be addressed to the laboratory supervisor, student assistant or instructor immediately.";
                    break;
                default:
                    lbl1.Text = "Enter a Rule Number from 1 - 12.";
                    break;

            }
        }
    }
}
