using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlazorForms.Pages.Example8
{
    public partial class MyInputNumber
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> AllOtherAttributes { get; set; }

        [Parameter]
        public Boolean AllowNegatives { get; set; } = false;

        [Parameter]
        public Boolean Arrows { get; set; } = true;

        [CascadingParameter]
        public EditContext EditContext { get; set; }

        [Parameter]
        public String Id { get; set; }

        public string Integerld => $"integer{Id}";

        [Parameter]
        public String Label { get; set; }

        public string Labeld => $"lbl{Id}";

        [Parameter]
        public Int32 Max { get; set; }

        [Parameter]
        public Int32 Min { get; set; }

        [Parameter]
        public Int32 Step { get; set; }

        [Parameter]
        public Int32 Value { get; set; }

        [Parameter]
        public EventCallback<Int32> ValueChanged { get; set; }

        [Parameter]
        public Expression<Func<Int32>> ValueExpression { get; set; }

        public override async Task SetParametersAsync(ParameterView parameters)
        {
            await base.SetParametersAsync(parameters);
            this.Max = parameters.GetValueOrDefault<Int32>(nameof(this.Max), Int32.MaxValue);
            this.Min = parameters.GetValueOrDefault<Int32>(nameof(this.Min), this.AllowNegatives ? Int32.MinValue : 0);
            this.Step = parameters.GetValueOrDefault<Int32>(nameof(this.Step), 1);
        }
    }
}