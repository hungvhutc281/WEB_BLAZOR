
namespace TodoApp.Services
{
    public class TodoService : ITodoService
    {
        private readonly IList<TodoItem> _todoItems;

        public TodoService()
        {
            _todoItems = new List<TodoItem>()
            {
                new TodoItem("Helo"),
                new TodoItem("ok")
            };
        }
        public void Add(TodoItem item)
        {
         _todoItems.Add(item);
        }

        public void Delete(TodoItem item)
        {
            _todoItems.Remove(item);
        }

        public IEnumerable<TodoItem> GetAll()
        {
          return _todoItems.ToList();
        }
        public void Remove(TodoItem item)
        {

            _todoItems.Remove(item);
        }
    }
}
