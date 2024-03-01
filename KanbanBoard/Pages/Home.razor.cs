using KanbanBoard.Models;

namespace KanbanBoard.Pages
{
    public partial class Home
    {
        public TaskItem? CurrentItem;

        public List<TaskItem> TaskItems = new();

        public Dictionary<string, object> InputAttributes = new()
        {
            { "maxlength", "25" },
            { "placeholder", "enter new task" },
            { "title", "This textbox is for adding your tasks." }
        };

        protected override void OnInitialized()
        {
            TaskItems.Add(new TaskItem { TaskName = "Call Mom", Priority = TaskPriority.High });

            TaskItems.Add(new TaskItem { TaskName = "Buy milk", Priority = TaskPriority.Mid });

            TaskItems.Add(new TaskItem { TaskName = "Exercise", Priority = TaskPriority.Low });
        }

        private void OnStartDrag(TaskItem item) { CurrentItem = item; }

        private void OnDrop(TaskPriority priority) { CurrentItem!.Priority = priority; }

        private void AddTask(string taskName)
        {
            var taskItem = new TaskItem() { TaskName = taskName, Priority = TaskPriority.High };

            TaskItems.Add(taskItem);
        }
    }
}
