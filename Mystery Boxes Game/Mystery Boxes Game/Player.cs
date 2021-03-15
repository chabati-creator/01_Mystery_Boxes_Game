using System;
using System.Collections.Generic;
using System.Text;

namespace Mystery_Boxes_Game
{
    class Player
    {
        private string name;
        private List<int> amounts = new List<int>();

        //The constuctor is a method that allows you to create an object of the class
        public Player(string n, List<int> a)
        {
            name = n;
            amounts = a;

            AnalyseAmount();

        }
        public string AnalyseAmount()
        {
            string summary;

            summary = "";

            return summary;
        }

        public float Amount()
        {
            int sumAmount = 0;

            foreach (int amount in amounts)
            {
                //Adding the amount won to the total amount
                sumAmount += amount;
            }

            return sumAmount;
        }

        public string PlayerSummary()  //Method to show the player summary
        {
            string summary;

            summary = "Name: " + name + "\n" + "Amount: s" + Amount();  //Output the name and the amount to the user when the button is clicked

            return summary;
        }

    }
}
