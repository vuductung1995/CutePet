using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;

namespace CutePet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly IUnitOfWorks _unitOfWorks;
        public CharacterController(IUnitOfWorks unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
        }
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _unitOfWorks.CharacterRepository.GetAll());
        }
        [Route("GetSingle")]
        public async Task<IActionResult> GetSingle(int Id)
        {
            var result = await _unitOfWorks.CharacterRepository.Get(Id);
            return Ok(result);
        }
        [Route("AddNewCharacter")]
        public async Task<IActionResult> AddNewCharacter(Users newCharacter)
        {
            var result = await _unitOfWorks.CharacterRepository.Add(newCharacter);
            return Ok(result);
        }
        [Route("DeleteCharacter")]
        public async Task<IActionResult> DeleteCharacter(int Id)
        {
            var result = await _unitOfWorks.CharacterRepository.Delete(Id);
            return Ok(result);
        }
    }
}
