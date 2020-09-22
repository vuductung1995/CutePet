using CutePet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CutePet.Service
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacter();
        Character GetSingleCharacter(int Id);
        List<Character> AddCharacter(Character newCharacter);
        List<Character> DeleteCharacter(int Id);
    }
}
