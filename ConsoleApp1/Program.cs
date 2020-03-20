using PaymentClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.WebClient client = new System.Net.WebClient();
            string downloadString = client.DownloadString("http://localhost:5000/");

            using (SqlConnection con = new SqlConnection("Server=tcp:.database.windows.net,1433;Initial Catalog=;Persist Security Info=False;User ID=;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * from tblCustomer";
                    DataTable _ds = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        adapter.Fill(_ds);
                }
            }
            clsPayment payment = new clsPayment();
            payment = new clsPayment
            {
                mPaymentID = 0,
                mCustomerID = 0,
                mReservationID = 0,
                mCustomerBankAccountNumber = 00000000,
                mCustomerBankName = "Test",
                mCustomerBankSortCode = 000000,
                mAdditionalFine = 0,
                mRoomServiceBill = 0,
                mPaymentDate = DateTime.Now
            };
            payment.Add();
        }
    }
}
