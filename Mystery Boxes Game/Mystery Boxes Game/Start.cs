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
        MysteryBox cm = new MysteryBox();
        public Start()
        {
            InitializeComponent();
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;

            List<int> amount = new List<int>();

            amount.Add(Convert.ToInt32(nudAmount.Value));

            string message = cm.AddPlayer(name, amount);
            string caption = "Mystery Boxes Game";

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox which inlcudes the message and caption. 
            result = MessageBox.Show(message, caption, buttons);
        }

    }
}
