using CodeSkwelaFormBuilder.Blazor.Shared.Models;

namespace CodeSkwelaFormBuilder.Blazor.Shared
{
    public class LocalDatabase : IDatabase
    {
        private List<Form> _forms = new List<Form>();

        public void Add(Form form)
        {
            form.Id = Guid.NewGuid();
            foreach (var control in form.Controls)
            {
                control.Id = Guid.NewGuid();
                control.FormId = form.Id;
            }

            _forms.Add(form);
        }

        public List<Form> GetAllForms()
        {
            return _forms.Select(x => new Form { Id = x.Id, Name = x.Name }).ToList();
        }

        public Form GetFormById(Guid id)
        {
            if (id == Guid.Empty) return null;
            

            return _forms.FirstOrDefault(f => f.Id == id);
        }

        public void Update(Form form)
        {
            var existingForm = _forms.FirstOrDefault(f => f.Id == form.Id);
            if (existingForm != null)
            {
                existingForm.Name = form.Name;

                existingForm.Controls.Clear();

                foreach (var control in form.Controls)
                {
                    control.Id = Guid.NewGuid();
                    control.FormId = existingForm.Id;
                    existingForm.Controls.Add(control);
                }
            }
        }
    }
}
