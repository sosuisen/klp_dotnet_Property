namespace Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            var todo1 = new ToDo(1, "Write code", new DateTime(2022, 3, 7), false);
            // or omit constructor name
            var todo2 = new ToDo(2, "Test code", new DateTime(2022, 3, 8), false);

            // Get a property
            Console.WriteLine(todo1.Id);
        }
    }
}