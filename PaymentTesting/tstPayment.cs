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
            clsPayment APaymentID = new clsPayment();
            //creating some test data for customer ID
            Int32 PaymentID = 1;
            //assign the data to the property
            APaymentID.PaymentID = PaymentID;
            //test to see that the two values are the same
            Assert.AreEqual(APaymentID.PaymentID, PaymentID);
        }

        [TestMethod]
        public void CustomerID()
        {
            //creating an instance of the class
            clsPayment ACustomerID = new clsPayment();
            //creating some test data for customer ID
            Int32 CustomerID = 1;
            //assign the data to the property
            ACustomerID.CustomerID = CustomerID;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerID.CustomerID, CustomerID);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 SomePayment = 1;
            //invoke the mehtod
            Error = APayment.Valid(SomePayment);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CustomerBankAccountNumber()
        {
            //creating an instance of the class
            clsPayment ACustomerBankAccountNumber = new clsPayment();
            //creating some test data for customer bank account number
            Int32 CustomerBankAccountNumber = 87654321;
            //assign the data to the property
            ACustomerBankAccountNumber.CustomerBankAccountNumber = CustomerBankAccountNumber;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerBankAccountNumber.CustomerBankAccountNumber, CustomerBankAccountNumber);
        }

        [TestMethod]
        public void CustomerBankName()
        {
            //creating an instance of the class
            clsPayment ACustomerBankName = new clsPayment();
            //creating some test data for customer Bank Name
            string CustomerBankName = "Barclays";
            //assign the data to the property
            ACustomerBankName.CustomerBankName = CustomerBankName;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerBankName.CustomerBankName, CustomerBankName);
        }

        [TestMethod]
        public void AdditionalFine()
        {
            //creating an instance of the class
            clsPayment AAdditionalFine = new clsPayment();
            //creating some test data for additional fine
            Int32 AdditionalFine = 10;
            //assign the data to the property
            AAdditionalFine.AdditionalFine = AdditionalFine;
            //test to see that the two values are the same
            Assert.AreEqual(AAdditionalFine.AdditionalFine, AdditionalFine);
        }

        [TestMethod]
        public void CustomerBankSortCode()
        {
            //creating an instance of the class
            clsPayment ACustomerBankSortCode = new clsPayment();
            //creating some test data for customer Bank sort code
            Int32 CustomerBankSortCode = 654321;
            //assign the data to the property
            ACustomerBankSortCode.CustomerBankSortCode = CustomerBankSortCode;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerBankSortCode.CustomerBankSortCode, CustomerBankSortCode);
        }

        [TestMethod]
        public void ReservationID()
        {
            //creating an instance of the class
            clsPayment AReservationID = new clsPayment();
            //creating some test data for customer ReservationID
            Int32 ReservationID = 1;
            //assign the data to the property
            AReservationID.ReservationID = ReservationID;
            //test to see that the two values are the same
            Assert.AreEqual(AReservationID.ReservationID, ReservationID);
        }

        [TestMethod]
        public void RoomServiceBill()
        {
            //creating an instance of the class
            clsPayment ARoomServiceBill = new clsPayment();
            //creating some test data for customer ReservationID
            Int32 RoomServiceBill = 15;
            //assign the data to the property
            ARoomServiceBill.RoomServiceBill = RoomServiceBill;
            //test to see that the two values are the same
            Assert.AreEqual(ARoomServiceBill.RoomServiceBill, RoomServiceBill);
        }

        [TestMethod]
        public void PaymentStatus()
        {
            //creating an instance of the class
            clsPayment APaymentStatus = new clsPayment();
            //creating some test data for customer ReservationID
            string PaymentStatus = "Paid";
            //assign the data to the property
            APaymentStatus.PaymentStatus = PaymentStatus;
            //test to see that the two values are the same
            Assert.AreEqual(APaymentStatus.PaymentStatus, PaymentStatus);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
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
            Int32 SomePaymentID = 0;
            //invoke the method
            Error = APaymentID.Valid(SomePaymentID);
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
            Int32 SomePaymentID = 0;
            //invoke the method
            Error = APaymentID.Valid(SomePaymentID);
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
            Int32 SomePaymentID = 0;
            //invoke the method
            Error = APaymentID.Valid(SomePaymentID);
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
            Int32 SomePaymentID = 0;
            //invoke the method
            Error = APaymentID.Valid(SomePaymentID);
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
            Int32 SomePaymentID = 0;
            //invoke the method
            Error = APaymentID.Valid(SomePaymentID);
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
            Int32 SomePaymentID = 0;
            //invoke the method
            Error = APaymentID.Valid(SomePaymentID);
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
            Found = APayment.Find(PaymentID);
            //check the PaymentID
            if (APayment.PaymentID != 50)
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
            //invoke the method
            Found = APayment.Find(CustomerID);
            //check the customerID
            if (APayment.CustomerID != 50)
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
            //invoke the method
            Found = APayment.Find(CustomerBankAccountNumber);
            //check the CustomerBankAccountNumber
            if (APayment.CustomerBankAccountNumber != 8)
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
            //invoke the method
            Found = APayment.Find(CustomerBankSortCode);
            //check the CustomerBankAccountNumber
            if (APayment.CustomerBankSortCode != 6)
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
            //invoke the method
            Found = APayment.Find(ReservationID);
            //check the ReservationID
            if (APayment.ReservationID != 50)
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
            //invoke the method
            Found = APayment.Find(RoomServiceBill);
            //check the RoomServiceBill
            if (APayment.RoomServiceBill != 50)
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
            Int32 PaymentID = 1;
            //invoke the method
            Found = APayment.Find(PaymentID);
            //check the property
            if (APayment.PaymentDate != Convert.ToDateTime(""))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
