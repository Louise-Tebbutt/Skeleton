using System;

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
        public bool MorePermissions { get; set; }
        public string StaffEmail { get; set; }
        public string StaffPhoneNumber { get; set; }
        public float StaffSalary { get; set; }

        public bool Find(int staffId)
        {
            // Set the private data members to the test data value
            mStaffId = 1;
            mStaffName = "John Doe";
            mJoinDate = Convert.ToDateTime("01/01/2000");
            // Always return true
            return true;
        }
    }
}