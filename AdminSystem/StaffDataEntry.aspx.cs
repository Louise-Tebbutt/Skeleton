using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the address we processed
        StaffId = Convert.ToInt32(Session["StaffId"]);

        if (IsPostBack == false)
        {
            if (StaffId != -1)
            {
                DisplayStaff();
            }
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        // Create a new instance of class staff
        clsStaff AnStaff = new clsStaff();

        // Capture the staff Id
        txtStaffId.Text = Convert.ToString(StaffId);

        // Capture the staff name
        string StaffName = txtStaffName.Text;

        // Capture the staff join date
        string JoinDate = txtJoinDate.Text;

        // Capture the staff email
        string StaffEmail = txtStaffEmail.Text;

        // Capture the staff phone number
        string StaffPhoneNumber = txtStaffPhoneNumber.Text;

        // Capture the staff salary
        string StaffSalary = txtStaffSalary.Text;

        // Capture the staff permissions
        string MorePermissions = chkMorePermissions.Text;

        // Variable to store any error messages
        string Error = "";

        // invoke the method
        Error = AnStaff.Valid(StaffSalary, StaffName, JoinDate, StaffEmail, StaffPhoneNumber);

        // record info if no errors
        if (Error == "")
        {
            AnStaff.StaffId = StaffId;

            AnStaff.StaffName = StaffName;

            AnStaff.StaffEmail = StaffEmail;

            AnStaff.StaffPhoneNumber = StaffPhoneNumber;

            AnStaff.StaffSalary = Convert.ToDecimal(StaffSalary);

            AnStaff.JoinDate = Convert.ToDateTime(JoinDate);

            AnStaff.MorePermissions = chkMorePermissions.Checked;

            // Create an new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            if (StaffId == -1)
            {
                // Set the this staff property
                StaffList.ThisStaff = AnStaff;

                // Add the new record
                StaffList.Add();
            }

            else
            {
                // find the record to update
                StaffList.ThisStaff.Find(StaffId);

                // Set the ThisStaff property
                StaffList.ThisStaff = AnStaff;

                // update the record
                StaffList.Update();


            }

            // redirect back to list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            // display the error message
            lblError.Text = Error;
        }

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

    void DisplayStaff()
    {
        // Create an instance of the Staff Book
        clsStaffCollection StaffBook = new clsStaffCollection();

        // find the record to update
        bool found = StaffBook.ThisStaff.Find(StaffId);

        // Display the data for the record
        if (found && StaffBook.ThisStaff != null)
        {
            txtStaffId.Text = StaffBook.ThisStaff.StaffId.ToString();
            txtStaffName.Text = StaffBook.ThisStaff.StaffName.ToString();
            txtJoinDate.Text = StaffBook.ThisStaff.JoinDate.ToString();
            txtStaffEmail.Text = StaffBook.ThisStaff.StaffEmail.ToString();
            txtStaffPhoneNumber.Text = StaffBook.ThisStaff.StaffPhoneNumber.ToString();
            txtStaffSalary.Text = StaffBook.ThisStaff.StaffSalary.ToString();
            chkMorePermissions.Checked = StaffBook.ThisStaff.MorePermissions;
        }
        // Return empty if the data is not found
        else
        {
            txtStaffId.Text = "";
            txtStaffName.Text = "";
            txtJoinDate.Text = "";
            txtStaffEmail.Text = "";
            txtStaffPhoneNumber.Text = "";
            txtStaffSalary.Text = "";
            chkMorePermissions.Checked = false;

        }

    }

    protected void btnReturnMainMenu_Click(object sender, EventArgs e)
    {
        // Redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // Redirect the user back to the List Page
        Response.Redirect("StaffList.aspx");
    }
}