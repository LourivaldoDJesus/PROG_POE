using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_POE
{
    public partial class IdentifyingAreasForm : Form
    {
        // the idea to match the columns using drag and drop came from the link below
        // https://stackoverflow.com/questions/47942524/match-column-a-button-with-column-b-panel-c-sharp
        

        // Call Numbers and Descriptions are stored in these Dictionaries
        Dictionary<int, string> CallNumbersDict = new Dictionary<int, string>();
        Dictionary<int, string> DescriptionsDict = new Dictionary<int, string>();

        Random random = new Random();

        int points = 0;

        public IdentifyingAreasForm()
        {
            InitializeComponent();

        }

        //---------------------------Identifying Areas Form Load------------------------------------------------//
        private void IdentifyingAreasForm_Load(object sender, EventArgs e)
        {

            // This code also helps on moving the labels throughout the form
            pnlCheckAnswer.AllowDrop = true;

            pnlCheckAnswer.DragEnter += controlsDragEnter;

            pnlCheckAnswer.DragDrop += controlsDragDrop;
            label1.MouseDown += controlsMouseDown;
            label2.MouseDown += controlsMouseDown;
            label3.MouseDown += controlsMouseDown;
            label4.MouseDown += controlsMouseDown;
            label5.MouseDown += controlsMouseDown;
            label6.MouseDown += controlsMouseDown;
            label7.MouseDown += controlsMouseDown;
            label8.MouseDown += controlsMouseDown;
            label10.MouseDown += controlsMouseDown;
            label11.MouseDown += controlsMouseDown;
            label12.MouseDown += controlsMouseDown;

            foreach (Control c in this.pnlCheckAnswer.Controls)
            {
                c.MouseDown += new MouseEventHandler(controlsMouseDown);
            }

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
        //----------------------------------------------------------------------------------------------------//

        private void Call_Click(object sender, EventArgs e)
        {

        }

        //---------------------------Start Button------------------------------------------------------------//
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            GenerateCallNum();
            RandomQuestions();
        }

        //---------------------------Verify Answer Button---------------------------------------------------//
        private void btnVerifyAswer_Click(object sender, EventArgs e)
        {
            VerifyColumns();
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
                c.Location = this.pnlCheckAnswer.PointToClient(new Point(e.X, e.Y));
                this.pnlCheckAnswer.Controls.Add(c);
            }
        }

        private void controlsMouseDown(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;

            c.DoDragDrop(c, DragDropEffects.Move);
        }

        //------------------------------Generating Call Numbers------------------------------------------//
        private void GenerateCallNum()
        {

            try
            {
            // Adding the keys and values to call numbers dictionary 
            CallNumbersDict.Add(000, "General Works, Computer Science & Information");
            CallNumbersDict.Add(100, "Philosophy & Psychology");
            CallNumbersDict.Add(200, "Religion");
            CallNumbersDict.Add(300, "Social sciences");
            CallNumbersDict.Add(400, "Language");
            CallNumbersDict.Add(500, "Science");
            CallNumbersDict.Add(600, "Technology");
            CallNumbersDict.Add(700, "Arts & recreation");
            CallNumbersDict.Add(800, "Literature");
            CallNumbersDict.Add(900, "History & Geography");

            // To facilitate the display, Call numbers dictionary keys were also added to a list
            // I got this from this link: https://www.dotnetperls.com/convert-dictionary-list

            foreach (Label lbl in this.pnlCallNumbers.Controls)
            {
                // adding the keys to a list
                List<int> CallNumbersKeys = new List<int>(this.CallNumbersDict.Keys);

                // Getting call numbers randomly from the list and display them in the labels
                int labelindex = random.Next(0, CallNumbersKeys.Count);
                lbl.Text = Convert.ToString(CallNumbersKeys[labelindex]);
            }

            }
            catch (Exception e) 
            {
                MessageBox.Show("{0} Exception caught:" + e);
            }

        }

        //------------------------------Generating Random Descriptions-----------------------------------//
        private void RandomQuestions()
        {
            try
            {
            // Adding the keys and values to correct descriptions dictionary 
            DescriptionsDict.Add(000, "Enhance people's understanding of computer science and general works.");
            DescriptionsDict.Add(100, "Helps in the understanding of human beings.");
            DescriptionsDict.Add(200, "These books tell more about the history of religion.");
            DescriptionsDict.Add(300, "These books Help dealing with human behaviour in its social and cultural aspects.");
            DescriptionsDict.Add(400, "Appropriated for language enthusiasts.");
            DescriptionsDict.Add(500, "Books appropriated for science fans.");
            DescriptionsDict.Add(600, "Helps understand Technology.");
            DescriptionsDict.Add(700, "Enhances knowledge in arts and recreation.");
            DescriptionsDict.Add(800, "Related to works of poetry and prose.");
            DescriptionsDict.Add(900, "These books help understand the history and geography of the world.");
            DescriptionsDict.Add(1, "It is used to display Video Games related books.");
            DescriptionsDict.Add(2, "It is used for Astrology.");
            DescriptionsDict.Add(3, "These are cars related books.");
            DescriptionsDict.Add(4, "It is about Football facts.");
            DescriptionsDict.Add(5, "It is appropriate for Rugby fans.");

            // Displaying the descriptions from the list
            foreach (Label label in pnlDescriptions.Controls )
            {
   
                List<string> DescriptionsValues = new List<string>(this.DescriptionsDict.Values);
          
                int labelindex3 = random.Next(0, DescriptionsValues.Count);
                label.Text = DescriptionsValues[labelindex3];
            }

            }
            catch(Exception e)
            {
                MessageBox.Show("{0} Exception caught:" + e);

            }

        }

        //------------------------------Verifying If Columns match--------------------------------------//
        private void VerifyColumns()
        {
            points = 0;

            try
            {
            // To check if the answer is correct, The keys of both dictionaries will be compared.
            if (DescriptionsDict.Keys == CallNumbersDict.Keys)
            {
                MessageBox.Show("Correct!");
                this.pnlCheckAnswer.Controls.Clear();
                generatingPoints();
            }
            else
            {
                MessageBox.Show("Incorrect!");
                this.pnlCheckAnswer.Controls.Clear();
            }

            // Checking if the answer panel is empty and displaying a custom message.
            if (this.pnlCheckAnswer.Controls.Count == 0) { MessageBox.Show("Drag an item here!"); }

            }
            catch (Exception e)
            {
                MessageBox.Show("{0} Exception caught:" + e);

            }

        }

        //------------------------------Points gamification--------------------------------------------//
        private void generatingPoints()
        {
            label15.Text = points++.ToString();
        }

    }

}
//----------------------------------------End Of File----------------------------------------------//