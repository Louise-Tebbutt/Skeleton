using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        // Create an instance of the staff collection
        clsStaffCollection AllStaff = new clsStaffCollection();

        // Set the data source to list of staff in the collection
        lstStaffList.DataSource = AllStaff.StaffList;

        // Set the name of the primary key
        lstStaffList.DataValueField = "StaffId";

        // Set the data field to display
        lstStaffList.DataTextField = "StaffName";

        // bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;

        // Redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key
        Int32 StaffId;

        // If a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);

            // Store the data in session 
            Session["StaffId"] = StaffId;

            // Redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be delete
        Int32 StaffId;

        // If a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            // Get the primary key value of the record delete
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);

            // Store the data in the session object
            Session["StaffId"] = StaffId;

            // Redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else // if no record has been selected
        {
            // Display an errorm message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        // Create an instance of the staff object
        clsStaffCollection AnStaff = new clsStaffCollection();

        // Retrieve the value of Staff Name from the presentation layer
        AnStaff.ReportByStaffName(txtFilter.Text);

        // Set the data source to the list of staff in the collection
        lstStaffList.DataSource = AnStaff.StaffList;

        // Set the name of the primary value key
        lstStaffList.DataValueField = "StaffId";

        // Set the name of the field to display
        lstStaffList.DataTextField = "StaffName";

        // Bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Create an instance of the staff object
        clsStaffCollection AnStaff = new clsStaffCollection();

        // Set an empty string
        AnStaff.ReportByStaffName("");

        // Clear any existing filter to tidy up the interface
        txtFilter.Text = "";

        // Set the data source to the list of staff in the collection
        lstStaffList.DataSource = AnStaff.StaffList;

        // Set the name of the primary key
        lstStaffList.DataValueField = "StaffId";

        // Set the name of the field to display
        lstStaffList.DataTextField = "StaffName";

        // Bind the data to the list
        lstStaffList.DataBind();
    }
}