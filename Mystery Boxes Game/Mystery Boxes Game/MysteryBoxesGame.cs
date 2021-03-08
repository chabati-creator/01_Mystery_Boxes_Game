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
    public partial class MysteryBoxesGame : Form
    {
        MysterySkeleton cm = new MysterySkeleton();
        public MysteryBoxesGame()
        {
            InitializeComponent();
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            string message = cm.Info();
            string caption = "Mystery Boxes Game";

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox which inlcudes the message and caption. 
            result = MessageBox.Show(message, caption, buttons);
        }
    }
}
