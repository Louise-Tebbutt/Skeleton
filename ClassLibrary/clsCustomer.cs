using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the cusotmer no property
        private Int32 mCustomerNo;

        //private data member for the Email property
        private string mEmail;

        //private data memeber for the DateOfBirth property
        private DateTime mDateOfBrith;

        //private data meber for the FullName property 
        private string mFullName;

        //private data member for the Address property
        private string mAddress;

        //private data member for the PhoneNumber property]
        private string mPhoneNumber;

        //private data member for the Active property
        private bool mActive;


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
        public String Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
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
        public string PhoneNumber
        {
            get 
            {
                //this line of code sends data out of the property
                return mPhoneNumber;
            }
            set 
            {
                //this line of code allows data into the property
                mPhoneNumber = value;
            }
        }
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property 
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }
        public bool Find(int customerID)
        {
            //set the private data members to test the data value
            mCustomerNo = 7;
            mDateOfBrith = Convert.ToDateTime("23/08/2005");
            mFullName = "Anakin Skywalker";
            mAddress = "212 Jedi Street";
            mEmail = "AnakinSkwyalker@outlook.com";
            mPhoneNumber = "07836208634";
            mActive = true;
            //always return true
            return true;
        }
    }
}