using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class PlayModel
    {
        public Guid gameId { get; set; }

        public string player { get; set; }

        public int boardPosition { get; set; }
        
    }
}
