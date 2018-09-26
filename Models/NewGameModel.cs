using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class NewGameModel
    {
        public string O { get; set; }

        public string X { get; set; }

        public Guid gameId { get; set; }
        
    }
}
