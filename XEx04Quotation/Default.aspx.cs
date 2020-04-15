﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx04Quotation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                decimal salesPrice = Convert.ToDecimal(txtSalesPrice.Text);
                decimal discountPercent = Convert.ToDecimal(txtDiscountPercent.Text) / 100;

                decimal discountAmount = salesPrice * discountPercent;
                decimal totalPrice = salesPrice - discountAmount;

                lblDiscountAmount.Text = discountAmount.ToString("c");
                lblTotalPrice.Text = totalPrice.ToString("c");

                

                Session.Add("salesPrice", salesPrice);
                Session.Add("discountAmount", discountAmount);
                Session.Add("totalPrice", totalPrice);


                /*
                Session["salesPrice"] = salesPrice;
                Session["discountAmount"] = discountAmount;
                Session["totalPrice"] = totalPrice;
                */
                /*
                Session.Add("txtSalesPrice", txtSalesPrice);
                Session.Add("lblDiscountAmount", lblDiscountAmount);
                Session.Add("lblTotalPrice", lblTotalPrice);
                */
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Response.Redirect("Confirm.aspx");
        }
    }
}