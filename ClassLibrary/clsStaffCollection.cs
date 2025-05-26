using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        public List<clsStaff> StaffList
        {
            get
            {
                // Return the private data
                return mStaffList;
            }
            set
            {
                // Set the private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                // Return the count of the list
                return StaffList.Count;
            }
            set
            {
                // later
            }
        }

        public clsStaff ThisStaff { get; set; }

        // Constructor for the class
        public clsStaffCollection()
        {
            // Variable for the index
            Int32 Index = 0;

            // Variable to store the record count
            Int32 RecordCount = 0;

            // Object for the data connect
            clsDataConnection DB = new clsDataConnection();

            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");

            // Get the count of record
            RecordCount = DB.Count;

            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank address
                clsStaff AnStaff = new clsStaff();

                // Read in the fields for the current records
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AnStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AnStaff.StaffPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["StaffPhoneNumber"]);
                AnStaff.StaffSalary = Convert.ToDecimal(DB.DataTable.Rows[Index]["StaffSalary"]);
                AnStaff.JoinDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["JoinDate"]);
                AnStaff.MorePermissions = Convert.ToBoolean(DB.DataTable.Rows[Index]["MorePermissions"]);

                // Add the record to the private data member
                mStaffList.Add(AnStaff);

                // Point at the next record
                Index++;

            }
        }
    }
}