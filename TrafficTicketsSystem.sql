CREATE TABLE Cameras
(
	CameraId INT IDENTITY(1, 1),
	CameraNumber nvarchar(20),
	Make nvarchar(40),
	Model nvarchar(40),
	[Location] nvarchar(120),
	CONSTRAINT PK_Cameras PRIMARY KEY(CameraId)
);
GO
CREATE TABLE Drivers
(
	DriverId INT IDENTITY(1, 1),
	DrvLicNumber nvarchar(20),
	FirstName nvarchar(25),
	LastName nvarchar(25),
	[Address] nvarchar(100),
	City nvarchar(50),
	County nvarchar(50),
	[State] nvarchar(5),
	ZIPCode nvarchar(50),
	CONSTRAINT PK_Drivers PRIMARY KEY(DriverId)
);
GO
CREATE TABLE Vehicles
(
	VehicleId INT IDENTITY(1, 1),
	TagNumber nvarchar(20),
	DrvLicNumber nvarchar(20),
	Make nvarchar(40),
	Model nvarchar(40),
	VehicleYear int,
	Color nvarchar(32),
	CONSTRAINT PK_Vehicles PRIMARY KEY (VehicleId)
)
GO
CREATE TABLE ViolationTypes
(
	ViolationTypeId INT IDENTITY(1, 1),
	ViolationName nvarchar(30),
	[Description] nvarchar(max),
	CONSTRAINT PK_ViolationsTypes PRIMARY KEY(ViolationTypeId)
);
GO
CREATE TABLE TrafficViolations
(
	TrafficViolationId INT IDENTITY(1, 1),
	CameraNumber nvarchar(20),
	TagNumber nvarchar(20),
	ViolationName nvarchar(30),
	ViolationDate date,
	ViolationTime time(7),
	PhotoAvailable nvarchar(10),
	VideoAvailable nvarchar(10),
	PaymentDueDate date,
	PaymentDate date,
	PaymentAmount decimal(8, 2),
	CONSTRAINT PK_TrafficViolations PRIMARY KEY(TrafficViolationId)
);
GO