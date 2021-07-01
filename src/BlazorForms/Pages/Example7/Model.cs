using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorForms.Pages.Example7
{
    public class Model
    {
        public Model()
        {
            Nested = new NestedModel();
        }
        
        public int Age { get; set; }

        public string Name { get; set; }

        public NestedModel Nested { get; set; }
    }

    public class NestedModel
    {
        public String Address { get; set; }
    }
}
