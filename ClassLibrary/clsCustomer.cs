using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the cusotmer no property
        private Int32 mCustomerNo;

        //private data memeber for the DateOfBirth property
        private DateTime mDateOfBrith;

        //private data meber for the FullName property 
        private string mFullName;

        //private data member for the Address property
        private string mAddress;

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

        public string FullName
        {
            get 
            {
                //this line of code sends data out of the property
                return mFullName;
            }
            set
            {
                //this line of code allows data into the property
                mFullName = value;
            }
        }

        public string Address
        {
            get
            {
                //this line of code send data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }

        public bool Find(int customerID)
        {
            //set the private data members to test the data value
            mCustomerNo = 7;
            mDateOfBrith = Convert.ToDateTime("23/08/2005");
            mFullName = "Anakin Skywalker";
            mAddress = "212 Jedi Street";
            //always return true
            return true;
        }
    }
}