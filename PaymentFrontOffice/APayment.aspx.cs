using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PaymentClasses;

public partial class APayment : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {  //create a new instance of clspayment
        clsPayment APayment = new clsPayment();
        //get the data from the session object
        APayment = (clsPayment)Session["APayment"];
        //display the house number for this entry
        Response.Write(APayment.PaymentID);
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        clsPayment APayment = new clsPayment();

        APayment.PaymentID = txtPaymentID.Text;

        APayment.CustomerID = txtCustomerID.Text;

        APayment.ReservationID = txtReservationID.Text;

        APayment.CustomerBankName = txtCustomerBankNameID.Text;

        APayment.CustomerBankAccountNumber = txtCustomerBankAccountNumber.Text;

        APayment.CustomerSortCode = txtCustomerSortCode.Text;

        APayment.PaymentDate = txtPaymentDate.Text;

        APayment.PaymentStatus = txtPaymentStatus.Text;



        Session["APayment"] = APayment;

        Response.Write(" APayment.PaymentID");

    }

    void DisplayPayment()
    {
        clsPayment APayment = new clsPayment();
        APayment.Find(PaymentID);
        txtPaymentID.text = APayment.PaymentID;

    }
}