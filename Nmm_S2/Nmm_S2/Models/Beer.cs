using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Nmm_S2.Models
{
    public class Beer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Beer names are limited to 50 characters.")]
        public string Name { get; set; }
        [Required]
        [Range(0.0,20.0, ErrorMessage ="ABV must be between 0.0 and 20.0")]
        public double ABV { get; set; }
        [Required]
        [Display (Name="Type of Beer")]
        public BeerType Type { get; set; }
        [Required]
        [Range(0.0,100.0,ErrorMessage = "IBV must be between 0.0 and 100.0")]
        public double IBU { get; set; } 
    }
}