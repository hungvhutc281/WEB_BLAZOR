using Microsoft.AspNetCore.Components;

namespace TodoApp.Pages
{
    public partial class TodoItemForm
    {

        [Parameter]
        public /* required */ Action OnItemAdded { get; set; }

        private TodoItem NewItem = new TodoItem("");

        public void ItemAdded()
        {
            var newItem = new TodoItem(NewItem.Text);
            NewItem.Text = "";
            _todoService.Add(newItem);

            if (OnItemAdded != null)
            {
                OnItemAdded();
            }
        }

    }
}
