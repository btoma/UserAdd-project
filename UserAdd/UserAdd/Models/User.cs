using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UserAdd.Models
{
    [Table("ADDUSER")]
    public class User
    {
        public int ID { get; set; }
        [Column("FIRSTNAME")]
        public string FirstName { get; set; }
        [Column("LASTNAME")]
        public string LastName { get; set; }
        [Column("PHONENUMBER")]
        public int? PhoneNumber { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("ADDRESSES")]
        public string Addresses { get; set; }

        // public string Image { get; set; }

    }

  
}