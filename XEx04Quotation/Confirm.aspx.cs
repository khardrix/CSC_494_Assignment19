using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx04Quotation
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (Session["salesPrice"] == null || Session["discountAmount"] == null)
            {
                lblMessage.Text = "Click the Return button to go back to the previous page and " + 
                    "click the Calculate button before you click the Confirm button.";
            }
            else
            {
                decimal salesPriceNum = (decimal)Session["salesPrice"];
                lblSalesPrice.Text = salesPriceNum.ToString("c");

                decimal discountAmountNum = (decimal)Session["discountAmount"];
                lblDiscountAmount.Text = discountAmountNum.ToString("c");

                decimal totalPriceNum = (decimal)Session["totalPrice"];
                lblTotalPrice.Text = totalPriceNum.ToString("c");
            }
        }

        protected void btnSendQuotation_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string name = txtName.Text;
                string email = txtEmail.Text;

                lblMessage.Text = "Quotation sent to " + name + " at " + email + ".";
            }
        }
    }
}