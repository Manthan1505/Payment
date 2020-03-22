CREATE TABLE [dbo].[tblPayment]
(
	[PaymentID] INT NOT NULL IDENTITY , 
    [CustomerID] INT NULL, 
    [ReservationID] INT NULL, 
    [CustomerAccountNo] INT NULL, 
    [CustomerBankName] VARCHAR(20) NULL, 
    [CustomerSortCode] INT NULL, 
    [PaymentStatus] INT NULL, 
    [AdditionalFine] INT NULL, 
    [RoomServiceBill] INT NULL, 
    [PaymentDate] DATETIME NULL, 
    [AmountPaid] INT NULL, 
    CONSTRAINT [PK_tblPayment] PRIMARY KEY ([PaymentID])
	
)