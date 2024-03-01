using KanbanBoard.Models;
using Microsoft.AspNetCore.Components;

namespace KanbanBoard.Pages
{
    public partial class Dropzone
    {
        [Parameter]
        public List<TaskItem> TaskItems { get; set; } = new();
        
        [Parameter]
        public TaskPriority Priority { get; set; }

        [Parameter]
        public EventCallback<TaskPriority> OnDrop { get; set; }

        [Parameter]
        public EventCallback<TaskItem> OnStartDrag { get; set; }


        private void OnDropHandler()
        {
            OnDrop.InvokeAsync(Priority);
        }

        private void OnDragStartHandler(TaskItem task)
        {
            OnStartDrag.InvokeAsync(task);
        }
    }
}
