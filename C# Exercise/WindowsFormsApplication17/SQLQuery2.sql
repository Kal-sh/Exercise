USE [sql]
GO

/****** Object:  StoredProcedure [dbo].[spinsertuser]    Script Date: 12/25/2021 9:06:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

alter proc [dbo].[spinsertuser]
@userId VARCHAR(20),
@fName VARCHAR(20),
@lName VARCHAR(20),
@uName VARCHAR(20),
@email VARCHAR(20),
@pwd VARCHAR(20),
@cpwd VARCHAR(20),
@job VARCHAR(20),
@photo IMAGE
AS
begin 
insert into lab 
VALUES(@userId,@fName,@lName,@uName,@pwd,@cpwd,@job,@photo)
END



