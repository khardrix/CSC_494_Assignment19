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


            /*
            if (PreviousPage != null)
            {
            */
            /*
            SortedList displaySalesPrice = (SortedList);
            HttpContext.Current.Session["salesPrice"];
            */
            /*
            SortedList salesPrice = (SortedList) Session["salesPrice"];
            SortedList discountAmount = (SortedList) Session["discountAmount"];
            SortedList totalPrice = (SortedList) Session["totalPrice"];
            */
            /* THESE WORK, BUT CANNOT FORMAT TO CURRENCY
            lblSalesPrice.Text = Session["salesPrice"].ToString();
            lblDiscountAmount.Text = Session["discountAmount"].ToString();
            lblTotalPrice.Text = Session["totalPrice"].ToString();
            */
            /*
            Response.Write(Session["salesPrice"].ToString());
            */
            /*
            System.Collections.SortedList salesPrice = (System.Collections.SortedList)Session["salesPrice"];
            System.Collections.SortedList discountAmount = (System.Collections.SortedList)Session["discountAmount"];
            System.Collections.SortedList totalPrice = (System.Collections.SortedList)Session["totalPrice"];

            lblSalesPrice.Text = salesPrice.ToString();
            lblDiscountAmount.Text = discountAmount.ToString();
            lblTotalPrice.Text = totalPrice.ToString();
            */
            // HttpContext.Current.Session[salesPrice];
            /*
            }
            */
            /*
             if (PreviousPage != null)
            {
                TextBox txtSalesPrice = (TextBox)PreviousPage.FindControl("txtSalesPrice");
                lblSalesPrice.Text = txtSalesPrice.Text;

                TextBox txtDiscountAmount = (TextBox)PreviousPage.FindControl("txDiscountAmount");
                lblDiscountAmount.Text = txtDiscountAmount.Text;

                TextBox txtTotalPrice = (TextBox)PreviousPage.FindControl("txtTotalPrice");
                lblTotalPrice.Text = txtTotalPrice.Text;
            }
            */
        }
    }
}