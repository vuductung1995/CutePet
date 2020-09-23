using CutePet.Repository;
using DataAccess;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CutePet.Service
{
    public class CharacterService : ICharacterService 
    {
        private readonly ICharacterRepository _characterRepository ;
        public CharacterService(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public async Task<Users> AddCharacter(Users newCharacter)
        {
            var result = _characterRepository.Add(newCharacter);
            return await result;
        }

        public async Task<Users> DeleteCharacter(int Id)
        {
            var result= _characterRepository.Delete(Id);
            return await result;
        }

        public async Task<List<Users>> GetAllCharacter()
        {
            var result=_characterRepository.GetAll();
            return await result;
        }

        public async Task<Users> GetSingleCharacter(int Id)
        {
            var result = _characterRepository.Get(Id);
            return await result;
        }
    }
}
