using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Rodrigo Nerys, Oct 03, 2022.
// In this Lab 2, I am creating an executable program that will calculate integer numbers and
// show a picture and info about Saint John.
namespace NerysLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //show the picture
            picBox.Visible = true;
            
            //hide the label
            lblInfo.Hide();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //hide the picture and the data info
            picBox.Hide();
            lblInfo.Hide();
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            //blank out the text box and answer label
            txtNumber.ResetText();
            txtMultiplier.ResetText();
            lblAnswer.ResetText();
            
            //put the cursor on the top text box
            txtNumber.Focus();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //show info label
            lblInfo.Visible = true;
            
            //information in the data label
            lblInfo.Text = "My topic is " + lblTopic.Text + ".\n\n" +
                "Saint John is a seaport city of the Atlantic Ocean located on the Bay of Fundy in the province of New Brunswick, Canada. " +
                "Saint John is the oldest incorporated city in Canada, established by royal charter on May 18, 1785.\n" +
                "This photo is a view of Uptown and the Harbor of Saint John, from the City Sign lookout. One of the most beaultiful places to visit in the city!";
            
            //hide picture box
            picBox.Hide();
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            //Display a message box
            MessageBox.Show("Photo of my bike and the bay!", "Rodrigo Nerys", MessageBoxButtons.OK);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //create local variables
            int number, multiplier, answer;

            if(txtNumber.Text != "") //compare if number text box is empty
            {
                //Place the data from the textbox into the variables
                number = Convert.ToInt32(txtNumber.Text);
            } else number = 0;

            if (txtMultiplier.Text != "") //compare if multiplier text box is empty
            {
                //Place the data from the textbox into the variables
                multiplier = Convert.ToInt32(txtMultiplier.Text);
            } else multiplier = 0;
            

            //multiply the number and the multiplier
            answer = number * multiplier;
                
            //display the answer
            lblAnswer.Text = answer.ToString();
            
        }
    }
}
