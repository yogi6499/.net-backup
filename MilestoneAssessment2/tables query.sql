use HumanResourceManagement
create table employee(
	id int primary key identity(1,1),
	name nvarchar(20) not null,
	address nvarchar(50) not null,
	Emailid nvarchar(20) unique not null,
	joiningDate date not null,
	contactNumber int not null
);
create table leave(
	leaveid int primary key identity(1,1),
	EmployeeId int not null,
	fromDate date not null,
	toDate date not null,
	fromSession tinyint not null,
	toSession tinyint not null,
	AppliedDays decimal(18,2) not null,
	foreign key(EmployeeId) references employee(id)
);
