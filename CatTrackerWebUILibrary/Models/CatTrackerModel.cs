using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CatTrackerWebUILibrary.Models
{

    public class CatTrackerModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "Breed is too long.")]
        public string Breed { get; set; }

        [StringLength(20, ErrorMessage = "Color is too long.")]
        public string Color { get; set; }
    }
}
