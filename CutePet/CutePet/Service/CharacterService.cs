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
        private readonly WebContext _webContext;
        public CharacterService(WebContext webContext)
        {
            _webContext = webContext;
        }

        public List<Users> AddCharacter(Users newCharacter)
        {
            _webContext.users.Add(newCharacter);
            _webContext.SaveChanges();
            return _webContext.users.ToList();
        }

        public List<Users> DeleteCharacter(int Id)
        {
            var Character = from s in _webContext.users
                            where s.UserId == Id
                            select s;
            _webContext.users.Remove(Character.First());
            _webContext.SaveChanges();
            return _webContext.users.ToList();
        }

        public List<Users> GetAllCharacter()
        {
            return _webContext.users.ToList();
        }

        public Users GetSingleCharacter(int Id)
        {
            return _webContext.users.FirstOrDefault(x => x.UserId == Id);
        }
    }
}
