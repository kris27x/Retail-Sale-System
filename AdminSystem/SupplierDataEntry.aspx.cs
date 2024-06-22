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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();
        int SupplierId = Convert.ToInt32(txtSupplierId.Text);
        string SupplierFeedback = txtSupplierFeedback.Text;
        string Price = txtSupplierPrice.Text;
        string SupplierProducts = txtSupplierProduct.Text;
        string DeliveryDate = txtDeliveryDate.Text;
        string Stock = txtStock.Text;
        string Error = "";
        Error = AnSupplier.Valid(SupplierFeedback, SupplierProducts, Price, DeliveryDate);
        if (Error == "")
        {
            AnSupplier.SupplierId = Convert.ToInt32(SupplierId);
            AnSupplier.SupplierProduct = SupplierProducts;
            AnSupplier.Price = Convert.ToInt32(Price);
            AnSupplier.SupplierFeedback = Convert.ToInt32(SupplierFeedback);
            AnSupplier.DeliveryDate = Convert.ToDateTime(DeliveryDate);
            AnSupplier.Stock = Convert.ToString(Stock);
            Session["AnSupplier"] = AnSupplier;
            Response.Write("SupplierViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

    }
}


        





        
