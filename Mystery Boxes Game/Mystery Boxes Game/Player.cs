using System;
using System.Collections.Generic;
using System.Text;

namespace Mystery_Boxes_Game
{
    public class Player
    {
        private int amount;
        public string name;
        private MysteryBox [,] rounds = new MysteryBox [50,3];
        private int roundCounter = 0;

        //The constuctor is a method that allows you to create an object of the class
        public Player(string n, int a)
        {
            name = n;
            amount = a;
        }

        public void BuyBoxes(int t)
        {
            for (int i = 0; i < 3; i++)
            {
                rounds[roundCounter, i] = new MysteryBox(t);
            }
            roundCounter++;
        }

        public List<int> OpenBoxes()
        {
            List<int> values = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                values.Add(rounds[roundCounter - 1, i].getValue());
            }

            foreach (int value in values)
            {
                amount += value;
            }

   
            return values;
        }

        public string PlayerSummary()  //Method to show the player summary
        {
            string summary;

            summary = "Name: " + name + "\n" + "Amount: $" + amount;  //Output the name and the amount to the user when the button is clicked

            return summary;
        }

        //public float Amount()
        //{
        //    int sumAmount = 0;

        //    foreach (int amount in amounts)
        //    {
        //        //Adding the amount won to the total amount
        //        sumAmount += amount;
        //    }

        //    return sumAmount;
        //}

    }
}
