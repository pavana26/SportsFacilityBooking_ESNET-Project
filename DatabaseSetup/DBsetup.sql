use [SA46Team05A Database];

if object_id('dbo.Availability', 'U') is not null 
	drop table Availability;
if object_id('dbo.Transactions', 'U') is not null 
	drop table Transactions;
if object_id('dbo.Facilities', 'U') is not null 
	drop table Facilities;
if object_id('dbo.Members', 'U') is not null 
	drop table Members;

create table Facilities (
	FacilityID	varchar(2)	not null,
	FacilityName	varchar(32)	not null,
	NotInUse	bit		not null	default 0,
	primary key (FacilityID)
)
go

create table Members (
	MemberID	int		not null	identity(1,1),
	MemberName	nvarchar(64)	not null,
	Salutation	varchar(4)	not null,
	Sex		char(1)		not null,
	Birthday	date		not null,
	PhoneNumber	char(8)		not null,
	Address		nvarchar(128)	not null,
	Email		nvarchar(64),
	EmergencyContactName 	nvarchar(64) 	not null,
	EmergencyContactPhone	char(8)		not null,
	JoinDate	date		not null,
	ExpiryDate	date 		not null,
	primary key (MemberID)
)
go

create table Transactions (
	TransactionID	int		not null	identity(1,1),
	FacilityID	varchar(2)	not null,
	MemberID	int		not null,
	TransDate	date		not null,
	StartTime	smallint	not null,
	EndTime		smallint	not null,
	Cancelled	bit		not null	default 0,
	primary key (TransactionID),
	foreign key (FacilityID) 
		references Facilities(FacilityID),
	foreign key (MemberID) 
		references Members(MemberID)
)
go

create table Availability (
	FacilityID	varchar(2)	not null,
	AvailDate	date		not null,
	Timeslot	smallint	not null,
	MemberID	int,
	TransactionID	int,
	Booked		bit		not null	default 0,
	Available	bit 		not null	default 1,
	primary key (FacilityID, AvailDate, Timeslot),
	foreign key (FacilityID) 
		references Facilities(FacilityID),
	foreign key (MemberID) 
		references Members(MemberID),
	foreign key (TransactionID) 
		references Transactions(TransactionID)
)
go
