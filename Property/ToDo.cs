namespace Syntax
{
    internal class ToDo(int id, string name, DateTime deadline, bool completed)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public DateTime Deadline { get; set; } = deadline;
        public bool Completed { get; set; } = completed;
    }
}