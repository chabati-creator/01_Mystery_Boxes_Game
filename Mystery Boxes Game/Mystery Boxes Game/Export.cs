using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
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

            //try
            //{
            //    TextWriter tw = new StreamWriter("../../Export/.txt", true);
            //    tw.WriteLine("Mystery Box Game");
            //    tw.Close();
            //    Console.WriteLine("Game Statistics");
            //}
            //catch (Exception e)
            //{

            //    Console.Write(e);
            //}

            //Console.Read();


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
         
            StreamWriter sw = new StreamWriter($"../Export/{txbExport.Text}.txt", true);
            sw.WriteLine("Mystery Box Game Statistics:" + "\n\n" +
                         "Player Name: " + p.GetName() + "\n\n" +
                         "Starting Balance: $" + p.GetStartAmount() + "\n\n" +
                         "Current Balance: $" + p.GetAmount() + "\n\n" +
                         p.AmountWonLost() + "\n\n" +
                         "Rounds Played: " + p.GetRounds());
            sw.Close();
            Console.WriteLine("Game Statistics Exported Successfully");

            string message =     "---------------------------------------------------------------------------------" + "\n" +
                                 "\t      Your game statistics has been successful saved as a txt file." + "\n" +
                                 "\t\t               Thank you for playing" + "\n" +
                                 "\t\t           ---- Mystery Box Game ----" + "\n" +
                                 "---------------------------------------------------------------------------------";
            string caption = "Game Over";

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox which inlcudes the message and caption. 
            result = MessageBox.Show(message, caption, buttons);

        }

        private void Export_Load(object sender, EventArgs e)
        {

        }

        //class WriteAllText
        //{
        //    public static async Task ExampleAsync()
        //    {
        //        string text =
        //            "A class is the most powerful data type in C#. Like a structure, " +
        //            "a class defines the data and behavior of the data type. ";

        //        await File.WriteAllTextAsync("WriteText.txt", text);
        //    }
        //}

        //internal class FileStream
        //{
        //    private object filename;
        //    private object append;

        //    public FileStream(object filename, object append)
        //    {
        //        this.filename = "";
        //        this.append = append;


        //        FileStream stream = new FileStream(filename, FileMode.Append);
        //        StreamWriter writeRecord = new StreamWriter(stream);

        //        filename = "../Export/.txt";
        //        writeRecord.Write("Random string");
        //        writeRecord.WriteLine();

        //        writeRecord.Close();
        //        stream.Close();
        //    }
        //}
    }  
}
