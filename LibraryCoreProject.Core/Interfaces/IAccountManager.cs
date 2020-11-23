using LibraryCoreProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Core.Interfaces
{
    public interface IAccountManager
    {
        User GetByUsernameAndPassword(string username, string password);
        User GetByGoogleId(string googleId);
    }
}
