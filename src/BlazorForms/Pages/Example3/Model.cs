using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorForms.Pages.Example3
{
    public class Model
    {
        public Model()
        {
            Nested = new NestedModel();
        }
        
        [Range(18, 80, ErrorMessage = "Age must be between 18 and 80.")]
        public int Age { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public NestedModel Nested { get; set; }
    }

    public class NestedModel
    {
        [StringLength(50)]
        [Required]
        public String Adress { get; set; }
    }
}
