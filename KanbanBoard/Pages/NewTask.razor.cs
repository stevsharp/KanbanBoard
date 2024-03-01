using Microsoft.AspNetCore.Components;

namespace KanbanBoard.Pages
{
    public partial class NewTask
    {
        private string? taskName;

        private ElementReference taskInput;

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object>? InputParameters { get; set; }

        [Parameter]
        public EventCallback<string> OnSubmit { get; set; }

        private async Task OnClickHandlerAsync()
        {
            if (string.IsNullOrWhiteSpace(taskName))
            {
                return;
            }

            await OnSubmit.InvokeAsync(taskName);

            taskName = null;

            await taskInput.FocusAsync();
        }
    }
}
