using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSandbox {
    public class User {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Salt { get; set; }

        public override string ToString() => $"{UserId}: {UserName}";
    }
}
