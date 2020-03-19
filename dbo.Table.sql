CREATE TABLE [dbo].[tblPayment]
(
	[PaymentID] INT NOT NULL IDENTITY , 
    [CustomerID] INT NOT NULL, 
    [ReservationID] INT NOT NULL, 
    [CustomerAccountNo] INT NOT NULL, 
    [CustomerBankName] VARCHAR(20) NOT NULL, 
    [CustomerSortCode] INT NOT NULL, 
    [PaymentStatus] INT NULL, 
    [AdditionalFine] INT NULL, 
    [RoomServiceBill] INT NULL, 
    [PaymentDate] DATETIME NULL, 
    [AmountPaid] INT NULL, 
    CONSTRAINT [PK_tblPayment] PRIMARY KEY ([PaymentID])
	
)