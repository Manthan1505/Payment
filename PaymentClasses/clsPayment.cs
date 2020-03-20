using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace PaymentCollection
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
        //public int PaymentID { get; set; }
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

        public bool Find(int PaymentID)
        {
            mPaymentID = 1;
            //always return true
            return true;
        }
        
        public int PaymentID
        { 
            get
            {
                return mPaymentID;
            }
            set
            {
                mPaymentID = value;
            }
        }
        
        public int Add()
        {
            //add a new record to the database based on the values of ThisPayment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PaymentID", mPaymentID);
            DB.AddParameter("@CustomerID", mCustomerID);
            DB.AddParameter("@ReservationID", mReservationID);
            DB.AddParameter("@CustomerAccountNo", mCustomerBankAccountNumber);
            DB.AddParameter("@CustomerBankName", mCustomerBankName);
            DB.AddParameter("@CustomerSortCode", mCustomerBankSortCode);
            DB.AddParameter("@AdditionalFine", mAdditionalFine);
            DB.AddParameter("@RoomServiceBill", mRoomServiceBill);
            DB.AddParameter("@PaymentDate", mPaymentDate);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblPayment_Insert");
        }

        public void Delete()
        {

            //deletes the record pointed to by ThisPayment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.Execute("sproc_tblPayment_Delete");
        }

    }
}


//Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"###\";Integrated Security=True;Connect Timeout=30
//Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"###\";Integrated Security=True;Connect Timeout=30