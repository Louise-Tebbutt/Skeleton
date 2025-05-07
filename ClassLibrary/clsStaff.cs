using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public DateTime JoinDate { get; set; }
        public bool MorePermissions { get; set; }
        public string StaffEmail { get; set; }
        public string StaffPhoneNumber { get; set; }
        public float StaffSalary { get; set; }
    }
}