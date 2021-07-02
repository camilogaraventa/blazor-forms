using BlazorFormsNetHosted.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFormsNetHosted.Client.Pages
{
    public partial class Index
    {
        private SampleDto _model;

        protected override void OnInitialized()
        {
            _model = new SampleDto();
        }
    }
}
