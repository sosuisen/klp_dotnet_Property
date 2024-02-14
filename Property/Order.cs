namespace Property
{
    internal class Order(int orderId, string customerName, DateTime dateTime)
    {
        public int OrderId { get; set; } = orderId;
        public string CustomerName { get; set; } = customerName;
        public DateTime OrderDate { get; set; } = dateTime;

        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {OrderId}, Customer: {CustomerName}, Date: {OrderDate.ToShortDateString()}");
        }
    }
}
