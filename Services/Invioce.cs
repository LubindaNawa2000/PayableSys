public class Invoice
{
    public int InvoiceId { get; set; } // Primary key
    public string InvoiceNumber { get; set; }
    public int VendorID { get; set; }
    public DateTime InvoiceDate { get; set; }
    public decimal InvoiceAmount { get; set; }
}