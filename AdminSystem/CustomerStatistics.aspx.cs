using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer clscustomer = new clsCustomer();
        DataTable dT = clscustomer.StatisiticsGroupedByName();
        GridViewGroupByCutomerName.DataSource = dT;
        GridViewGroupByCutomerName.DataBind();
        GridViewGroupByCutomerName.HeaderRow.Cells[0].Text = " Total";
        dT = clscustomer.StatisiticsGroupedByDateOfBirth();
        GridViewByCustomerDateOfBirth.DataSource = dT;
        GridViewByCustomerDateOfBirth.DataBind();
        GridViewByCustomerDateOfBirth.HeaderRow.Cells[0].Text = "Total";

    }
}