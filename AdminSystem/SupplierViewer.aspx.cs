using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();
        AnSupplier = (clsSupplier)Session["AnSupplier"];
        Response.Write(AnSupplier.SupplierProduct);
        Response.Write(AnSupplier.SupplierFeedback);
        Response.Write(AnSupplier.DeliveryDate);
        Response.Write(AnSupplier.Price);
        Response.Write(AnSupplier.SupplierId);

    }
}