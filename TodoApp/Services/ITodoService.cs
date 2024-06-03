namespace TodoApp.Services
{
    public interface ITodoService
    {
        public void Add(TodoItem item);
        public void Delete(TodoItem item);

        public IEnumerable<TodoItem> GetAll();
    }
}
