using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Image_crud.Models
{
    public class Employee
    {
        [Key]
        public int id{ get; set; }
        public string username { get; set; }
        public string gender { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string Confirmpassword { get; set; }
        
    }
}
