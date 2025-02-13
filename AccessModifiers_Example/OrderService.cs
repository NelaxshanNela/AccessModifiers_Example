namespace AccessModifiers_Example
{
    public class OrderService
    {
        public BaseOrder GetOrder()
        {
            return new BaseOrder();
        }

        public string GetOrderStatus()
        {
            BaseOrder order = new BaseOrder();
            return order.OrderStatus;  // ✅ Accessible (internal)
        }
    }
}
