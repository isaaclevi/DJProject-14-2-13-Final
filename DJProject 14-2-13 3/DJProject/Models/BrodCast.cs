using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DJProject.Models
{


    [Table("BrodCast")]
    public class BrodCast
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int BrodCastId { get; set; }
        [Required]
        [Display(Name = "שם השידור")]
        public string BordCastName { get; set; }
        [Required]
        [Display(Name = "תאריך התחלה")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "תאריך סיום")]
        public DateTime EndDate { get; set; }


    }

}