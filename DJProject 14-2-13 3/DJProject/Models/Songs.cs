using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DJProject.Models
{
    
    [Table("Songs")]
    public class Songs
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int SongsID { get; set; }
        [Required]
        [Display(Name = "שם השיר")]
        public string SongName { get; set; }
        [Required]
        [Display(Name = "נתיב")]
        public string Path { get; set; }
        [Required]
        [Display(Name = "תאריך העלה")]
        public DateTime UpLoadDate { get; set; }
        [Required]
        [Display(Name = "סוג השיר")]
        public string SongType { get; set; }
    }
}