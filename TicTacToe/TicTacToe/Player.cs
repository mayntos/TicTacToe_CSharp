using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public Symbol PlayerMark { get; set; }

        public Player(Symbol x)
        {
            PlayerMark = x;
        }
    }
}
