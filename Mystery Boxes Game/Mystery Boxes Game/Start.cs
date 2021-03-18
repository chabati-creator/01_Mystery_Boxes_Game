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
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;

            int amount = Convert.ToInt32(nudAmount.Value);

            p = new Player(name, amount);

            p.BuyBoxes(0);
            //string caption = "Mystery Boxes Game";

            //MessageBoxButtons buttons = MessageBoxButtons.OK;
            //DialogResult result;

            //// Displays the MessageBox which inlcudes the message and caption. 
            //result = MessageBox.Show(message, caption, buttons);

            //The Start Screen closes and the Play screen opens
            this.Hide();
            Play window = new Play(p);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

    }
}
