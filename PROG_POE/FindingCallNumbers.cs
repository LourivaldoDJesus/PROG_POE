using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PROG_POE
{
    public partial class FindingCallNumbers : Form
    {
      
        int seconds = 0;
        int points = 0;
        Random random = new Random();

        // adding the text file in a list
        List<string> readFile = File.ReadAllLines("Dewey Decimal Numbers.txt").ToList();

        public FindingCallNumbers()
        {
            InitializeComponent();
            displayNumbers();

            //Initializing the Timer
            seconds = 0;
            CountdownTimer.Start();

            // adding the text file in a list and display the descriptions

            int Ilabel = random.Next(0, readFile.Count);
            
            label5.Text = readFile[Ilabel];

        }

        //---------------------------Exit Button---------------------------------------------------------------//
        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Code for Exit button
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 Menu = new Form1();
                Menu.Show();
                this.Hide();
            }

            else
            {
            }

        }

        //---------------------------Finding Call Numbers Form Load-------------------------------------------//
        private void FindingCallNumbers_Load(object sender, EventArgs e)
        {
            checkAsnwerpnl.AllowDrop = true;
            checkAsnwerpnl.DragEnter += controlsDragEnter;
            checkAsnwerpnl.DragDrop += controlsDragDrop;

            label1.MouseDown += controlsMouseDown;
            label2.MouseDown += controlsMouseDown;
            label3.MouseDown += controlsMouseDown;
            label4.MouseDown += controlsMouseDown;

            foreach (Control c in this.checkAsnwerpnl.Controls)
            {
                c.MouseDown += new MouseEventHandler(controlsMouseDown);
            }

        }

        //---------------------------Additional Methods----------------------------------------------------//
        //This code helps move the buttons and it is added in the Events tab in the checkAnswerPanel
        private void controlsDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void controlsDragDrop(object sender, DragEventArgs e)
        {
            Control c = e.Data.GetData(e.Data.GetFormats()[0]) as Control;

            if (c != null)
            {
                c.Location = this.checkAsnwerpnl.PointToClient(new Point(e.X, e.Y));
                this.checkAsnwerpnl.Controls.Add(c);
            }
        }

        private void controlsMouseDown(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;

            c.DoDragDrop(c, DragDropEffects.Move);
        }

        //------------------------------Display Numbers Method--------------------------------------------//
        private void displayNumbers()
        {
            List<string> DeweysDict = new List<string>();
            try
            {
                DeweysDict.Add("000 General Knowledge");
                DeweysDict.Add("100 Psychology and Philosophy");
                DeweysDict.Add("200 Religions and Mythology");
                DeweysDict.Add("300 Social Sciences and Folklore");
                DeweysDict.Add("400 Languages and Grammar");
                DeweysDict.Add("500 Math and Science");
                DeweysDict.Add("600 Medicine and Technology");
                DeweysDict.Add("700 Arts and Recreation");
                DeweysDict.Add("800 Literature");
                DeweysDict.Add("900 Geography and History");
            
                foreach (System.Windows.Forms.Label lbl in this.topLevelOptions.Controls)
                {

                    // Getting call numbers randomly from the list and display them in the labels
                    int labelindex = random.Next(0, DeweysDict.Count);
                    lbl.Text = DeweysDict[labelindex];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("{0} Exception caught:" + ex);
            }

        }

        //--------------------------------Verifying If Columns match--------------------------------------// 
        private void VerifyColumns()
        {
            
             points = 0;

            try
            {
            // To check if the answer is correct, The keys of both dictionaries will be compared.
            if (label1.Tag == label4.Tag)
            {
                generatingPoints();
                MessageBox.Show("Correct!");
                this.checkAsnwerpnl.Controls.Clear();
            }
            else
            {
                MessageBox.Show("Incorrect!");
                this.checkAsnwerpnl.Controls.Clear();
                if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Restart?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FindingCallNumbers FCNum = new FindingCallNumbers();
                    FCNum.Show();
                    this.Hide();
                }

                else
                {
                    Form1 Menu = new Form1();
                    Menu.Show();
                    this.Hide();
                }

            }

            }
            catch (Exception e)
            {
                MessageBox.Show("{0} Exception caught:" + e);
            }

        }
        
        //--------------------------------Points gamification--------------------------------------------//
        private void generatingPoints()
        {
            label15.Text = points++.ToString();
        }

        //----------------------------------Check Button------------------------------------------------//
        private void checkButton_Click(object sender, EventArgs e)
        {
            VerifyColumns();
        }

        //----------------------------------Timer Feature----------------------------------------------//
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = "Time Remaining: " + seconds++.ToString();
        }

    }
}
//-------------------------------------------End Of File------------------------------------------------//