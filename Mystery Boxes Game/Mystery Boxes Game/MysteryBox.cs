using System;
using System.Collections.Generic;
using System.Text;

namespace Mystery_Boxes_Game
{
    public class MysteryBox
    {
        private List<int> BRONZE = new List<int>() { 0, 2, 3 };
        private List<int> SILVER = new List<int>() { 2, 4, 6 };
        private List<int> GOLD = new List<int>() { 3, 6, 9 };

        private int value;
        private int type;

        public MysteryBox()
        {
        }

        public MysteryBox(int t)
        {
            type = t;
            if (t == 0)
            {
                Random randint = new Random();
                int index = randint.Next(0, 3);
                value = BRONZE[index];
            }
            else if (t == 1)
            {
                Random randint = new Random();
                int index = randint.Next(0, 3);
                value = SILVER[index];
            }
            else
            {
                Random randint = new Random();
                int index = randint.Next(0, 3);
                value = GOLD[index];
            }
        }


        //public string AddPlayer(string n, int a)
        //{
        //    players.Add(new Player(n, a));

        //    return players[players.Count - 1].PlayerSummary();
        //}

    }
}
