namespace Syntax
{
    internal class ToDo(int id, string name, DateTime deadline, bool completed)
    {
        public int Id { get; } = id;
        public string Name = name;
        public DateTime Deadline = deadline;
        public bool Completed = completed;
    }
}