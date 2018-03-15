using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization of necessary objects.
            BoardLogic logic = new BoardLogic();
            BoardDisplay display = new BoardDisplay(logic);
            Player player1 = new Player(Symbol.X);
            Player player2 = new Player(Symbol.O);
            Player currentPlayer = player1;
            bool flag = true;

            Console.WriteLine("Tic Tac Toe");

            //a method to check assess if a player has won
            //or if there's a draw, must be used to control
            //the while loop.
            while (true)
            {

                Console.WriteLine("Enter a position [1-9]:");
                int position = Convert.ToInt32(Console.ReadLine());
                switch (position)
                {
                    case 1: logic.SetPosition(0, 0, currentPlayer.PlayerMark); break;
                    case 2: logic.SetPosition(0, 1, currentPlayer.PlayerMark); break;
                    case 3: logic.SetPosition(0, 2, currentPlayer.PlayerMark); break;
                    case 4: logic.SetPosition(1, 0, currentPlayer.PlayerMark); break;
                    case 5: logic.SetPosition(1, 1, currentPlayer.PlayerMark); break;
                    case 6: logic.SetPosition(1, 2, currentPlayer.PlayerMark); break;
                    case 7: logic.SetPosition(2, 0, currentPlayer.PlayerMark); break;
                    case 8: logic.SetPosition(2, 1, currentPlayer.PlayerMark); break;
                    case 9: logic.SetPosition(2, 2, currentPlayer.PlayerMark); break;
                }
                display.Render();
                if (logic.BoardCheck(currentPlayer) == true)
                    break;
                //switch the current player's turn at the end.
                currentPlayer = (currentPlayer.Equals(player1)) ? player2 : player1;
            }
            Console.WriteLine("DONE");
        }
    }
}
