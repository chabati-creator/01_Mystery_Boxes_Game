using System;
using System.Collections.Generic;
using System.Text;

namespace Mystery_Boxes_Game
{
    class MysteryBox
    {
        private static List<Player> players = new List<Player>();

        public MysteryBox()
        {

        }

        public string AddPlayer(string n, List<int> a)
        {
            players.Add(new Player(n, a));

            return players[players.Count - 1].PlayerSummary();
        }
    }
}
