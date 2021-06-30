using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorForms.Pages.Example2
{
    public class Model
    {
        public bool Active { get; set; }
        public DateTime? JoinDate { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; } = Category.Active;
    }

    public enum Category
    {
        Pending,
        Active,
        Suspended
    }
}
