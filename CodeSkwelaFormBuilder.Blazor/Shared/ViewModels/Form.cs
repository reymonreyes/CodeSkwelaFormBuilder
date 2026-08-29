using CodeSkwelaFormBuilder.Blazor.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace CodeSkwelaFormBuilder.Blazor.Shared.ViewModels
{
    public class Form
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<FormControl> Controls { get; set; } = new List<FormControl>();
    }

    public class FormControl
    {
        public Guid Id { get; set; }
        public Guid FormId { get; set; }
        public string Type { get; set; }
        public Dictionary<string, object> Parameters { get; set; }
        public DynamicComponent? ControlReference { get; set; }
    }
}
