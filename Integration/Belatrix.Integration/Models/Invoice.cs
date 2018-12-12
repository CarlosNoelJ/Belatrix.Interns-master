using System;

namespace Belatrix.Integration.Models
{
    public class Invoice
    {
        public int invoiceId { get; set; }
        public int customerId { get; set; }
        public DateTime invoiceDate { get; set; }
        public string billingAddress { get; set; }
        public string billingCity { get; set; }
        public string billingState { get; set; }
        public string billingCountry { get; set; }
        public string billingPostalCode { get; set; }
        public double total { get; set; }
    }
}
