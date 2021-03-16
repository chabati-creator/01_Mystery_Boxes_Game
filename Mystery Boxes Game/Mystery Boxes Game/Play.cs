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
        MysteryBox mb = new MysteryBox();
        public Play(MysteryBox m)
        {
            mb = m;
            InitializeComponent();
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }
    }
}
