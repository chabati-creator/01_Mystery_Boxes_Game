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

        private void btnStartDismiss_Click(object sender, EventArgs e) //Dismiss Button
        {
            
            this.Hide();                                        //The Help screen closes
            Start window = new Start();                         //Start screen re-opens for the user 
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
