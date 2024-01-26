use [DataConnectionTest];
 
CREATE TABLE dbo.[Employee](
	[EmployeeID] [int] NOT NULL,
	[FirstName] [varchar](255) NOT NULL,
	[LastName] [varchar](255) NOT NULL,
	[PrimaryOffering] [int] NOT NULL,
	[SecondaryOffering] [int] NOT NULL
	)
SELECT * FROM dbo.Employee 