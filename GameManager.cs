using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe
{
    public static class GameManager
    {
        
        public static List<Guid> GameList = new List<Guid>();

        public static Dictionary<Guid, Game> GameDictionary = new Dictionary<Guid, Game>();
    }
}
