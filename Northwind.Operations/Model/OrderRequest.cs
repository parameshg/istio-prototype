using System;

namespace Northwind.Operations.Model
{
    public class OrderRequest
    {
        public Guid Id { get; set; }

        public Guid Product { get; set; }

        public int Quantity { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public string Zip { get; set; }

        public string Payment { get; set; }
    }
}