create table hospitals
(
	hospitalID int primary key,
	hospitalName varchar(50) not null,
	donorId INT NOT NULL REFERENCES Donors(donorId)
)
GO
create table patiantDonors
(
	donorID int not null ,
	patiantID int not null ,
	timeOfDonation date not null
	PRIMARY KEY (donorID, patiantID)
)