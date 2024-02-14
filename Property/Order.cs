namespace Property
{
    internal class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int orderId, string customerName, DateTime dateTime)
        {
            OrderId = orderId;
            CustomerName = customerName;
            OrderDate = dateTime;
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {OrderId}, Customer: {CustomerName}, Date: {OrderDate.ToShortDateString()}");
        }
    }
}