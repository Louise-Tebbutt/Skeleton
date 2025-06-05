using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope 
    Int32 GameId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the stock record to be processed
        GameId = Convert.ToInt32(Session["GameId"]);

        if (IsPostBack == false)
        {
            // if this is not a new record
            if (GameId != -1)
            {
                // display the current data for the record
                DisplayStock();
            }
        }
    }

    protected void txtGameTitle_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of ClsStock
        ClsStock AStock = new ClsStock();

        // Capture input data from textboxes
        string GameId = txtGameId.Text;
        string GameTitle = txtGameTitle.Text;
        string GameReleaseDate = txtGameReleaseDate.Text;
        string GamePrice = txtGamePrice.Text;
        string StockQty = txtStockQty.Text;
        string GameRating = txtGameRating.Text;
        string IsDigital = chkIsDigital.Checked.ToString();

        // String variable to store error message
        string Error = "";

        // Validate the data
        Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);

        if (Error == "")
        {
            // Get the GameId from the session
            Int32 GameIdInt = Convert.ToInt32(Session["GameId"]);

            // DON'T MISS THIS BIT: Assign the GameId
            AStock.GameId = GameIdInt;

            // Assign values to the stock object
            AStock.GameTitle = GameTitle;
            AStock.GameReleaseDate = Convert.ToDateTime(GameReleaseDate);
            AStock.GamePrice = Convert.ToDecimal(GamePrice);
            AStock.StockQty = Convert.ToInt32(StockQty);
            AStock.GameRating = Convert.ToInt32(GameRating);
            AStock.IsDigital = chkIsDigital.Checked;

            // Create a new instance of the stock collection
            ClsStockCollection StockCollection = new ClsStockCollection();

            if (GameIdInt == -1)
            {
                // This is a new record
                StockCollection.ThisStock = AStock;
                StockCollection.Add();
            }
            else
            {
                // This is an update to an existing record
                StockCollection.ThisStock.Find(GameIdInt);
                StockCollection.ThisStock = AStock;
                StockCollection.Update();
            }

            // Redirect to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            // Display the error
            lblError.Text = Error;
        }
    }

    protected void chkIsDigital_CheckedChanged(object sender, EventArgs e)
    {

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the stock class
        ClsStock AStock = new ClsStock();

        // Variable to store the primary key
        Int32 GameId;

        // Get the value entered by the user
        GameId = Convert.ToInt32(txtGameId.Text);

        // Try to find the record
        Boolean Found = AStock.Find(GameId);

        if (Found == true)
        {
            // Display the values of the record
            txtGameTitle.Text = AStock.GameTitle;
            txtGameReleaseDate.Text = AStock.GameReleaseDate.ToString("yyyy-MM-dd");
            txtGamePrice.Text = AStock.GamePrice.ToString();
            txtStockQty.Text = AStock.StockQty.ToString();
            txtGameRating.Text = AStock.GameRating.ToString();
            chkIsDigital.Checked = AStock.IsDigital;

            // Clear any previous error message
            lblError.Text = "";
        }
        else
        {
            // Show error message if record not found
            lblError.Text = "Game ID not found. Please try again.";

            // Optionally clear the fields
            txtGameTitle.Text = "";
            txtGameReleaseDate.Text = "";
            txtGamePrice.Text = "";
            txtStockQty.Text = "";
            txtGameRating.Text = "";
            chkIsDigital.Checked = false;
        }
    }


    void DisplayStock()
    {
        // create an instance of the stock collection
        ClsStockCollection StockBook = new ClsStockCollection();

        // find the record to update
        StockBook.ThisStock.Find(GameId);

        // display the data for the record
        txtGameId.Text = StockBook.ThisStock.GameId.ToString();
        txtGameTitle.Text = StockBook.ThisStock.GameTitle.ToString();
        txtGameReleaseDate.Text = StockBook.ThisStock.GameReleaseDate.ToString();
        txtGamePrice.Text = StockBook.ThisStock.GamePrice.ToString();
        txtStockQty.Text = StockBook.ThisStock.StockQty.ToString();
        txtGameRating.Text = StockBook.ThisStock.GameRating.ToString();
        chkIsDigital.Checked = StockBook.ThisStock.IsDigital;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    protected void btnReturnToMM_Click_Click(object sender, EventArgs e)
    {
        // Redirce the user to the Stock List page
        Response.Redirect("StockList.aspx");
    }
}
