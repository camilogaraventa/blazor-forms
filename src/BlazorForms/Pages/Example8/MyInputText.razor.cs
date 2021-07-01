using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BlazorForms.Pages.Example8
{
    public partial class MyInputText
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> AllOtherAttributes { get; set; }

        [CascadingParameter]
        public EditContext EditContext { get; set; }

        [Parameter]
        public String Id { get; set; }

        [Parameter]
        public String Label { get; set; }

        [Parameter]
        public String Name { get; set; }

        [Parameter]
        public string Placeholder { get; set; }

        [Parameter]
        public string Value { get; set; }

        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }

        [Parameter]
        public Expression<Func<String>> ValueExpression { get; set; }

        private string Labeld => $"lbl{Id}";

        private string Txtld => $"txt{Id}";
    }
}