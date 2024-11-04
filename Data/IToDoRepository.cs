using TodoList.Models;

namespace TodoList.Data
{
    public interface IToDoRepository
    {
        List<ToDoItem> GetAll();
        void Add(ToDoItem item);
        void Complete(int id);
    }
}
