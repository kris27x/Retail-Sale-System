using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level cope
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not the new record
            if (OrderID != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        //create an instance of the order book
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to update
        Order.ThisOrder.Find(OrderID);
        //display the data for this record
        txtOrderID.Text = Order.ThisOrder.OrderID.ToString();
        txtPhoneNumber.Text = Order.ThisOrder.PhoneNumber.ToString();
        txtItemQuantity.Text = Order.ThisOrder.ItemQuantity.ToString();
        chkDelivered.Checked = Order.ThisOrder.Delivery;
        txtDeliveryTime.Text = Order.ThisOrder.DeliveryTime.ToString();
        txtDeliveryAddress.Text = Order.ThisOrder.DeliveryAddress;
        txtNotes.Text = Order.ThisOrder.Notes;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the Notes
        string Notes = txtNotes.Text;
        //capture the PhoneNumber
        string PhoneNumber = txtPhoneNumber.Text;
        //capture the ItemQuantity
        string ItemQuantity = txtItemQuantity.Text;
        //capture the delivery time
        string DeliveryTime = txtDeliveryTime.Text;
        //capture the deliveryAddress
        string DeliveryAddress = txtDeliveryAddress.Text;
        //var to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

        if(Error == "")
        {
            //capture the OrderID
            AnOrder.OrderID = OrderID;
            //capture the Phone number
            AnOrder.PhoneNumber = Convert.ToInt64(PhoneNumber);
            //capture the item quantity
            AnOrder.ItemQuantity = Convert.ToInt32(ItemQuantity);
            //capture the delivery
            AnOrder.Delivery = chkDelivered.Checked;
            //capture the delivery time
            AnOrder.DeliveryTime = Convert.ToDateTime(DeliveryTime);
            //capture the delivery address
            AnOrder.DeliveryAddress = DeliveryAddress;
            //capture the Note
            AnOrder.Notes = Notes;
            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this is a new record i.e. OrderID != -1 then add the data
            if(OrderID != -1)
            {
                // set the thisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderID);
                //set the thisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }

            //redirect back to the lispage
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
    protected void lblFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        Int32 OrderID;

        Boolean Found = false;

        OrderID = Convert.ToInt32(txtOrderID.Text);

        Found = AnOrder.Find(OrderID);

        if (Found == true)
        {
            txtPhoneNumber.Text = AnOrder.PhoneNumber.ToString();

            txtItemQuantity.Text = AnOrder.ItemQuantity.ToString();

            txtDeliveryTime.Text = AnOrder.DeliveryTime.ToString();

            txtDeliveryAddress.Text = AnOrder.DeliveryAddress;

            txtNotes.Text = AnOrder.Notes;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}