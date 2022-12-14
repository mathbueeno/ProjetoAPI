
namespace Todo.Domain.Entities
{
    public class TodoItem : Entity
    {
        public TodoItem(string title, DateTime date, string user)
        {
            Title = title;
            Done= false;
            Date = date;
            User = user;
        }

        public TodoItem(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }

        // Private só a própria classe consegue se modificar.
        public string Title { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; private set; }

        // Marcar como concluido
        public void MarkAsDone() 
        {
            Done = true;
        }

        public void MarkAsUndone() 
        {
            Done = false;
        }

        public void UpdateTitle(string title)
        {
            Title = title;
        }

    }
}