using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskRascal.Migrations
{
    public class Data
    {
        public static IEnumerable<Configuration.user> UserList
        {
            get
            {
                return new List<Configuration.user>(){ 
                    new Configuration.user("admin@tr.com", "password", TaskRascal.Models.Helpers.TRRoles.GetAllRoles(), "Super", "User"),
                    new Configuration.user( "user@tr.com", "password", new List<string>(){TaskRascal.Models.Helpers.TRRoles.UserSystemName} , "User", "Smith")
                };
            }
        }
    }
}