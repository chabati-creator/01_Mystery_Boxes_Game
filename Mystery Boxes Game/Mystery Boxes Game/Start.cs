using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mystery_Boxes_Game
{
    public partial class Start : Form
    {
        Player p;
        public Start()
        {
            InitializeComponent();

            btnMed.Enabled = false;
            btnHigh.Enabled = false;
        }

        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {
            if (nudAmount.Value <= 10)
            {
                btnMed.Enabled = false;
            }
            if (nudAmount.Value >= 10)
            {
                btnMed.Enabled = true;
                if (nudAmount.Value <= 15)
                {
                    btnHigh.Enabled = false;
                }
            }
            if (nudAmount.Value >= 15)
            {
                btnHigh.Enabled = true;
            }

        }

        private void btnLow_Click(object sender, EventArgs e) //Low Button
        {
            string name = txbName.Text;                     //Get the user's name

            if (txbName.Text == "")                         //Check that name textbox is not blank. If the name textbox is blank then...
            {
                txbName.BackColor = Color.LightPink;            //the background colour changes to light pink
                string caption = "Error";
                string message = "The name textbox cannot be empty. Please enter player's name";   //Shows the error message to the user
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                //Displays the MessageBox which inlcudes the message and caption. 
                result = MessageBox.Show(message, caption, buttons);
                txbName.Focus();
            }
            else
            {
                int amount = Convert.ToInt32(nudAmount.Value);  //Get the user's starting amount/balance and name which is passed through Player constructor

                p = new Player(name, amount);

                p.BuyBoxes(0);                                  //Set the type to 0 for Low stake

                this.Hide();                                    //The Start screen closes
                Play window = new Play(p, 0);                    //Play screen opens passing the p(name and amount) and the type = 0 for Low stake
                window.FormClosed += (s, args) => this.Close();
                window.Show();
            }
     
        }

        private void btnMed_Click(object sender, EventArgs e)  //Medium Button
        {
            string name = txbName.Text;

            if (txbName.Text == "")
            {
                txbName.BackColor = Color.LightPink;        
                string caption = "Error";
                string message = "The Name textbox cannot be empty. Please enter player's name"; 
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                //Displays the MessageBox which inlcudes the message and caption. 
                result = MessageBox.Show(message, caption, buttons);
                txbName.Focus();
            }
            else
            {
                int amount = Convert.ToInt32(nudAmount.Value);
                p = new Player(name, amount);

                p.BuyBoxes(1);                                  // Set the type to 1 for Medium stake

                this.Hide();
                Play window = new Play(p, 1);                   //Play screen opens passing the p(name and amount) and the type = 1 for Medium stake
                window.FormClosed += (s, args) => this.Close();
                window.Show();
            }
            
        }

        private void btnHigh_Click(object sender, EventArgs e)  //High Button
        {
            string name = txbName.Text;

            if (txbName.Text == "")
            {
                txbName.BackColor = Color.LightPink;   
                string caption = "Error";
                string message = "The Name textbox cannot be empty. Please enter player's name"; 
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                //Displays the MessageBox which inlcudes the message and caption. 
                result = MessageBox.Show(message, caption, buttons);
                txbName.Focus();
            }
            else
            {
                int amount = Convert.ToInt32(nudAmount.Value);
                p = new Player(name, amount);

                p.BuyBoxes(2);                                  // Set the type to 2 for High stake

                this.Hide();
                Play window = new Play(p, 2);                   //Play screen opens passing the p(name and amount) and the type = 2 for High stake
                window.FormClosed += (s, args) => this.Close();
                window.Show();
            }

        }

        private void btnHelp_Click(object sender, EventArgs e)  //Help Button
        {
            this.Hide();                                //The Start screen closes
            Help window = new Help();                   
            window.FormClosed += (s, args) => this.Close();
            window.Show();                              //Help screen opens to show the user relevant information and instructions
        }

    }
}
