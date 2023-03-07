using Core.Helper;
using Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Data
{
    public static class DbInitialiizer
    {
        static int id;

        public static void SeedAdmins()
        {
            
            var admins = new List<Admin>
            {
                new Admin
                {
                    Id = ++id,
                    Username= "admin",
                    Password= PasswordHasher.Encrypt("12345678"),
                },
                new Admin
                {
                    Id = ++id,
                    Username= "adminka",
                    Password= PasswordHasher.Encrypt("12345678"),
                },
                new Admin
                {
                    Id = ++id,
                    Username = "adminka2",
                    Password = PasswordHasher.Encrypt("12345678")
                }
            };
            DbContext.Admins.AddRange(admins);
        }
    }
}
