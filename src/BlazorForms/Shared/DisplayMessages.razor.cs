using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorForms.Shared
{
    public partial class DisplayMessages
    {
        [Parameter]
        public IEnumerable<String> Messages { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            Messages ??= new List<String>();
        }
    }
}
