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
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
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

        public string Valid(string email, string dateOfBirth, string fullName, string address)
        {
            return "";
        }

        public string Valid(int customerNo, string email, string dateOfBirth, string fullName, string address, string phoneNumber)
        {
            //create an string variable to store the error
            String Error = "";
            //create a tempary variable to store the date values
            DateTime DateTemp;
            //if the CustomerNo is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be left blank :";
            }
            if (email.Length > 50) 
            {
                //record the error
                Error = Error + "The email must be less than 50 characters :";
            }
            if (fullName.Length < 1) 
            {
                //record the error
                Error = Error + "The full name must not be left blank";
            }
            if (fullName.Length > 50) 
            {
                //record the error
                Error = Error + "The FullName must be less than 50 characters";
            }

            if (address.Length < 1) 
            {
                //record the error
                Error = Error + "The address must not be left blank";
            }

            if (address.Length > 50)
            {
                //record the error
                Error = Error + "The address must be less than 50 chracters";
            }

            if (phoneNumber.Length < 1)
            {
                //record the error
                Error = Error + "The phone number must not be left blank";
            }

            if (phoneNumber.Length > 15)
            {
                //record the error
                Error = Error + "The phone number must be less than 15 chracters";
            }

            //create an instace of DateTime to compare with DateOfBirth
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);

                //check to see if the data is less than 100 years before todays date
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    Error = Error + "The data cannot be over 100 years ago : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The data cannot be in the future : ";
                }
            }
            catch 
            {
                //record tge error
                Error = Error + "The data was not a valid date : ";
            }
            //return any error messages
            return Error;
        }

    }
}
