namespace assignment3;

public class Payment
{
    public int PaymentID { get; set; }
    public decimal PaymentAmount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; } // e.g., "OnlineCard", "PayPal", "GiftCard", "Blik"
}