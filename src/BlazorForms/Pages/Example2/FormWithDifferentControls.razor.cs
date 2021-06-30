using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorForms.Pages.Example2
{
    public partial class FormWithDifferentControls
    {
        private Model _model;
        private List<String> _messages;

        protected override void OnInitialized()
        {
            _model = new Model();
            _messages = new List<string>();
        }

        private void FormSubmit(EditContext editContext)
        {
            _messages.Add($"{DateTime.Now} form submitted.{Environment.NewLine}{JsonSerializer.Serialize(_model,new JsonSerializerOptions(){WriteIndented=true})}");
        }
    }
}
