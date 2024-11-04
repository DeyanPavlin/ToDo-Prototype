using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [Required]
        public string Task { get; set; }
    }
}
