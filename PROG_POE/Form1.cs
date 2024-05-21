using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_POE
{
    public partial class Form1 : Form
    {
        // This is the menu form
        public Form1()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------//
        // Replacing Books Form Button
        private void btnReplacingBooks_Click(object sender, EventArgs e)
        {
            // making the replacebooks button go to the intended form
            ReplacingBooksForm replacingBooksForm = new ReplacingBooksForm();
            replacingBooksForm.Show();
            this.Hide();
        }

        //-----------------------------------------------------------------------------//
        // Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------//
        // Identifying Areas Form Button
        private void btnIdentifyingAreas_Click(object sender, EventArgs e)
        {
            IdentifyingAreasForm IAreasForm = new IdentifyingAreasForm();
            IAreasForm.Show();
            this.Hide();
        }

        //-----------------------------------------------------------------------------//
        // Finding Call Numbers Form Button
        private void btnFindingCallNumbers_Click(object sender, EventArgs e)
        {
            FindingCallNumbers FindCallNumForm = new FindingCallNumbers();
            FindCallNumForm.Show();
            this.Hide();
        }
    }
}
//----------------------------------------End Of Project----------------------------------------------//