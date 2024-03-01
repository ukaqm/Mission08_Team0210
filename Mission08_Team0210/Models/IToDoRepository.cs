namespace Mission08_Team0210.Models
{
    public interface IToDoRepository
    {
        List<Task> Tasks { get; }
        List<Category> Categories { get; }

        public void AddTask(Task task);
        public void Edit(Task task);
        public void Delete(Task task);
    }
}
