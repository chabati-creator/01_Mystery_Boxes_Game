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
            lblInstruction.Text = "Click the 'Play again' button to play another round";

            btnPlayAgain.Visible = true;
            btnOpenBoxes.Visible = false;

            //string message = "...";
            //string caption = "Mystery Boxes Game";

            //MessageBoxButtons buttons = MessageBoxButtons.OK;
            //DialogResult result;

            //// Displays the MessageBox which inlcudes the message and caption. 
            //result = MessageBox.Show(message, caption, buttons);

        }

        private void Play_Load(object sender, EventArgs e)
        {
            btnPlayAgain.Visible = false;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //The Start Screen closes and the Play screen opens
            this.Hide();
            PlayAgain window = new PlayAgain(p, t);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnGameStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameStats window = new GameStats(p,t);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
