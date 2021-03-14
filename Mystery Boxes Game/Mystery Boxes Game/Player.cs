using System;
using System.Collections.Generic;
using System.Text;

namespace Mystery_Boxes_Game
{
    class Player
    {
        private string name;
        private List<int> amount = new List<int>();

        //The constuctor is a method that allows you to create an object of the class
        public Player(string n, List<int> a)
        {
            name = n;
            amount = a;

            Gamestats();

        }
        public string Gamestats()
        {
            string summary;

            summary = "Game Statistics: ";

            return summary;
        }

        

    }
}
