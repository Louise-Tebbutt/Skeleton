using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class ClsOrder
    {
        public DateTime DateAdded;

        public bool Active { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public bool PaymentStatus { get; set; }
        public string ShippingAddress { get; set; }
        public int StaffId { get; set; }
    }
}