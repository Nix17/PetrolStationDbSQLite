using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetrolStationDB.Database;
using PetrolStationDB.Database.Models;
using PetrolStationDB.Services;
using Microsoft.EntityFrameworkCore;

namespace PetrolStationDB.Controllers
{
    public class AuthorizationController
    {
        public User AuthToApp(string _login, string _pass)
        {
            User user = null;
            EncryptionText et = new EncryptionText();

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    var res = db.Users.FirstOrDefault(x => x.Login == _login && x.Password == et.ComputeSha256Hash(_pass));
                    if (res != null) user = res;
                }
            }
            catch
            {
                return null;
            }
            
            return user;
        }
    }
}
