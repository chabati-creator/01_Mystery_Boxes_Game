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

            pbx1.Image = Image.FromFile($"../Images/{t}{boxValues[0]}");
            pbx2.Image = Image.FromFile($"../Images/{t}{boxValues[1]}");
            pbx3.Image = Image.FromFile($"../Images/{t}{boxValues[2]}");


            //string message = mb.OpenBox();
            //string caption = "Mystery Boxes Game";

            //MessageBoxButtons buttons = MessageBoxButtons.OK;
            //DialogResult result;

            // Displays the MessageBox which inlcudes the message and caption. 
            //result = MessageBox.Show(message, caption, buttons);


            //The Play Screen closes and the Start Screen Opens
            //this.Hide();
            //Start window = new Start(mb);
            //window.FormClosed += (s, args) => this.Close();
            //window.Show();
        }
    }
}
