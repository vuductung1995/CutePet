using DataAccess;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class UnitOfWork : IUnitOfWorks

    {
        private readonly WebContext _webContext;
        public UnitOfWork(WebContext webContext)
        {
            _webContext = webContext;
            CharacterRepository = new CharacterRepository(_webContext);
        }
        public ICharacterRepository CharacterRepository { get; private set; }
        public void Commit()
        {
            _webContext.SaveChanges();
        }
        public void Rollback()
        { 
            _webContext.Dispose(); 
        }
    }
}
