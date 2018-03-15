using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class BoardDisplay
    {
        //take a BoardLogic as input
        BoardLogic logicRef;

        public BoardDisplay(BoardLogic l)
        {
            logicRef = l;
        }

        public void Render()
        {
            Console.WriteLine($"\n {logicRef.GetPosition(0, 0)} | {logicRef.GetPosition(0, 1)} | {logicRef.GetPosition(0, 2)} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {logicRef.GetPosition(1, 0)} | {logicRef.GetPosition(1, 1)} | {logicRef.GetPosition(1, 2)} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {logicRef.GetPosition(2, 0)} | {logicRef.GetPosition(2, 1)} | {logicRef.GetPosition(2, 2)} ");
        }
    }
}
