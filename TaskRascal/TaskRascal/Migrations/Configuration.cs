using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using TaskRascal.Models;
using TaskRascal.Models.Helpers;
using WebMatrix.WebData;

namespace TaskRascal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<TaskRascal.Models.TRContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TaskRascal.Models.TRContext context)
        {
            //init database
            WebSecurity.InitializeDatabaseConnection(
               "DefaultConnection",
               "UserProfile",
               "UserId",
               "UserName", autoCreateTables: true);


            #region UserManagement

            //seed default Roles
            AddRoles(context);
            context.SaveChanges();

            //Seed default users
            AddUsers(context);
            context.SaveChanges();

            #endregion

        }

        public void AddRoles(TRContext context)
        {
            var role = TRRoles.GetAllRoles();
            foreach (String r in role)
            {
                if (!Roles.RoleExists(r))
                {
                    Roles.CreateRole(r);
                }

            }
        }

        public void AddUsers(TRContext context)
        {
            //Seed default users
            var users = Data.UserList;
            foreach (var u in users)
            {
                string token;
                if (!WebSecurity.UserExists(u.username))
                {
                    token = WebSecurity.CreateUserAndAccount(
                     u.username,
                     u.password,
                     new
                     {
                         FirstName = u.firstName,
                         LastName = u.lastName,
                         AddressLine1 = "",
                         AddressLine2 = "",
                         City = "",
                         ZipCode = "",
                         Country = "",
                         PhoneNumber = "",
                         Active = false,
                         ForcePasswordSwitch = false,
                         HasAgreedToTermsOfService = false,
                     });
                    WebSecurity.ConfirmAccount(token);
                }
                //Seed default Users In Roles
                foreach (var role in u.roles.Where(role => !Roles.GetRolesForUser(u.username).Contains(role)))
                {
                    Roles.AddUsersToRole(new[] { u.username }, role);
                }
            }
            context.SaveChanges();
        }

        public class user
        {
            public String username { get; set; }
            public String password { get; set; }
            public String firstName { get; set; }
            public String lastName { get; set; }
            public List<string> roles { get; set; }

            public user(string u, string p, List<string> r, string f, string l)
            {
                this.username = u;
                this.password = p;
                this.roles = r;
                this.firstName = f;
                this.lastName = l;
            }

        }
    }
}