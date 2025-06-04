using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (!IsPostBack)
        {
            //update the list box 
            DisplayStock();
        }
    }

    private void DisplayStock()
    {
       //create an instance of the Stock Collection 
       ClsStockCollection Stock = new ClsStockCollection();
        //set the data source to list of stock in the collection 
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key 
        lstStockList.DataValueField = "GameId";
        //set the data field to display
        lstStockList.DataTextField = "GameTitle";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["GameId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited
        Int32 GameId;

        // if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            GameId = Convert.ToInt32(lstStockList.SelectedValue);

            // store the data in the session object
            Session["GameId"] = GameId;

            // redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            // if no record has been selected, display an error
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be deleted
        Int32 GameId;

        // if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            // get the primary key value of the record to delete
            GameId = Convert.ToInt32(lstStockList.SelectedValue);

            // store the data in the session object
            Session["GameId"] = GameId;

            // redirect to the delete confirmation page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            // if no record has been selected, display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // Create an instance of the stock collection
        ClsStockCollection FilteredStock = new ClsStockCollection();

        // Retrieve the GameTitle filter text from the presentation layer
        FilteredStock.ReportByGameTitle(txtFilter.Text);

        // Set the data source to the list of filtered stock records
        lstStockList.DataSource = FilteredStock.StockList;

        // Set the primary key field
        lstStockList.DataValueField = "GameId";

        // Set the field to display in the list
        lstStockList.DataTextField = "GameTitle";

        // Bind the data to the list control
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // Create an instance of the stock collection
        ClsStockCollection AllStock = new ClsStockCollection();

        // Reset the filter by passing an empty string
        AllStock.ReportByGameTitle("");

        // Clear the text in the filter textbox
        txtFilter.Text = "";

        // Set the data source to the full list of stock
        lstStockList.DataSource = AllStock.StockList;

        // Set the name of the primary key
        lstStockList.DataValueField = "GameId";

        // Set the name of the field to display
        lstStockList.DataTextField = "GameTitle";

        // Bind the data to the list
        lstStockList.DataBind();
    }

    protected void BtnStatistics_Click(object sender, EventArgs e)
    {
        // redirect to the delete confirmation page
        Response.Redirect("StockStatistics.aspx");
    }
}