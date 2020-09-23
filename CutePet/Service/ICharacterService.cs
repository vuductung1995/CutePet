using CutePet.Models;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CutePet.Service
{
    public interface ICharacterService
    {
        List<Users> GetAllCharacter();
        Users GetSingleCharacter(int Id);
        List<Users> AddCharacter(Users newCharacter);
        List<Users> DeleteCharacter(int Id);
    }
}
