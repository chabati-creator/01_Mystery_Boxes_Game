using System;
using System.Collections.Generic;
using System.Text;

namespace Mystery_Boxes_Game
{
    public class MysteryBox
    {
        private List<int> LOW = new List<int>() { 0, 1, 2, 5 };
        private List<int> MEDIUM = new List<int>() { 0, 2, 4, 10 };
        private List<int> HIGH = new List<int>() { 0, 3, 6, 15 };

        public int value;

        public MysteryBox()
        {
        }

        public MysteryBox(int t)
        {
       
            if (t == 0)
            {
                Random randint = new Random();
                int index = randint.Next(0, 4);
                value = LOW[index];
            }
            else if (t == 1)
            {
                Random randint = new Random();
                int index = randint.Next(0, 4);
                value = MEDIUM[index];
            }
            else
            {
                Random randint = new Random();
                int index = randint.Next(0, 4);
                value = HIGH[index];
            }
        }

        public int getValue()
        {

            return value;
        }

        //public string AddPlayer(string n, int a)
        //{
        //    players.Add(new Player(n, a));

        //    return players[players.Count - 1].PlayerSummary();
        //}

    }
}
