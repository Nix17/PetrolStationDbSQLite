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
    public class ProfileController
    {
        public bool ChangePassword(ref User _user, string newPass)
        {
            bool result = false;

            Guid guid = _user.Id;

            User user = null;
            EncryptionText et = new EncryptionText();

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    user = db.Users.FirstOrDefault(u => u.Id == guid);
                    if (user != null)
                    {
                        user.Password = et.ComputeSha256Hash(newPass);
                        user.UpdatedBy = user.Login;
                        user.UpdatedDate = DateTime.Now;
                        db.Users.Update(user);
                        db.SaveChanges();

                        _user = db.Users.FirstOrDefault(u => u.Id == guid);
                        _user.Password = newPass;

                        result = true;
                    }
                }
            }
            catch
            {
                return false;
            }
            
            return result;
        }

        public List<User> ViewAllUsers()
        {
            List<User> users = null;

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    users = db.Users.ToList();
                }
            }
            catch
            {
                return null;
            }

            return users;
        }
    }
}
