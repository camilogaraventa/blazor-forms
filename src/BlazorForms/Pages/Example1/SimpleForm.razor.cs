using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorForms.Pages.Example1
{
    public partial class SimpleForm
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
            _messages.Add($"{DateTime.Now} form submitted. Valid: {editContext.Validate()}");
        }
    }
}
