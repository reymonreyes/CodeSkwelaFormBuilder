namespace CodeSkwelaFormBuilder.Blazor.Shared.Models
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
        public string DataParameters { get; set; }
    }
}
