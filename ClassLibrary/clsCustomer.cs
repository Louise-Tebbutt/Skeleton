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
        /*** FIND METHOD ***/
        public bool Find(int CustomerNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer number to seach for
            DB.AddParameter("@CustomerNo",  CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found (there should be either one or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data mebers
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDateOfBrith = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return flase indicating there is a problem
                return false;
            }
        }
    }
}