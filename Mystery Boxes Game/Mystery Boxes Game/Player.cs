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
        private MysteryBox [,] rounds = new MysteryBox [60,3];
        private int roundCounter = 0;
        public bool roundOpened;

        //The constuctor is a method that allows you to create an object of the class
        public Player(string n, int a)
        {
            //Setting name to n and startAmount to a. While amount which is to be used throughout = startAmount
            name = n;
            startAmount = a;
            amount = startAmount;
        }

        public void BuyBoxes(int t) //BuyBoxes method for calculating the amount based on the type of stake (Low,Med,High)
        {
            if (t == 0)
            {
                amount -= 5;        //When type = 0 for Low then total current amount/balance - 5
            }
            else if (t == 1)
            {
                amount -= 10;       //When type = 1 for Medium then the total current amount - 10
            }
            else
            {
                amount -= 15;       //When type = 2 for High then total current amount - 15
            }    

            for (int i = 0; i < 3; i++)
            {
                rounds[roundCounter, i] = new MysteryBox(t);
            }
            roundCounter++;         //The roundCounter increases by 1 for each round which is store in roundCounter
            roundOpened = false;        //Setting the roundOpened to false as the 'OpenBoxes' button has not been clicked

        }

        public List<int> OpenBoxes()
        {
            List<int> values = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                values.Add(rounds[roundCounter - 1, i].getValue());
            }

            if (roundOpened == false)
            {
                foreach (int value in values)
                {
                    amount += value;
                }
                roundOpened = true;
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

        public string AmountWonLost()
        {
            if (startAmount > amount)
            {
                return "Amount Lost: $" + (startAmount - amount);
            }
            else
            {
                return "Amount Won: $" + (amount - startAmount);
            }
            
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

        public bool GetRoundOpened()
        {
            return roundOpened;
        }
        public int GameCost(int t)
        {
            int GameCost;
            if (t == 0)
            {
                GameCost = 5;
            }
            else if (t == 1)
            {
                GameCost = 10;
            }
            else
                GameCost = 15;

            return GameCost;
        }

    }
}
