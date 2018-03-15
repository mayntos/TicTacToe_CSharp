using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    enum Symbol {X, O, U}; 

    class BoardLogic
    {
        Symbol[,] state;
        Symbol currentTurn;

        public BoardLogic()
        {
            state = new Symbol[3, 3];
            currentTurn = Symbol.X;

            for(int row = 0; row < state.GetLength(0); row++)
            {
                for(int column = 0; column < state.GetLength(1); column++)
                {
                    state[row, column] = Symbol.U;
                }
            }
        }

        public Symbol GetPosition(int x, int y)
        {
            return state[x, y];
        }

        public void SetPosition(int x, int y, Symbol mark)
        {
            // don't allow if it is not their turn
            // don't allow if the spot is occupied.
            if (mark != currentTurn || mark == Symbol.U)
                return;

            // if it is the correct turn, then change to the other symbol
            // for the next turn. 
            state[x, y] = mark;
            currentTurn = (currentTurn == Symbol.X) ? Symbol.O : Symbol.X;
        }

        // 0 | 1 | 2
        // 3 | 4 | 5
        // 6 | 7 | 8
        public bool BoardCheck(Player p)
        {
            //vertical win
            for(int row = 0; row < state.GetLength(0); row++)
            {
                if(state[row, 0] == p.PlayerMark && state[row, 1] == p.PlayerMark && state[row, 2] == p.PlayerMark)
                    return true;
            }

            //horizontal win
            for (int columns = 0; columns < state.GetLength(0); columns++)
            {
                if (state[0, columns] == p.PlayerMark && state[1, columns] == p.PlayerMark && state[2, columns] == p.PlayerMark)
                    return true;
            }

            //diagonal wins
            if (state[1, 1] == p.PlayerMark)
            {
                //upper left to lower right
                if (state[0, 0] == p.PlayerMark && state[2, 2] == p.PlayerMark)
                    return true;
                //upper right to lower left
                else if (state[0, 2] == p.PlayerMark && state[2, 0] == currentTurn)
                    return true;
            }
            return false;

        }
    }
}
