using System;
using System.Linq;
using System.Linq.Expressions;

namespace ClassLibrary
{
    public class clsStaff
    {
        // Private data member for the staff id property
        private Int32 mStaffId;

        // StaffId public property
        public Int32 StaffId
        {
            get
            {
                // This line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                // This line of code allows data in to the property
                mStaffId = value;
            }
        }

        // Private data member for the staff name property
        private string mStaffName;

        // StaffId public property
        public string StaffName
        {
            get
            {
                // This line of code sends data out of the property
                return mStaffName;
            }
            set
            {
                // This line of code allows data in to the property
                mStaffName = value;
            }
        }

        // Private data member for the join data property
        private DateTime mJoinDate;

        // Join date public property
        public DateTime JoinDate
        {
            get
            {
                // This line of code sends data out of the property
                return mJoinDate;
            }
            set
            {
                // This line of code allows data in to the property
                mJoinDate = value;
            }
        }

        // Private data member for the more permissions property
        private Boolean mMorePermissions;

        // MorePermissions public property
        public Boolean MorePermissions
        {
            get
            {
                // This line of code sends data out of the property
                return mMorePermissions;
            }
            set
            {
                // This line of code allows data in to the property
                mMorePermissions = value;
            }

        }

        // Private data memnber for the staff email property
        private string mStaffEmail;

        // StaffEmail public property
        public string StaffEmail
        {
            get
            {
                // This line of code sends data out of the property
                return mStaffEmail;
            }
            set
            {
                // This line of code allows data in to the property
                mStaffEmail = value;
            }
        }

        // Private data member for the staff phone number property
        private string mStaffPhoneNumber;

        // StaffPhoneNumber public property
        public string StaffPhoneNumber
        {
            get
            {
                // This line of code sends data out of the property
                return mStaffPhoneNumber;
            }
            set
            {
                // This line of code allows data in to the property
                mStaffPhoneNumber = value;
            }
        }

        private Decimal mStaffSalary;

        public Decimal StaffSalary
        {
            get
            {
                // This line of code sends data out of the property
                return mStaffSalary;
            }
            set
            {
                // This line of code allows data in to the property
                mStaffSalary = value;
            }
        }

        //* Find Method *//
        public bool Find(int StaffId)
        {
            // Create a new instance of the data connection class
            clsDataConnection DB = new clsDataConnection();

            // Add the perameter for the staff id to search for
            DB.AddParameter("@StaffId", StaffId);

            // Exectute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");

            // if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mJoinDate = Convert.ToDateTime(DB.DataTable.Rows[0]["JoinDate"]);
                mMorePermissions = Convert.ToBoolean(DB.DataTable.Rows[0]["MorePermissions"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["StaffPhoneNumber"]);
                mStaffSalary = Convert.ToDecimal(DB.DataTable.Rows[0]["StaffSalary"]);
                // Return that everything worked ok
                return true;    
            }
            // if no record was found
            else
            {
                // return false indicating there was a problem
                return false;
            }
        }

        public string Valid(string staffSalary, string staffName, string joinDate, string staffEmail, string staffPhoneNumber, string morePermissions)
        {
            // Create a string variable to store the error
            String Error = "";

            // Create a variable to store date values
            DateTime TempDate;

            // StaffSalary
            try
            {
                decimal TempSalary = Convert.ToDecimal(staffSalary);

                if (TempSalary <= 0)
                {
                    Error = Error + "The salary must be higher than 0";
                }

                if (TempSalary >= 100000000)
                {
                    Error = Error + "The salary is too high! ";
                }
            }
            catch
            {
                Error = Error + "The salary is not a valid number";
            }

            // StaffName
            try
            {

                if (staffName.Length < 1)
                {
                    Error = Error + "The Staff Name must not be blank";
                }

                if (staffName.Length > 50)
                {
                    Error = Error + "The staff name must not be longer than 50 characters";
                }

                if (staffName.Any(char.IsDigit))
                {
                    Error = Error + "The staff name must not contain numbers";
                }
            }
            catch
            {
                Error = Error + "The staff name is invalid";
            }


            // JoinDate

            DateTime DateComp = DateTime.Now.Date;

            try
            {
                TempDate = Convert.ToDateTime(joinDate);

                if (TempDate < DateComp)
                {
                    Error = Error + "The date cant be in the past";
                }

                if (TempDate > DateComp)
                {
                    Error = Error + "The date cant be in the future";
                }
            }
            catch
            {
                Error = Error + "The date is incorrect";
            }

            return Error;


        }
    }
}