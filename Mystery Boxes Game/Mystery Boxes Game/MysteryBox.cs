using System;
using System.Collections.Generic;
using System.Text;

namespace Mystery_Boxes_Game
{
    public class MysteryBox
    {
        private List<int> LOW = new List<int>() { 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 5, 5, 5};
        private List<int> MEDIUM = new List<int>() { 0, 0, 0, 2, 2, 2, 4, 4, 10, 10};
        private List<int> HIGH = new List<int>() { 0, 0, 0, 3, 3, 3, 3, 6, 6, 15};

        public int value;

        public MysteryBox()
        {
        }

        public MysteryBox(int t)
        {
       
            if (t == 0)
            {
                Random randint = new Random();
                int index = randint.Next(0, 15);
                value = LOW[index];
            }
            else if (t == 1)
            {
                Random randint = new Random();
                int index = randint.Next(0, 10);
                value = MEDIUM[index];
            }
            else
            {
                Random randint = new Random();
                int index = randint.Next(0, 10);
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
