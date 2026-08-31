using CodeSkwelaFormBuilder.Blazor.Shared.Models;

namespace CodeSkwelaFormBuilder.Blazor.Shared
{
    public interface IDatabase
    {
        void Add(Form form);
        List<Form> GetAllForms();
        Form GetFormById(Guid id);
        void Update(Form formData);
    }
}
