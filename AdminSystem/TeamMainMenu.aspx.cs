using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        // Redirect the user to the Customer List page
        Response.Redirect("Customerslist.aspx");
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        // Redirect the user to the Order List page
        Response.Redirect("OrdersList.aspx");
    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        // Redirect the user to the Staff List page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        // Redirce the user to the Stock List page
        Response.Redirect("StockList.aspx");
    }
}