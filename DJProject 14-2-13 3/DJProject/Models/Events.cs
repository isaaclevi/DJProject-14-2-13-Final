using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DJProject.Models
{
    [Table("Events")]
    public class Events
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }
        [Required]
        [Display(Name = "שם האירוע")]
        public string EventName { get; set; }
        [Required]
        [Display(Name = "תאריך")]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "תיאור")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "מקום")]
        public string Plase { get; set; }
    }


    public class EventSearch
    {
        public int EventId { get; set; }

        public string EventName { get; set; }

        public DateTime? Date { get; set; }

        public string Description { get; set; }

        public string Plase { get; set; }
    }
}