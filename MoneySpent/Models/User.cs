using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoneySpent.Models
{
    [Table("UserDetails")]
    public class User
    {
        public int UserId { get; set; }
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public Int16 Age {  get; set; }
    
    }
}