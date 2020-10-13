using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IUnitOfWorks 
    { 
        void Commit();
        void Rollback();
        ICharacterRepository CharacterRepository { get;}
    }
}
