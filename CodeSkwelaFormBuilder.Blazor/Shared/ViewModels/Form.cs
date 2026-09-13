using CodeSkwelaFormBuilder.Blazor.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Reflection.Emit;
using System.Text.Json;

namespace CodeSkwelaFormBuilder.Blazor.Shared.ViewModels
{
    public class Form
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<FormControl> Controls { get; set; } = new List<FormControl>();
    }

    public class FormControl : IFormControlSerializer
    {
        public Guid Id { get; set; }
        public Guid FormId { get; set; }
        public string Type { get; set; }
        public Dictionary<string, object> Parameters { get; set; }
        public string[] DataParameterNames { get; set; }
        public Models.FormControl Data { get; set; }

        public static Dictionary<string, object> Deserialize(string serializedParameters)
        {
            return new Dictionary<string, object>();
        }

        public string Serialize()
        {
            var dataParameters = Parameters.Where(x => DataParameterNames.Contains(x.Key)).ToDictionary(x => x.Key, x => x.Value);
            var result = JsonSerializer.Serialize(dataParameters);

            return result;
        }

        public void UpdateParameters(Dictionary<string, object> newParameters)
        {
            this.Parameters = newParameters;
        }
    }
}
