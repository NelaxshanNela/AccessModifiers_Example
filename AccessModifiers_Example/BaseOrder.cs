namespace AccessModifiers_Example
{
    public class BaseOrder
    {
        public int OrderId { get; set; }  // Accessible anywhere
        private decimal TotalAmount { get; set; }  // Only accessible inside this class
        protected string CustomerName { get; set; }  // Accessible in derived classes
        internal DateTime OrderDate { get; set; }  // Accessible within the same assembly
        protected internal string OrderStatus { get; set; }  // Accessible in derived classes and within the same assembly
        private protected string InternalNotes { get; set; }  // Accessible in derived classes but only in the same assembly

        public BaseOrder()
        {
            OrderId = 1;
            TotalAmount = 250.75m;
            CustomerName = "John Doe";
            OrderDate = DateTime.Now;
            OrderStatus = "Pending";
            InternalNotes = "Urgent Delivery";
        }

        public decimal GetTotalAmount()  // Public method to access private property
        {
            return TotalAmount;
        }
    }
}
