﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mystery_Boxes_Game
{
    public class MysteryBox
    {
        private List<int> COPPER = new List<int>() { 1, 2, 3 };
        private List<int> SILVER = new List<int>() { 2, 4, 6 };
        private List<int> GOLD = new List<int>() { 5, 10, 15 };


        private int value;
        

        public MysteryBox()
        {
        }

        public MysteryBox(int t)
        {
       
            if (t == 0)
            {
                Random randint = new Random();
                int index = randint.Next(0, 3);
                value = COPPER[index];
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
