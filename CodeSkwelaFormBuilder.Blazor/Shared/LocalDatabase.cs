using CodeSkwelaFormBuilder.Blazor.Shared.Models;

namespace CodeSkwelaFormBuilder.Blazor.Shared
{
    public class LocalDatabase : IDatabase
    {
        private List<Form> _forms = new List<Form>();

        public void Add(Form form)
        {
            _forms.Add(form);
        }

        public List<Form> GetAllForms()
        {
            return _forms;
        }
    }
}
