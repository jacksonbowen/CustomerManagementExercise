namespace CM.BusinessLogic
{
  public class OrderItem
  {
    public OrderItem()
    {

    }
    public OrderItem(int orderItemId)
    {
      OrderItemId = orderItemId;
    }

    public int OrderItemId { get; private set; }
    public int ProductId { get; set; }
    public decimal? PurchasePrice { get; set; }
    public int Quantity { get; set; }

    // Validates the order item data.
    public bool Validate()
    {
      var isValid = true;

      if (Quantity <= 0) isValid = false;
      if (ProductId <= 0) isValid = false;
      if (PurchasePrice == null) isValid = false;

      return isValid;
    }
  }
}
