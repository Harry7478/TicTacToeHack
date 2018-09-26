using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Models;

namespace TicTacToe.Controllers
{

    [Route("api/tttgame")]
    [ApiController]
    public class tttgame : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Guid>>Get()
        {
            //Guid gameID
            return GameManager.GameList;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Game> Get(Guid id)
        {
            return GameManager.GameDictionary[id];
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] NewGameModel newGameModel)
        {
            GameManager.GameList.Add(newGameModel.gameId);

            Game newGame = new Game(newGameModel.O, newGameModel.X, newGameModel.gameId);
            GameManager.GameDictionary.Add(newGameModel.gameId, newGame);

            return Ok();
        }

        [HttpPost("play")]
        public IActionResult Post([FromBody] PlayModel playModel)
        {
            //GameManager.GameDictionary[playModel.gameId].PlayGame(playModel.player, playModel.boardPosition);

            return Ok();
        }

    }
}
