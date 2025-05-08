using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create a new instance of the class
        clsStaff AnStaff = new clsStaff();

        // Get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];

        // Display the staff Id for this entry
        Response.Write(AnStaff.StaffId);

        // Display the staff name for this entry
        Response.Write(AnStaff.StaffName);

        // Display the staff join date for this entry
        Response.Write(AnStaff.JoinDate);

        // Display the staff email for this entry
        Response.Write(AnStaff.StaffEmail);

        // Display the staff phone number for this entry
        Response.Write(AnStaff.StaffPhoneNumber);

        // Display the staff salary for this entry
        Response.Write(AnStaff.StaffSalary);

        // Display the staff permissions for this entry
        Response.Write(AnStaff.MorePermissions);

    }
}