using System;
using System.Collections.Generic;
using System.Text;

namespace Mystery_Boxes_Game
{
    public class Player
    {
        public int startAmount;
        public int amount;
        public string name;
        private MysteryBox [,] rounds = new MysteryBox [50,3];
        private int roundCounter = 0;

        //The constuctor is a method that allows you to create an object of the class
        public Player(string n, int a)
        {
            name = n;
            startAmount = a;
            amount = startAmount;
        }

        public void BuyBoxes(int t)
        {
            if (t == 0)
            {
                amount -= 5;
            }
            else if (t == 1)
            {
                amount -= 10;
            }
            else
            {
                amount -= 15;
            }    

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

        public int TotalRoundWinnings()
        {
            List<int> values = new List<int>();
            int totalwinnings = 0;

            for (int i = 0; i < 3; i++)
            {
                values.Add(rounds[roundCounter - 1, i].getValue());
            }

            foreach (int value in values)
            {
                totalwinnings += value;
            }
            return totalwinnings;
        }

        public int GetAmount()
        {
            return amount;
        }

        public int GetStartAmount()
        {
            return startAmount;
        }

        public int GetRounds()
        {
            return roundCounter;
        }
    }
}
