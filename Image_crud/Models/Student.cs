using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Image_crud.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public  int salary { get; set; }
        public string image_path { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
