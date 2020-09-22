using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CutePet.Models;
using CutePet.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CutePet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
        [Route("GetAll")]    
        public IActionResult GetAll()
        {
            return Ok(_characterService.GetAllCharacter());
        }
        [Route("GetSingle")]
        public IActionResult GetSingle(int Id)
        {
            return Ok(_characterService.GetSingleCharacter(Id));
        }
        [Route("AddCharacter")]
        public IActionResult AddCharacter(Character newCharacter)
        {
            return Ok(_characterService.AddCharacter(newCharacter));
        }
        [Route("DeleteCharacter")]
        public IActionResult DeleteCharacter(int Id)
        {
            return Ok(_characterService.DeleteCharacter(Id));
        }
    }
}
