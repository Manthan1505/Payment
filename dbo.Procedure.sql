CREATE PROCEDURE sproc_tblPayment_Insert
--create parameters for the stored procedure
@PaymentID int,
@CustomerID int,
@ReservationID int,
@CustomerAccountNo int,
@CustomerBankName VARCHAR (20),
@CustomerSortCode int,
@AdditionalFine int,
@RoomServiceBill int,
@PaymentDate DateTime,

AS
	--insert the new record
	INSERT INTO tblPayment
	(PaymentID, CustomerID, ReservationID, CustomerAccountNo, CustomerBankName, CustomerSortCode, AdditionalFine, RoomServiceBill, PaymentDate) 
	SELECT @PaymentID, @CustomerID, @ReservationID, @CustomerAccountNo, @CustomerBankName, @CustomerSortCode, @AdditionalFine, @RoomServiceBill, @PaymentDate


return @@Identity