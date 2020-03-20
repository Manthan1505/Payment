using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentClasses;

namespace PaymentTesting
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //test to see that it exists
            Assert.IsNotNull(APayment);
        }

        [TestMethod]
        public void PaymentID()
        {
            //creating an instance of the class
            clsPayment APayment = new clsPayment();
            //creating some test data for customer ID
            Int32 PaymentID = 1;
            //assign the data to the property
            APayment.PaymentID = PaymentID;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.PaymentID, PaymentID);
        }

        [TestMethod]
        public void CustomerID()
        {
            //creating an instance of the class
            clsPayment APayment = new clsPayment();
            //creating some test data for customer ID
            Int32 CustomerID = 1;
            //assign the data to the property
            APayment.CustomerID = CustomerID;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.CustomerID, CustomerID);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 PaymentID = 1;
            //invoke the mehtod
            Error = APayment.Valid(PaymentID);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CustomerBankAccountNumber()
        {
            //creating an instance of the class
            clsPayment APayment = new clsPayment();
            //creating some test data for customer bank account number
            Int32 CustomerBankAccountNumber = 87654321;
            //assign the data to the property
            APayment.CustomerBankAccountNumber = CustomerBankAccountNumber;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.CustomerBankAccountNumber, CustomerBankAccountNumber);
        }

        [TestMethod]
        public void CustomerBankName()
        {
            //creating an instance of the class
            clsPayment APayment = new clsPayment();
            //creating some test data for customer Bank Name
            string CustomerBankName = "Barclays";
            //assign the data to the property
            APayment.CustomerBankName = CustomerBankName;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.CustomerBankName, CustomerBankName);
        }

        [TestMethod]
        public void AdditionalFine()
        {
            //creating an instance of the class
            clsPayment APayment = new clsPayment();
            //creating some test data for additional fine
            Int32 AdditionalFine = 10;
            //assign the data to the property
            APayment.AdditionalFine = AdditionalFine;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.AdditionalFine, AdditionalFine);
        }

        [TestMethod]
        public void CustomerBankSortCode()
        {
            //creating an instance of the class
            clsPayment APayment = new clsPayment();
            //creating some test data for customer Bank sort code
            Int32 CustomerBankSortCode = 654321;
            //assign the data to the property
            APayment.CustomerBankSortCode = CustomerBankSortCode;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.CustomerBankSortCode, CustomerBankSortCode);
        }

        [TestMethod]
        public void ReservationID()
        {
            //creating an instance of the class
            clsPayment APayment = new clsPayment();
            //creating some test data for customer ReservationID
            Int32 ReservationID = 1;
            //assign the data to the property
            APayment.ReservationID = ReservationID;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.ReservationID, ReservationID);
        }

        [TestMethod]
        public void RoomServiceBill()
        {
            //creating an instance of the class
            clsPayment APayment = new clsPayment();
            //creating some test data for customer ReservationID
            Int32 RoomServiceBill = 15;
            //assign the data to the property
            APayment.RoomServiceBill = RoomServiceBill;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.RoomServiceBill, RoomServiceBill);
        }

        [TestMethod]
        public void PaymentStatus()
        {
            //creating an instance of the class
            clsPayment APayment = new clsPayment();
            //creating some test data for customer ReservationID
            string PaymentStatus = "Paid";
            //assign the data to the property
            APayment.PaymentStatus = PaymentStatus;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.PaymentStatus, PaymentStatus);
        }

        [TestMethod]
        public void PaymentDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            APayment.PaymentDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.PaymentDate, TestData);
        }

        [TestMethod]
        public void PaymentIDMinLessOne()
        {
            //create an instance of the class that we want to create
            clsPayment APaymentID = new clsPayment();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 PaymentID = 0;
            //invoke the method
            Error = APaymentID.Valid(PaymentID);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PaymentIDMinBoundary()
        {
            //create an instance of the class that we want to create
            clsPayment APaymentID = new clsPayment();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 PaymentID = 0;
            //invoke the method
            Error = APaymentID.Valid(PaymentID);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PaymentIDMinPlusOne()
        {
            //create an instance of the class that we want to create
            clsPayment APaymentID = new clsPayment();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 PaymentID = 0;
            //invoke the method
            Error = APaymentID.Valid(PaymentID);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PaymentIDMaxLessOne()
        {
            //create an instance of the class that we want to create
            clsPayment APaymentID = new clsPayment();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 PaymentID = 0;
            //invoke the method
            Error = APaymentID.Valid(PaymentID);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PaymentIDMaxBoundary()
        {
            //create an instance of the class that we want to create
            clsPayment APaymentID = new clsPayment();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 PaymentID = 0;
            //invoke the method
            Error = APaymentID.Valid(PaymentID);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PaymentIDMaxPlusOne()
        {
            //create an instance of the class that we want to create
            clsPayment APaymentID = new clsPayment();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 PaymentID = 0;
            //invoke the method
            Error = APaymentID.Valid(PaymentID);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 PaymentID = 1;
            //invoke method 
            Found = APayment.Find(PaymentID);
            //test to tsee that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPaymentIDFound()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PaymentID = 1;
            //invoke the method
            APayment.PaymentID = PaymentID;
            Found = APayment.Find(PaymentID);
            //check the PaymentID
            if (APayment.PaymentID != PaymentID)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestCustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            APayment.CustomerID = CustomerID;
            //invoke the method
            Found = APayment.Find(CustomerID);
            //check the customerID
            if (APayment.CustomerID != CustomerID)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerBankAccountNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerBankAccountNumber = 87654321;
            APayment.CustomerBankAccountNumber = CustomerBankAccountNumber;
            //invoke the method
            Found = APayment.Find(CustomerBankAccountNumber);
            //check the CustomerBankAccountNumber
            if (APayment.CustomerBankAccountNumber != CustomerBankAccountNumber)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerBankSortCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerBankSortCode = 654321;
            APayment.CustomerBankSortCode = CustomerBankSortCode;
            //invoke the method
            Found = APayment.Find(CustomerBankSortCode);
            //check the CustomerBankAccountNumber
            if (APayment.CustomerBankSortCode != CustomerBankSortCode)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReservationIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReservationID = 1;
            APayment.ReservationID = ReservationID;
            //invoke the method
            Found = APayment.Find(ReservationID);
            //check the ReservationID
            if (APayment.ReservationID != ReservationID)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRoomServiceBillPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 RoomServiceBill = 1;
            APayment.RoomServiceBill = RoomServiceBill;
            //invoke the method
            Found = APayment.Find(RoomServiceBill);
            //check the RoomServiceBill
            if (APayment.RoomServiceBill != RoomServiceBill)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentDateFound()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            DateTime PaymentDate = DateTime.Now;
            APayment.PaymentDate = PaymentDate;
            //check the property
            if (APayment.PaymentDate != PaymentDate)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
