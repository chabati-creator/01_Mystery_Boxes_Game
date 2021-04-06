using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mystery_Boxes_Game
{
    public partial class Export : Form
    {
        Player p;
        int t;
        public Export(Player p, int t)
        {
            this.p = p;
            this.t = t;
            InitializeComponent();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameStats window = new GameStats(p, t);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
