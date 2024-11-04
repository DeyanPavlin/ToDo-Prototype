using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using TodoList.Data;
using TodoList.Models;

namespace TodoList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IToDoRepository _todoRepository;

        public IndexModel()
        {
            _todoRepository = new ToDoRepository(); // Initialize your repository
        }

        public IList<ToDoItem> TodoItems { get; set; } = new List<ToDoItem>();

        public void OnGet()
        {
            TodoItems = _todoRepository.GetAll(); // Get all todos for the GET request
        }

        public IActionResult OnPostAdd(string task)
        {
            if (!string.IsNullOrEmpty(task))
            {
                var newTodo = new ToDoItem { Task = task};
                _todoRepository.Add(newTodo); // Add the new todo
            }
            return RedirectToPage(); // Redirect to the same page
        }

        public IActionResult OnPostComplete(int id)
        {
            _todoRepository.Complete(id); // Mark todo as complete
            return RedirectToPage(); // Redirect to the same page
        }
    }
}
