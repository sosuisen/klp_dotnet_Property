namespace Property
{
    internal class Order
    {
        private int _orderId;
        private string _customerName;
        private DateTime _orderDate;

        public int OrderId { get { return _orderId; } set { _orderId = value; } }
        public string CustomerName { get { return _customerName; } set { _customerName = value; } }
        public DateTime OrderDate { get { return _orderDate; } set { _orderDate = value; } }

        public Order(int orderId, string customerName, DateTime dateTime)
        {
            _orderId = orderId;
            _customerName = customerName;
            _orderDate = dateTime;
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {OrderId}, Customer: {CustomerName}, Date: {OrderDate.ToShortDateString()}");
        }
    }
}