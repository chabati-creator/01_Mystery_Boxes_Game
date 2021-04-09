using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mystery_Boxes_Game
{
    public partial class Play : Form
    {
        Player p;
        int t;
        
        MysteryBox mb = new MysteryBox();
        public Play(Player p, int t)
        {
            this.p = p;
            this.t = t;

            InitializeComponent();

            
            //if (p.amount < 5)
            //{
            //    btnPlayAgain.Enabled = false;
            //}
            //else
            //{
            //    btnPlayAgain.Enabled = true;
            //}
            

            if (p.GetRoundOpened() == true)
            {
                List<int> boxValues = new List<int>();
                boxValues = p.OpenBoxes();

                //Shows the images corresponding to the type of stake (Low, Medium, High) and the values
                pbx1.Image = Image.FromFile($"../Images/{t}{boxValues[0]}.gif");
                pbx2.Image = Image.FromFile($"../Images/{t}{boxValues[1]}.gif");
                pbx3.Image = Image.FromFile($"../Images/{t}{boxValues[2]}.gif");

                string name = p.name;
                lblHeading.Text = $"Congratulations {name}!!!";
                lblInstruction.Text = "Click the 'Play Again' button to play another round";
                lblPayback.Text = "Payback Amount: $" + p.TotalRoundWinnings();

                btnOpenBoxes.Visible = false;

                if (p.amount < 5)
                {
                    btnPlayAgain.Enabled = false;

                    
                }
                else
                {
                    btnPlayAgain.Enabled = true;
                }
            }
            else
            {
                btnPlayAgain.Visible = false;
                btnGameStats.Visible = false;
            }
            
        }

        private void btnOpenBoxes_Click(object sender, EventArgs e)
        {
            List<int> boxValues = new List<int>();
            boxValues = p.OpenBoxes();

            //Shows the images corresponding to the type of stake (Low, Medium, High) and the values
            pbx1.Image = Image.FromFile($"../Images/{t}{boxValues[0]}.gif");
            pbx2.Image = Image.FromFile($"../Images/{t}{boxValues[1]}.gif");
            pbx3.Image = Image.FromFile($"../Images/{t}{boxValues[2]}.gif");

            string name = p.name;
            lblHeading.Text = $"Congratulations {name}!!!";
            lblInstruction.Text = "Press <enter> or click the 'Play Again' button to play another round";
            lblPayback.Text = "Game Cost: $" + p.GameCost(t) + "\n" + 
                              "Payback Amount: $" + p.TotalRoundWinnings() + "\n" +
                              "Current Balance: $" + p.GetAmount();

            btnPlayAgain.Visible = true;
            btnGameStats.Visible = true;
            btnOpenBoxes.Visible = false;

            if (p.amount < 5)
            {
                btnPlayAgain.Enabled = false;

                string message = "------------------------------------------------------------------------" + "\n" +
                                 "Your current balance is less than the required amount to play the game." + "\n" +
                                 "\t\t      Thank you for playing" + "\n" +
                                 "\t\t ---- Mystery Box Game ----" + "\n" +
                                 "------------------------------------------------------------------------";
                string caption = "Game Over";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox which inlcudes the message and caption. 
                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                btnPlayAgain.Enabled = true;
            }

            //string message = "...";
            //string caption = "Mystery Boxes Game";

            //MessageBoxButtons buttons = MessageBoxButtons.OK;
            //DialogResult result;

            //// Displays the MessageBox which inlcudes the message and caption. 
            //result = MessageBox.Show(message, caption, buttons);

        }

        private void Play_Load(object sender, EventArgs e)
        {
            //btnPlayAgain.Visible = false;
            //btnGameStats.Visible = false;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //The Play Screen closes and the Play Again screen opens
            this.Hide();
            PlayAgain window = new PlayAgain(p, t);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnGameStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameStats window = new GameStats(p, t);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
