using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class OrderStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsOrder clsOrder = new ClsOrder();
        DataTable dT = clsOrder.StatisticsGroupedByShippingAddress();
        GridViewGroupByShippingAddress.DataSource = dT;
        GridViewGroupByShippingAddress.DataBind();
        GridViewGroupByShippingAddress.HeaderRow.Cells[0].Text = " Total"; 
        dT = clsOrder.StatisticsGroupedByShippingAddress();
        GridViewByOrderDate.DataSource = dT;
        GridViewByOrderDate.DataBind();
        GridViewByOrderDate.HeaderRow.Cells[0].Text = "Total";
    }
}