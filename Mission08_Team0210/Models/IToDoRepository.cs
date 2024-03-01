namespace Mission08_Team0210.Models
{
    public interface IToDoRepository
    {
        List<Task> Tasks { get; }

        public void AddTask(Task task);
    }
}
