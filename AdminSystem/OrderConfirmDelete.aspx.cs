using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

//event handler for the load event
public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to delete
        Order.ThisOrder.Find(OrderID);
        //delete the record
        Order.Delete();
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }
}