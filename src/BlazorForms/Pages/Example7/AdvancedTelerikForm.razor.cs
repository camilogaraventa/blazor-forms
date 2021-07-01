using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorForms.Pages.Example7
{
    public partial class AdvancedTelerikForm
    {
        private Model _model;
        private List<String> _messages;

        protected override void OnInitialized()
        {
            _model = new Model();
            _messages = new List<String>();
        }

        private Task OnValidFormSubmit()
        {
            _messages.Add($"{DateTime.Now} valid form submitted.{Environment.NewLine}{JsonSerializer.Serialize(_model, new JsonSerializerOptions() { WriteIndented = true })}");
            return Task.CompletedTask;
        }

        private void OnInvalidFormSubmit(EditContext editContext)
        {
            _messages.Add($"{DateTime.Now} invalid form submitted.{Environment.NewLine}{String.Join(Environment.NewLine, editContext.GetValidationMessages())}");
        }

        private void InitializeModel()
        {
            _model = new Model
            {
                Age = 35,
                Name = "model name",
                Nested = new NestedModel
                {
                    Address = "model adress"
                }
            };
        }
    }
}
