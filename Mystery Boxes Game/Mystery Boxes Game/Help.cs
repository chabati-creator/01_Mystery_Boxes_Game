using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mystery_Boxes_Game
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start window = new Start();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
