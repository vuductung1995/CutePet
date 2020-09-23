using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CutePet.Service
{
    public interface ICharacterService
    {
        Task<List<Users>> GetAllCharacter();
        Task<Users> GetSingleCharacter(int Id);
        Task<Users> AddCharacter(Users newCharacter);
        Task<Users> DeleteCharacter(int Id);
    }
}
