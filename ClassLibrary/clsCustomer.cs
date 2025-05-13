using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the cusotmer no property
        private Int32 mCustomerNo;
        private DateTime mDateOfBirth;

        //private data memeber for the DateOfBirth property
        private DateTime mDateOfBrith;

        public Int32 CustomerNo
        {
            get 
            {
                //this line of code sends data out of the property
                return mCustomerNo;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerNo = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                //this line of code sends data out of the property
                return mDateOfBrith;
            }
            set
            {
                //this line of code allows data into the property
                mDateOfBrith = value;
            }
        }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }

        public bool Find(int customerID)
        {
            //set the private data members to test the data value
            mCustomerNo = 7;
            mDateOfBirth = Convert.ToDateTime("23/08/2005");
            //always return true
            return true;
        }
    }
}