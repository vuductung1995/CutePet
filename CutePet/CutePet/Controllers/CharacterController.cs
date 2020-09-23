using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CutePet.Service;
using DataAccess.Models;
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
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _characterService.GetAllCharacter());
        }
        [Route("GetSingle")]
        public async Task<IActionResult> GetSingle(int Id)
        {
            return Ok(await _characterService.GetSingleCharacter(Id));
        }
        [Route("AddCharacter")]
        public async Task<IActionResult> AddCharacter(Users newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
        [Route("DeleteCharacter")]
        public async Task<IActionResult> DeleteCharacter(int Id)
        {
            return Ok(await _characterService.DeleteCharacter(Id));
        }
    }
}
