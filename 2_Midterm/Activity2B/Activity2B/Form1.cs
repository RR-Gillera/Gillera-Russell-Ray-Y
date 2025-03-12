using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Activity2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.Text = "        *Questions to ask*\n\n" +
                "1 - \"Unsa imong ID Number?\" \n2 - \"Unsa imong Course?\"\n3 - \"Unsa ka Year?\"\n4  - \"Unsa imong Name?\"" +
                "\n5 - \"Unsa imong Middle Name?\"\n6 - \"Unsa imong Last Name?\"\n7 - \"Unsa imong Email Address?\"\n8 - \"Taga asa man ka?\"" +
                "\n9 - \"Kinsa imong Papa?\"\n10 - \"Kinsa imong Mama?\"\n11 - \"Kanus a imong Bday?\"\n12 - \"Unsa imong Edad?\"\n13 - Unsa imong Phone Number?" +
                "\n14 - Unsa ang Phone Number sa imong Ginikanan?\n15 - Unsa imong Skills and Interests?";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void answer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String idNum = "23747125";
            String course = "Bachelor of Science in Information Technology";
            String yrLvl = "2nd Year";
            String fName = "Russell Ray";
            String mName = "Yap";
            String lName = "Gillera";
            String email = "russellgillera19@gmail.com";
            String address = "Banawa, Guadalupe, Cebu";
            String fatherName = "Ryan E. Gillera";
            String motherName = "Carmel Y. Gillera";
            String bDay = "January 19, 2005";
            String age = "20";
            String pNum = "09943720514";
            String parentInfo = "09096388671";
            String skills = "Coding, Playing Volley, Playing Video Games, etc...";

            string questions = question.Text.Trim();

            switch (questions)
            {
            case "1":
            answer.Text = "ID Number: " + idNum;
                break;
            case "2":
                answer.Text = "Course: " + course;
                break;
            case "3":
                answer.Text = "Year Level: " + yrLvl;
                break;
            case "4":
                answer.Text = "First Name: " + fName;
                break;
            case "5":
                answer.Text = "Middle Name: " + mName;
                break;
            case "6":
                answer.Text = "Last Name: " + lName;
                break;
            case "7":
                answer.Text = "Email Address: " + email;
                break;
            case "8":
                answer.Text = "Address: " + address;
                break;
            case "9":
                answer.Text = "Father's Name: " + fatherName;
                break;
            case "10":
                answer.Text = "Mother's Name: " + motherName;
                break;
            case "11":
                answer.Text = "Birthday: " + bDay;
                break;
            case "12":
                answer.Text = "Age: " + age;
                break;
            case "13":
                answer.Text = "Phone Number: " + pNum;
                break;
            case "14":
                answer.Text = "Parent's Phone Number: " + parentInfo;
                break;
            case "15":
                answer.Text = "Skills and Interests: " + skills;
                break;
            default:
                answer.Text = "Invalid number.";
                break;

            }
        }

        private void Click(object sender, EventArgs e)
        {
            question.Text = "";
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
