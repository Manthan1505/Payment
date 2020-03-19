using System.Collections.Generic;

namespace PaymentClasses
{
    public class clsPaymentCollection
    {
        public List<clsPayment> PaymentList { get; set; }
        //public object ThisPayment { get; set; }
        //private data member for the list
        List<clsPayment> mPaymentList = new List<clsPayment>();
        //privete data member thisPayment
        clsPayment mThisPayment = new clsPayment();


       public clsPayment ThisPayment
        {
            get
            {
                //return the private data
                return mThisPayment;
            }
            set
            {
                //set the private data
                mThisPayment = value;
            }
        }
        public int Add()
        {
            mThisPayment.PaymentID = 1;
            return mThisPayment.PaymentID;
        }
    }
}

