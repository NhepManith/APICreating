
using Microsoft.AspNetCore.Mvc;

namespace APILeaning.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {

        private static List<Character> Characters = new List<Character>()
        {
            new Character(),
            new Character {   Id=1 ,Name = "Manith"},
            new Character {Id=2, Name = "Vatey" , Intelligence = 100},

        };

        [HttpGet("Get ALl ID")]
        public ActionResult<Character> Get()
        {
            return Ok(Characters);
        }

        [HttpGet("Get Single ID ")]
        public ActionResult<Character> GetSingleID(int id)
        {
            return Ok(Characters.FirstOrDefault(c => c.Id == id)); 
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newcharacter)
        {
            Characters.Add(newcharacter);
            return Ok(Characters);
        }


    }
}
