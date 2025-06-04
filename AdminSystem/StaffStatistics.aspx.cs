using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create an instance of the class we want to create
        clsStaff clsStaff = new clsStaff();

        // retrieve data from the database
        DataTable dT = clsStaff.StatisticsGroupedByJoinDate();

        // Upload dT into GridView
        GridViewStGroupByJoinDate.DataSource = dT;
        GridViewStGroupByJoinDate.DataBind();

        // Change the ehader of the first column
        GridViewStGroupByJoinDate.HeaderRow.Cells[0].Text = " Total ";


        // retireve data from the database
        dT = clsStaff.StatisticsGroupedByStaffSalary();

        // Upload dT into GridView
        GridViewStGroupByStaffSalary.DataSource = dT;
        GridViewStGroupByStaffSalary.DataBind();

        // Change the header of the first column
        GridViewStGroupByStaffSalary.HeaderRow.Cells[0].Text = " Total ";
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        // Redirect to the data entry page
        Response.Redirect("StaffList.aspx");
    }
}