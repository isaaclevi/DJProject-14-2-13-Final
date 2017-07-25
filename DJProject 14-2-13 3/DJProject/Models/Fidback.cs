using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DJProject.Models
{

    [Table("Fidback")]
    public class Fidback
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        public string Commant { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public int BrodCastId { get; set; }
    }
}