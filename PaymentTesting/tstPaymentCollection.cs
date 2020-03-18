using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentClasses;


namespace PaymentTesting
{
    [TestClass]
    public class tstPaymentCollection
    {
        private List<clsPayment> mPaymentList;

        public object TestPayment { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //test to see that it exists
            Assert.IsNotNull(AllPayments);
        }

        [TestMethod]
        public void PaymentListOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsPayment> TestList = new List<clsPayment>();
            //add an item to the list
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.PaymentID = 1;
            TestItem.CustomerID = 1;
            TestItem.ReservationID = 1;
            TestItem.CustomerBankName = "Barclays";
            TestItem.CustomerBankAccountNumber = 87654321;
            TestItem.CustomerBankSortCode = 654321;
            TestItem.AdditionalFine = 10;
            TestItem.RoomServiceBill = 15;
            TestItem.PaymentStatus = "Paid";
            TestItem.PaymentDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPayments.PaymentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.PaymentList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            // create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllPayments.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.Count, SomeCount);
        }



        [TestMethod]
        public void ThisPaymentPropertyOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to the property
            clsPayment TestPayment = new clsPayment();
            //set its properties of the test object
            TestPayment.PaymentID = 1;
            TestPayment.CustomerID = 1;
            TestPayment.ReservationID = 1;
            TestPayment.CustomerBankName = "Barclays";
            TestPayment.CustomerBankAccountNumber = 87654321;
            TestPayment.CustomerBankSortCode = 654321;
            TestPayment.AdditionalFine = 10;
            TestPayment.RoomServiceBill = 15;
            TestPayment.PaymentStatus = "Paid";
            TestPayment.PaymentDate = DateTime.Now.Date;
            //assign the data to the property
            AllPayments.PaymentList = TestPayment;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.PaymentList, TestPayment);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsPayment> TestList = new List<clsPayment>();
            //add an item to the list
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //set its properties 
            TestItem.PaymentID = 1;
            TestItem.CustomerID = 1;
            TestItem.ReservationID = 1;
            TestItem.CustomerBankName = "Barclays";
            TestItem.CustomerBankAccountNumber = 87654321;
            TestItem.CustomerBankSortCode = 654321;
            TestItem.AdditionalFine = 10;
            TestItem.RoomServiceBill = 15;
            TestItem.PaymentStatus = "Paid";
            TestItem.PaymentDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPayments.PaymentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.PaymentList, TestList.Count);
        }

        public class clsPaymentCollection
        {
            //private data member for the list
            List<clsPayment> mPaymentList = new List<clsPayment>();

            public List<clsPayment> PaymentList { get; internal set; }
            public int Count { get; internal set; }
            public object ThisPayment { get; internal set; }
        }

        //public property for the customer list
        public List<clsPayment> PaymentList
        {
            get
            {
                //return the private data
                return mPaymentList;
            }
            set
            {
                //set the private data
                mPaymentList = value;
            }

        }

        //public property for count
        public int count
        {
            get
            {
                //return the count of the list
                return mPaymentList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayment = new clsPaymentCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllPayment.Count, 2);
        }

        //constructor for the class
        public clsPaymentCollection()
        {
            //create the items of test data
            clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.PaymentID = 1;
            TestItem.CustomerID = 1;
            TestItem.ReservationID = 1;
            TestItem.CustomerBankName = "Barclays";
            TestItem.CustomerBankAccountNumber = 87654321;
            TestItem.CustomerBankSortCode = 654321;
            TestItem.AdditionalFine = 10;
            TestItem.RoomServiceBill = 15;
            TestItem.PaymentStatus = "Paid";
            TestItem.PaymentDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            mPaymentList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsPayment();
            //set its properties
            TestItem.PaymentID = 2;
            TestItem.CustomerID = 2;
            TestItem.ReservationID = 2;
            TestItem.CustomerBankName = "Lyods";
            TestItem.CustomerBankAccountNumber = 86454321;
            TestItem.CustomerBankSortCode = 564321;
            TestItem.AdditionalFine = 10;
            TestItem.RoomServiceBill = 15;
            TestItem.PaymentStatus = "Paid";
            TestItem.PaymentDate = DateTime.Now.Date;
            //add the item to the test list
            mPaymentList.Add(TestItem);
        }
    }
}
    

