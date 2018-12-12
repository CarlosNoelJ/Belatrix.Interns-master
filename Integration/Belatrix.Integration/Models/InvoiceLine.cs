namespace Belatrix.Integration.Models
{
    public class InvoiceLine
    {
        public int invoiceLineId { get; set; }
        public int invoiceId { get; set; }
        public int trackId { get; set; }
        public double unitPrice { get; set; }
        public int quantity { get; set; }
    }
}
