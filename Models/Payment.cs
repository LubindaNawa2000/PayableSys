public class Payment
{
    public int PaymentId { get; set; } // Primary key
    public int InvoiceId { get; set; } // Foreign key
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; }
    public decimal PaymentAmount { get; set; }

    public Invoice Invoice { get; set; } // Navigation property
}