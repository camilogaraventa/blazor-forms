using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorForms.Pages.Example3
{
    public partial class FormWithDataAnnotationsValidator
    {
        private Model _model;
        private List<String> _messages;

        protected override void OnInitialized()
        {
            _model = new Model();
            _messages = new List<String>();
        }

        private async Task OnValidFormSubmit()
        {
            await Task.Delay(1000);
            _messages.Add($"{DateTime.Now} valid form submitted.{Environment.NewLine}{JsonSerializer.Serialize(_model, new JsonSerializerOptions() { WriteIndented = true })}");
        }

        private void OnInvalidFormSubmit(EditContext editContext)
        {
            _messages.Add($"{DateTime.Now} invalid form submitted.{Environment.NewLine}{String.Join(Environment.NewLine,editContext.GetValidationMessages())}");
        }
    }
}
