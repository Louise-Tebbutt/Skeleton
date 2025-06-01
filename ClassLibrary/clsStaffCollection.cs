using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();

        clsStaff mThisStaff = new clsStaff();
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

        public clsStaff ThisStaff
        {
            get
            {
                //Return the private member-
                return mThisStaff;
            }
            set
            {
                //Set the private member
                mThisStaff = value;
            }
        }

        // Constructor for the class
        public clsStaffCollection()
        {
            // Object for the data connect
            clsDataConnection DB = new clsDataConnection();

            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");

            // Populate the array list with the data table
            PopulateArray(DB);

        }

        public int Add()
        {
            // Adds a record to the database based on the values of mThisStaff
            // connect to database
            clsDataConnection DB = new clsDataConnection();

            // Set the perameters for the stored procedure
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPhoneNumber", mThisStaff.StaffPhoneNumber);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@JoinDate", mThisStaff.JoinDate);
            DB.AddParameter("@MorePermissions", mThisStaff.MorePermissions);

            // Return the primary key of the record
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {

            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPhoneNumber", mThisStaff.StaffPhoneNumber);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@JoinDate", mThisStaff.JoinDate);
            DB.AddParameter("@MorePermissions", mThisStaff.MorePermissions);

            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            // Deletes the record pointed to by ThisStaff
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);

            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByStaffName(string StaffName)
        {
            // Filters the records based on a full or partial post code
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Send the Staff name parameter to the database
            DB.AddParameter("@StaffName", StaffName);

            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffName");

            // Populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // Populates the array list based on the data table in the paramter DB
            // Variable for the index
            Int32 Index = 0;

            // Variable to store the record count
            Int32 RecordCount;

            // Get the count of records
            RecordCount = DB.Count;

            // Clear the private array list
            mStaffList = new List<clsStaff>();

            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank address object
                clsStaff AnStaff = new clsStaff();

                // Read in the fields from the current record
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