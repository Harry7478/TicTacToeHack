using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Models;

namespace TicTacToe.Controllers
{

    [Route("api/[controller]")]
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
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] NewGameModel newGame)
        {
            GameManager.GameList.Add(newGame.gameId);

            return Ok();


        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
