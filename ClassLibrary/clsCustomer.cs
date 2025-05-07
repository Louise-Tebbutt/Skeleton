using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerNo;

        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
    }
}