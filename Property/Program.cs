namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Can use var
            var order1 = new Order(1, "Alan Kay", new DateTime(2022, 2, 2));
            // or omit constructor name
            Order order2 = new (2, "Ted Nelson", new DateTime(2022, 3, 7));

            order1.DisplayOrder();
            order2.DisplayOrder();

            // Set a property
            order2.CustomerName = "Douglas Engelbart";
            order2.DisplayOrder();

            // Get a property
            Console.WriteLine(order2.OrderId);
        }
    }
}