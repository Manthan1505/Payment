using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentClasses
{
    public class clsDataConnection
    { 
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.AddParameter("@CustomerID", mThisPayment.PaymentID);
            DB.AddParameter("@ReservstionID", mThisPayment.PaymentID);
            DB.AddParameter("@CustomerBankAccountNumber", mThisPayment.PaymentID);
            DB.AddParameter("@CustomerBankName", mThisPayment.PaymentID);
            DB.AddParameter("@CustomerBankSortCode", mThisPayment.PaymentID);
            DB.AddParameter("@RoomServiceBill", mThisPayment.PaymentID);
            DB.AddParameter("@AdditionalFine", mThisPayment.PaymentID);

            return DB.Execute("sproc_tblPayment_Insert");
        }

    }
}
