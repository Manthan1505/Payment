using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace PaymentClasses
{
    public class clsPayment
    {
        public int CustomerID { get; set; }
        public int CustomerBankAccountNumber { get; set; }
        public string CustomerBankName { get; set; }
        public int AdditionalFine { get; set; }
        public int CustomerBankSortCode { get; set; }
        public int ReservationID { get; set; }
        public int RoomServiceBill { get; set; }
        public string PaymentStatus { get; set; }
        public int PaymentID { get; set; }
        public DateTime PaymentDate { get; set; }

        public int mCustomerID { get; set; }
        public int mCustomerBankAccountNumber { get; set; }
        public string mCustomerBankName { get; set; }
        public int mAdditionalFine { get; set; }
        public int mCustomerBankSortCode { get; set; }
        public int mReservationID { get; set; }
        public int mRoomServiceBill { get; set; }
        public string mPaymentStatus { get; set; }
        public int mPaymentID { get; set; }
        public DateTime mPaymentDate { get; set; }

        public string Valid(Int32 SomePaymentID)
        {

            //string variable to store the error message
            string Error = "";
            //if the name of the customer is more than 50 characters
            if (SomePaymentID > 50)
            {
                // return an error message
                Error = "The Payment ID cannot have more than 50 number";
            }
            if (SomePaymentID == 0)
            {
                //return an error message
                Error = "The Payment ID may not be blank!";
            }
            return Error;
        }

        public bool Find(Int32 PaymentID)
        {
            //always return true
            return true;
        }

        

    }
}