use master
go

drop database if exists doorSmash
go

create database doorSmash
go

use doorSmash

exec sp_changedbowner 'sa'
go

drop table if exists test
go

create table test
(
	CID				int			primary key identity
	,FirstName		varchar(20)	not null
	,LastName		varchar(20) not null
	,DoB			date		not null
	,YearJoined		smallint	not null
)
go
