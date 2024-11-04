using TodoList.Models;

namespace TodoList.Data
{
    public class ToDoRepository : IToDoRepository
    {
        private static List<ToDoItem> _todoItems = new List<ToDoItem>();
        private static int _nextId = 1;

        public void Add(ToDoItem item)
        {
            item.Id = _nextId++;
            _todoItems.Add(item);
        }

        public void Complete(int id)
        {
            var item = _todoItems.Find(i => i.Id == id);
            if (item != null)
            {
                _todoItems.Remove(item);
            }
        }

        public List<ToDoItem> GetAll()
        {
            return _todoItems;
        }
    }
}
