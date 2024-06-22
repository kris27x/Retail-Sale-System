using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the ID of the customer to be deleted from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        //find the record to delete
        Customers.ThisCustomer.Find(CustomerID);
        //delete the record
        Customers.Delete();
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}