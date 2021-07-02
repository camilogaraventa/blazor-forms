using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlazorForms.Pages.Example8
{
    public partial class MyInputPassword
    {
        private bool _hidePassword = true;

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> AllOtherAttributes { get; set; }

        [CascadingParameter]
        public EditContext EditContext { get; set; }

        [Parameter]
        public String Id { get; set; }

        [Parameter]
        public String Label { get; set; }

        public string Labeld => $"lbl{Id}";

        [Parameter]
        public String Name { get; set; }

        public string Txtld => $"txt{Id}";

        [Parameter]
        public string Value { get; set; }

        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }

        [Parameter]
        public Expression<Func<String>> ValueExpression { get; set; }

        private async Task RevealPassword()
        {
            _hidePassword = false;
            await Task.Delay(700);
            _hidePassword = true;
        }
    }
}