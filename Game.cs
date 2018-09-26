using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe
{
    public class Game
    {
        public Game(string O, string X, Guid gameId)
        {
            this.O = O;
            this.X = X;
            this.gameId = gameId;
            Board = new string[9];
            Winner = "";
            Status = "Ongoing";
        }
        
        public string O { get; set; }

        public string X { get; set; }

        public Guid gameId { get; set; }

        public string Status { get; set; }

        public string Winner { get; set; }

        public string[] Board { get; set; }


        public void PlayGame(string playModelPlayer, int playModelBoardPosition)
        {
        }
    }
}
