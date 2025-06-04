using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StockStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsStock clsStock = new ClsStock();

        //retrieve data from the database
        DataTable dT = clsStock.StatisticsGroupedByGameReleaseDate();

        //upload dt into GridView 
        GridViewStGroupByGameReleaseDate.DataSource = dT;
        GridViewStGroupByGameReleaseDate.DataBind();

        //Change The header of the first column
        GridViewStGroupByGameReleaseDate.HeaderRow.Cells[0].Text = "Total";

        //retrieve data from the database
        dT = clsStock.StatisticsGroupedByGameTitle();

        //upload dt into GridView 
        GridViewStGroupByGameTitle.DataSource = dT;
        GridViewStGroupByGameTitle.DataBind();

        //Change The header of the first column
        GridViewStGroupByGameTitle.HeaderRow.Cells[0].Text = "Total";
    }

    protected void BtnBackToPage_Click(object sender, EventArgs e)
    {
        // redirect to the delete confirmation page
        Response.Redirect("StockList.aspx");
    }
}