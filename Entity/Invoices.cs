using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Invoices
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public bool Active { get; set; }

        // Relación con Customer
        public Customer Customer { get; set; }

        // Relación con InvoiceDetails
        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
