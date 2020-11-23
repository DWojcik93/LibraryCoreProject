using AutoMapper;
using LibraryCoreProject.Core.Helpers;
using LibraryCoreProject.Core.Interfaces;
using LibraryCoreProject.Data.Context;
using LibraryCoreProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Core.Managers
{
    public class AccountManager : IAccountManager
    {
        private readonly LibraryContext _context;
        private readonly IMapper _mapper;

        public AccountManager(LibraryContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public User GetByGoogleId(string googleId)
        {
            throw new NotImplementedException();
        }

        public User GetByUsernameAndPassword(string username, string password)
            => _context.Users.FirstOrDefault(a => a.FirstName == username && a.Password == password.Sha256());
    }
}
