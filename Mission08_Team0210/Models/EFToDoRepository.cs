using Microsoft.AspNetCore.Mvc;

namespace Mission08_Team0210.Models
{
    public class EFToDoRepository : IToDoRepository
    {
        private ToDoListContext _context;
        public EFToDoRepository(ToDoListContext context) 
        {
            _context = context;
        }
        public List<Task> Tasks => _context.Tasks.ToList();

        public List<Category> Categories => throw new NotImplementedException();

        public void AddTask(Task task)
        {
            _context.Add(task);
            _context.SaveChanges();
        }
        public void Edit(Task task)
        {
            _context.Update(task);
            _context.SaveChanges();
        }
        public void Delete(Task task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }
    }
}
