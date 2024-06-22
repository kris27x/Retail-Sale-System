using System;
using System.Collections.Generic;
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

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockViewer.aspx");
    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        //string values for valid method
        string ItemDescription = txtItemDescription.Text;
        string ItemQuantity = txtItemQuantity.Text;
        string DateAdded = txtDateAdded.Text;
        string Price = txtPrice.Text;
        //send string values to validate method
        string error = "";
        error = AnStock.Valid(ItemDescription, ItemQuantity, DateAdded, Price);
        if (error == "")

        {
            //capture the ItemDescription
            AnStock.ItemDescription = ItemDescription;
            //capture the Item Quantity
            AnStock.ItemQuantity = Convert.ToInt32(ItemQuantity);
            //capture the DateAdded
            AnStock.DateAdded = Convert.ToDateTime(DateAdded);
            //capture the price
            AnStock.Price = Convert.ToInt32(Price);
            //store the address in the session object
            Session["AnStock"] = AnStock;
            //navigate to the viewer page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = error;
        }
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }





    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AnStock = new clsStock();
        //variable to store the primary key
        Int32 ItemNo;
        //variable to store the result of the find opertaion
        Boolean Found = false;
        //get the primary key enetered by the user
        ItemNo = Convert.ToInt32(txtItemNo.Text);
        //find the record
        Found = AnStock.Find(ItemNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtItemDescription.Text = AnStock.ItemDescription;
            txtItemQuantity.Text = AnStock.ItemQuantity.ToString();
            txtDateAdded.Text = AnStock.DateAdded.ToString();
            txtPrice.Text = AnStock.Price.ToString();

        }
    }
}