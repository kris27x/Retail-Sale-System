using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = "";
        if (IsPostBack == false)
        {
            //display the current data for the record
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to the list of orders in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the name of the field to display
        lstOrderList.DataValueField = "DeliveryAddress";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this a new record
        Session["OrderID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please Select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the delete page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else//if no record has been selected
        {
            lblError.Text = "Please Select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        
        Orders.ReportByDeliveryAddress(txtFilter.Text);

        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the name of the field to display
        lstOrderList.DataTextField = "DeliveryAddress";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();

        Orders.ReportByDeliveryAddress("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the name of the field to display
        lstOrderList.DataTextField = "DeliveryAdress";
        //bind the data to the list
        lstOrderList.DataBind();
    }
}