using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mystery_Boxes_Game
{
    public partial class GameStats : Form
    {
        Player p;
        int t;
        public GameStats(Player p, int t)
        {
            this.p = p;
            this.t = t;
            InitializeComponent();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play window = new Play(p, t);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void GameStats_Load(object sender, EventArgs e)
        {
            lblGameStats.Text = "Starting Balance: $" + p.GetStartAmount() + "\n\n" +
                                "Current Balance: $" + p.GetAmount() + "\n\n"+
                                p.AmountWonLost() + "\n\n" +
                                "Rounds Played: " + p.GetRounds() + "\n\n" +
                                "Please use the 'Export' button to generate a text file showing your " +
                                "statistics and the results  of each round that you played.";
        }
    }
}
