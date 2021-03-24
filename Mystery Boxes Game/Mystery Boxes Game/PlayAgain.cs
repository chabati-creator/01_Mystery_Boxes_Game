using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mystery_Boxes_Game
{
    public partial class PlayAgain : Form
    {
        Player p;
        int t;
        public PlayAgain(Player p, int t)
        {
            this.p = p;
            this.t = t;
            InitializeComponent();
        }

        private void PlayAgain_Load(object sender, EventArgs e)
        {

            lblInfo.Text = "Payback Amount: $" + p.TotalRoundWinnings() + "\n" +
                           "Current Balance: $" + p.GetAmount();
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            p.BuyBoxes(0);

            this.Hide();
            Play window = new Play(p, 0);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            p.BuyBoxes(1);

            this.Hide();
            Play window = new Play(p, 1);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            p.BuyBoxes(2);

            this.Hide();
            Play window = new Play(p, 2);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
