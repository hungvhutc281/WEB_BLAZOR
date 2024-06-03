namespace TodoApp.Pages
{
    public partial class Index
    {

    private IList<TodoItem> Todos { get; set; } = new List<TodoItem>();
        protected override void OnInitialized()
        {
            Todos = _todoService.GetAll().ToList();
        }

        public string ItemClass(TodoItem item)
        {
            return item.Completed ? "item-completed" : "";
        }

        public void ItemsChanged()
        {
            Todos = _todoService.GetAll().ToList();
            StateHasChanged();
        }

        public void DeleteItem(TodoItem item)
        {
            _todoService.Delete(item);
            ItemsChanged();
        }


    
}
}
