namespace assignment3;

public class Cart
{
    public int CartID { get; set; }
    public int CustomerID { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();
    public int Quantity { get; set; }
}