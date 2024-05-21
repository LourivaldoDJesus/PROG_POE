using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_POE
{
    public partial class ReplacingBooksForm : Form
    {
        // This is the Replacing Books form

        int seconds = 0;
        public ReplacingBooksForm()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------//
        // Exit Button
        private void btnExit_Click(object sender, EventArgs e)
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


        //-----------------------------------------------------------------------------//
        // Code to shuffle buttons
        int labelindex = 0;
        private void ShuffleButtons()
        {
            List<int> labellist = new List<int>();
            Random random = new Random();

            try
            {
            foreach (Button btn in this.ButtonsHolderPanel.Controls)
            {
                // Adding the call numbers to the buttons
                int numbers = 999;
                string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                string randomL = new string(Enumerable.Repeat(letters, 3).
                    Select(s => s[random.Next(letters.Length)]).ToArray());

                double numforcallnum = random.NextDouble() * numbers;

                String callNumber = numforcallnum.ToString("000.00") + " " + randomL;
                
                btn.Text = (labelindex == 1) ? "" : callNumber;
                labellist.Add(labelindex);
            }

            // Code to check if the order of the call numbers is correct

            foreach (Button btn in this.flowLayoutPanel1.Controls)
            {
                if (Enumerable.SequenceEqual(labellist, (IEnumerable<int>)this.flowLayoutPanel1.Controls))
                {
                    MessageBox.Show("Congrats!! You did it");
                }
                else
                {
                    MessageBox.Show("Wrong!! Please Try Again");

                }

            }

            }
            catch (Exception e)
            {
                MessageBox.Show("{0} Exception caught:" + e);

            }

        }

        //-----------------------------------------------------------------------------//
        // Start Button
        private void btnStart_Click(object sender, EventArgs e)
        {
            ShuffleButtons();
            seconds = 0;
            CountdownTimer.Start();
        }


        //-----------------------------------------------------------------------------//
        // Form Load
        private void ReplacingBooksForm_Load(object sender, EventArgs e)
        {
            
            // This helps the flow layout panel allow buttons to be dropped
            flowLayoutPanel1.AllowDrop = true;

            flowLayoutPanel1.DragEnter += flp1_DragEnter;

            flowLayoutPanel1.DragDrop += flp1_DragDrop;
            button13.MouseDown += Buttons_MouseDown;
            button14.MouseDown += Buttons_MouseDown;
            button15.MouseDown += Buttons_MouseDown;
            button16.MouseDown += Buttons_MouseDown;
            button17.MouseDown += Buttons_MouseDown;
            button18.MouseDown += Buttons_MouseDown;
            button19.MouseDown += Buttons_MouseDown;
            button20.MouseDown += Buttons_MouseDown;
            button21.MouseDown += Buttons_MouseDown;
            button22.MouseDown += Buttons_MouseDown;
            button23.MouseDown += Buttons_MouseDown;
            button24.MouseDown += Buttons_MouseDown;

            foreach (Control c in this.flowLayoutPanel1.Controls)
            {
                c.MouseDown += new MouseEventHandler(Buttons_MouseDown);
            }
        }


        //-----------------------------------------------------------------------------//
        //This code helps move the buttons and it is added in the Events tab in the flowLayoutPanel1
        private void flp1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void flp1_DragDrop(object sender, DragEventArgs e)
        {
            Control c = e.Data.GetData(e.Data.GetFormats()[0]) as Control;

            if(c != null)
            {
                c.Location = this.flowLayoutPanel1.PointToClient(new Point(e.X, e.Y));
                this.flowLayoutPanel1.Controls.Add(c);
            }
        }

        private void Buttons_MouseDown(object sender, MouseEventArgs e)
        {
           Control c = sender as Control;

            c.DoDragDrop(c, DragDropEffects.Move);
        }


        //-----------------------------------------------------------------------------//
        // Restart Button
        private void btnRestart_Click(object sender, EventArgs e)
        {
            // This code clears, and adds the buttons back in their place
            this.flowLayoutPanel1.Controls.Clear();

            this.ButtonsHolderPanel.Controls.Add(button13);
            this.ButtonsHolderPanel.Controls.Add(button14);
            this.ButtonsHolderPanel.Controls.Add(button15);
            this.ButtonsHolderPanel.Controls.Add(button16);
            this.ButtonsHolderPanel.Controls.Add(button17);
            this.ButtonsHolderPanel.Controls.Add(button18);
            this.ButtonsHolderPanel.Controls.Add(button19);
            this.ButtonsHolderPanel.Controls.Add(button20);
            this.ButtonsHolderPanel.Controls.Add(button21);
            this.ButtonsHolderPanel.Controls.Add(button22);
            this.ButtonsHolderPanel.Controls.Add(button23);
            this.ButtonsHolderPanel.Controls.Add(button24);

            ShuffleButtons();

        }


        //-----------------------------------------------------------------------------//
        //Timer Feature
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = "Time Remaining: " + seconds++.ToString();
        }


    }
}
