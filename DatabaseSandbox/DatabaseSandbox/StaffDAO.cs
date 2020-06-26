using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Quick.SQLInterface;
using System.Security.Cryptography;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.Win32;
using System.Data.Entity;

namespace DatabaseSandbox {
    public class StaffContext: DbContext {
        public DbSet<User> Users { get; set; }

        public StaffContext(): base("DBConnectionString") { }
    }

    public class StaffDAO: StaffContext {
        public void UseStaff() {
            using (var context = new StaffContext()) {
                IQueryable<User> list = context.Users;
                list.ToList().ForEach(staff => {
                    Console.WriteLine(staff);
                });
            }
        }
    }
}
