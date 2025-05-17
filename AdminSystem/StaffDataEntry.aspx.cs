using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        // Create a new instance of class staff
        clsStaff AnStaff = new clsStaff();

        // Capture the staff Id
        AnStaff.StaffId = Convert.ToInt32(txtStaffId.Text);

        // Capture the staff name
        AnStaff.StaffName = txtStaffName.Text;

        // Capture the staff join date
        AnStaff.JoinDate = Convert.ToDateTime(DateTime.Now);

        // Capture the staff email
        AnStaff.StaffEmail = txtStaffEmail.Text;

        // Capture the staff phone number
        AnStaff.StaffPhoneNumber = txtStaffPhoneNumber.Text;

        // Capture the staff salary
        AnStaff.StaffSalary = Convert.ToSingle(txtStaffSalary.Text);

        // Capture the staff permissions
        AnStaff.MorePermissions = chkMorePermissions.Checked;

        // Store the ID in the session
        Session["AnStaff"] = AnStaff;

        // Send user to the view page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the staff class
        clsStaff AnStaff = new clsStaff();

        // Create a variable to store the primary key
        Int32 StaffId;

        // Create a variable to store the result of the find operation
        Boolean found = false;

        // Get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);

        // Find the record
        found = AnStaff.Find(StaffId);

        // If found
        if (found == true)
        {
            // Display the values of the properties in the form
            txtStaffName.Text = AnStaff.StaffName;
            txtJoinDate.Text = AnStaff.JoinDate.ToString();
            txtStaffEmail.Text = AnStaff.StaffEmail;
            txtStaffPhoneNumber.Text = AnStaff.StaffPhoneNumber;
            txtStaffSalary.Text = AnStaff.StaffSalary.ToString();
            chkMorePermissions.Checked = AnStaff.MorePermissions;


        }
    }
}