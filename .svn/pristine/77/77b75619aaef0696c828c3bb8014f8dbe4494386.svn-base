using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFcodeFirst.Models.Entities
{
    public class Contact
    {
        [Key]
        public int ID { set; get; }


        [StringLength(16)]
        [Required]
        public string Phone { set; get; }


        [StringLength(64)]
        [Required]
        public string Email { set; get; }


        [StringLength(50)]
        [Required]
        public string Name { set; get; }


        [StringLength(500)]
        [Required]
        public string Message { set; get; }
    }
}