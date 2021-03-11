using System;
using System.Collections.Generic;
using System.Text;

namespace Mystery_Boxes_Game
{
    class Player
    {

        private static List<Player> players = new List<Player>();
        public Player()
        {

        }

        public string AddPlayer(string n, List<int> a)
        {
            players.Add(new Player(n, a));

            return players.Gamestats();
                
        }

    }
}
