namespace AccessModifiers_Example
{
    public class RegularOrder : BaseOrder
    {
        public void PrintOrderDetails()
        {
            Console.WriteLine($"Order ID: {OrderId}");  // ✅ Accessible (public)
         // Console.WriteLine($"Total Amount: {TotalAmount}");  // ❌ Not accessible (private)
            Console.WriteLine($"Customer Name: {CustomerName}");  // ✅ Accessible (protected)
            Console.WriteLine($"Order Date: {OrderDate}");  // ✅ Accessible (internal)
            Console.WriteLine($"Order Status: {OrderStatus}");  // ✅ Accessible (protected internal)
         // Console.WriteLine($"Internal Notes: {InternalNotes}");  // ❌ Not accessible (private protected)
        }
    }
}
