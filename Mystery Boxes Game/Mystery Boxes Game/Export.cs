using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            txbExport.Text = $"../Export/txt";
            p.GetAmount();

            
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameStats window = new GameStats(p, t);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            txbExport.Text = "Starting Balance: $" + p.GetStartAmount() + "\n\n" +
                                "Current Balance: $" + p.GetAmount() + "\n\n" +
                                p.AmountWonLost() + "\n\n" +
                                "Rounds Played: " + p.GetRounds();
            
        }
    }

    internal class FileStream
    {
        private object filename;
        private object append;

        public FileStream(object filename, object append)
        {
            this.filename = "";
            this.append = append;


            FileStream stream = new FileStream(filename, FileMode.Append);
            //StreamWriter writeRecord = new StreamWriter(stream);

            filename = "../Export/.txt";
            //writeRecord.Write("Random string");
            //writeRecord.WriteLine();

            //writeRecord.Close();
            //stream.Close();
        }
    }
}
