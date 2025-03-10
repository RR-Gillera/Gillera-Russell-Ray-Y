using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                "\n9 - \"Kinsa imong Papa?\"\n10 - \"Kinsa imong Mama?\"\n11 - \"Kanus a imong Bday?\"\n12 - \"Unsa imong Edad?\"\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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


            if (question.Equals("What is your ID num"))
            {

            }
        }

        private void answer_Click(object sender, EventArgs e)
        {

        }
    }
}
