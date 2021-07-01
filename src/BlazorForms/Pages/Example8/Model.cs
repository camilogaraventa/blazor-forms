using System;

namespace BlazorForms.Pages.Example8
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
