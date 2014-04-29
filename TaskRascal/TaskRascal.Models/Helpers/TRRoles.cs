using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRascal.Models.Helpers
{
    public class TRRoles
    {
        public const String AdminSystemName = "admin";
        public const String UserSystemName = "user";
        public const String ParentRole = "parent";
        public const String KidRole = "child";

        public static List<String> GetAllRoles()
        {
            return new List<string>() { AdminSystemName, UserSystemName, ParentRole, KidRole};
        }
    }
}
