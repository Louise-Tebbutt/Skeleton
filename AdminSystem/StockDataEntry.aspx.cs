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
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtGameTitle_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of ClsStock
        ClsStock AStock = new ClsStock();

        //capture the input data from the textboxes
        string GameId = txtGameId.Text;
        string GameTitle = txtGameTitle.Text;
        string GameReleaseDate = txtGameReleaseDate.Text;
        string GamePrice = txtGamePrice.Text;
        string StockQty = txtStockQty.Text;
        string GameRating = txtGameRating.Text;
        string IsDigital = chkIsDigital.Checked.ToString(); // checkbox returns bool; convert to string

        //string variable to store any error message
        string Error = "";

        //validate the data
        Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);

        if (Error == "")
        {
            //no errors, so capture the values in the stock object

            AStock.GameId = Convert.ToInt32(GameId);
            AStock.GameTitle = GameTitle;
            AStock.GameReleaseDate = Convert.ToDateTime(GameReleaseDate);
            AStock.GamePrice = Convert.ToDecimal(GamePrice);
            AStock.StockQty = Convert.ToInt32(StockQty);
            AStock.GameRating = Convert.ToInt32(GameRating);
            AStock.IsDigital = Convert.ToBoolean(IsDigital); // convert back to bool from string

            //store the stock object in the session
            Session["AStock"] = AStock;

            //navigate to the viewer page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display the error
            lblError.Text = Error;
        }
    }

    protected void chkIsDigital_CheckedChanged(object sender, EventArgs e)
    {

    }

   
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        ClsStock AStock = new ClsStock();
        //create a variable to store the primary key
        Int32 GameId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        GameId = Convert.ToInt32(txtGameId.Text);
        //find the record
        Found = AStock.Find(GameId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtGameId.Text = AStock.GameId.ToString();
            txtGameTitle.Text = AStock.GameTitle;
            txtGameReleaseDate.Text = AStock.GameReleaseDate.ToString("yyyy-MM-dd");
            txtGamePrice.Text = AStock.GamePrice.ToString("0.00");
            txtStockQty.Text = AStock.StockQty.ToString();
            txtGameRating.Text = AStock.GameRating.ToString();
            chkIsDigital.Checked = AStock.IsDigital;
        }
        else
        {
            txtGameTitle.Text = " ";
            txtGameReleaseDate.Text = " ";
            txtGamePrice.Text = " ";
            txtStockQty.Text = " ";
            txtGameRating.Text = " ";
   
        }
    }
}
