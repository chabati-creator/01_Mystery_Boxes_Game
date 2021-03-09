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
        Manager cm = new Manager();
        public MysteryBoxesGame()
        {
            InitializeComponent();
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            string message = cm.ClassSummary();
            if (message.Equals(""))
            {
                message = "No students have been added to class";
            }

            List<int> StartAmount = new List<int>();

            StartAmount.Add(Convert.ToInt32(nudLow.Value));

            string message = cm.Input(amount);
            string caption = "Mystery Boxes Game";

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox which inlcudes the message and caption. 
            result = MessageBox.Show(message, caption, buttons);
        }

    }
}
