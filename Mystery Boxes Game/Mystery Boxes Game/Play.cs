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
        MysteryBox mb = new MysteryBox();
        public Play(Player p)
        {
            this.p = p;
            InitializeComponent();
        }

        private void btnOpenBoxes_Click(object sender, EventArgs e)
        {

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
