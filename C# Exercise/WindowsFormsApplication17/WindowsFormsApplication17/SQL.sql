create DATABASE sql;
use sql

CREATE TABLE lab(userId varchar(20) PRIMARY KEY,
firstName VARCHAR(20),
fatherName VARCHAR(20),
userName VARCHAR(10),
pwd VARCHAR(20),
cpwd VARCHAR(20),
job VARCHAR(20))

GO
create proc [spinsertuser]
@userId VARCHAR(20),
@fName VARCHAR(20),
@lName VARCHAR(20),
@uName VARCHAR(20),
@pwd VARCHAR(20),
@cpwd VARCHAR(20),
@job VARCHAR(20)
AS
begin 
insert into lab 
VALUES(@userId,@fName,@lName,@uName,@pwd,@cpwd,@job)
END


CREATE PROC spGetUser
@fn varchar(50),
@ln VARCHAR(50)
AS
SELECT * FROM tblUser
WHERE firstName like @fn+'%'
and fatherName LIKE @ln+'%'