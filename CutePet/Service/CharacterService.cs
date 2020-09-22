using CutePet.Models;
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
        private static List<Character> Characters = new List<Character>
        {
            new Character()
        };
        public List<Character> AddCharacter(Character newCharacter)
        {
            Characters.Add(newCharacter);
            return Characters;
        }

        public List<Character> DeleteCharacter(int Id)
        {
            var Character = from s in Characters
                            where s.Id==Id
                            select s;
            Characters.Remove(Character.First());
            return Characters;
        }

        public List<Character> GetAllCharacter()
        {
            return Characters;
        }

        public Character GetSingleCharacter(int Id)
        {
            return Characters.FirstOrDefault(x => x.Id == Id);
        }
    }
}
