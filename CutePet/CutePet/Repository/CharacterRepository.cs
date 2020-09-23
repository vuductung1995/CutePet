using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CutePet.Repository
{
    public class CharacterRepository: BaseRepository<Users>,ICharacterRepository
    {
        public CharacterRepository(WebContext context) : base(context)
        {

        }
    }
}
