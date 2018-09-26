using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe
{
    public class Game
    {
        public Game(NewGameModel newGameModel)
        {
            Model = newGameModel;
            Board = new string[9];
            Winner = "";
            Status = "Ongoing";
        }

        public NewGameModel Model { get; set; }

        public string Status { get; set; }

        public string Winner { get; set; }

        public string[] Board { get; set; }


    }
}
