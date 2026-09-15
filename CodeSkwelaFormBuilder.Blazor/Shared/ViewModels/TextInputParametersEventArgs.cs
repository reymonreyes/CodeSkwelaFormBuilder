using CodeSkwelaFormBuilder.Blazor.Components.FormControls;

namespace CodeSkwelaFormBuilder.Blazor.Shared.Models
{
    public class TextInputParametersEventArgs
    {
        public FormControl? ControlData { get; set; }
        public Guid ControlId { get; set; }
    }
}
