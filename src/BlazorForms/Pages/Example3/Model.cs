using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorForms.Pages.Example3
{
    public class Model
    {
        [Range(18, 80, ErrorMessage = "Age must be between 18 and 80.")]
        public int Age { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
