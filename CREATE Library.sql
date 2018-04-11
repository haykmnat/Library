
IF EXISTS (SELECT * 
	   FROM   master..sysdatabases 
	   WHERE  name = N'Library')
	DROP DATABASE Library	
GO

CREATE DATABASE Library
GO

use Library 
GO

IF OBJECT_ID('Library.users', 'U') IS NOT NULL
  DROP TABLE users
GO

CREATE TABLE users
(
	[uID] int primary key clustered not null, 
	[login] nchar( 15) not null, 
	[password] char( 15) not null
)
go

IF OBJECT_ID('Library.staff', 'U') IS NOT NULL
  DROP TABLE staff
GO

CREATE TABLE staff
(
	[sID] int primary key clustered not null, 
	[name] nvarchar( 30) not null, 
	surname nvarchar( 30) not null,
	middleName nvarchar( 30) null,
	possition nchar( 15) not null,
	passport char(10) not null,
	birthDate date not null,
	[address] nvarchar( 50) not null, 
	phone varchar( 40) not null, -- i mean comma seperated phone numbers list
	phone2 char(14) not null
)
go



IF OBJECT_ID('Library.book', 'U') IS NOT NULL
  DROP TABLE book
GO

CREATE TABLE book
(
	bID int primary key  clustered identity(0,1) not null,
	ISBN13 char(14) null, -- ex. 978-1484230176  
	ISBN10 char(10) null, -- ex. 1484230175
	[name] nvarchar( 60) not null,
	cover varbinary(max) null,
	coverType char(10) not null,
	pubDate char(4) null,
	publish nvarchar(40) null,
	pubCountry char(25) null,
	department char(25) null,
	[language] char(3) null,
	genre nvarchar(50) null,
	[state] int not null,
	[description] nvarchar(max) null,
	restriction varchar(30) null, -- expensive, only one example, old and etc.
	[status] float default(0) null           -- special for Mikayel
)
go

CREATE nonclustered INDEX index_1
ON Library.dbo.book ( [status] )
--WITH PAD_INDEX
--    | FILLFACTOR = fillfactor
--    | IGNORE_DUP_KEY
--    | DROP_EXISTING
--    | STATISTICS_NORECOMPUTE
--    | SORT_IN_TEMPDB, .. as required
-- ON filegroup
GO


if object_id('Library.book_state', 'U') is not null
  drop table Library.book_state
go

create table book_state
(
	bID int primary key clustered not null,
	[state] int not null, -- 0-onShelf, 1-onReadingRoom, 2-onHand, 3-other
	bookType int null, --new, worm out, and etc
	cordinat1 int null,
	cordinat2 int null,
	cordinat3 int null,
	[description] varchar(max) null
)
go

IF OBJECT_ID('Library.category', 'U') IS NOT NULL
  DROP TABLE category
GO

CREATE TABLE category
(
	[code] char(10) primary key clustered not null, 
	[name] char( 25) not null,
)
go



IF OBJECT_ID('Library.author', 'U') IS NOT NULL
  DROP TABLE author
GO

CREATE TABLE author
(
	aID int primary key clustered identity(1,1) not null, 
	[name] char( 30) not null, 
	bID int not null,
	surname char(30) null,
	middleName char(30) null,
	country char(3) null,
	country2 char(3) null,
	country3 char(3) null,
	[language] char(3) null,
	language2 char(3) null,
	language3 char(3) null
)
go




IF OBJECT_ID('Library.operation', 'U') IS NOT NULL
  DROP TABLE operation
GO

CREATE TABLE bookEntries
(
	bID int not null,
	opType char(3) not null, -- book in or out
	opName char( 13) not null,
	[description] nvarchar(300) null,
	opDate datetime	not null,
	bookID int null,
	staffID int not null -- by whom
)
go


if object_id('Library.language', 'U') is not null
  drop table Library.[language]
go

create table [language]
(
	[code] char(3) primary key clustered not null,
	[name] nchar(15) not null
)
go


if object_id('Library.country', 'U') is not null
  drop table Library.country
go

create table country
(
	[code] char(3) primary key clustered not null,
	[name] nchar(15) not null
)
go


if object_id('Library.readers', 'U') is not null
  drop table Library.readers
go

create table readers
(
	[rID] int primary key clustered not null, 
	[name] nvarchar( 30) not null, 
	surname nvarchar( 30) not null,
	middleName nvarchar( 30) null,
	passport char(10) not null,
	birthDate date not null,
	openDate date not null, --reader card open date
	closeDate date null,		--reader card close date
	[address] nvarchar( 50) not null, 
	phone varchar( 40) not null -- i mean comma seperated phone numbers listr
)
go



if object_id('Library.readers_book', 'U') is not null
  drop table Library.readers_book
go

create table readers_book
(
	rID int not null,
	bID int not null,
	uID int not null,
	openDate datetime2 not null, --վելցնելու ժամը ու օրը
	closeDate datetime2 null, --երբ պետք է բերի
	returnDate datetime2 null, -- իրականում երբ է բերել
	readingRoom int null -- եթե կարդալու է ընթերցասրահում, ապա ընթերցասրահի համարը
)
go



if object_id('Library.position', 'U') is not null
  drop table Library.position
go

create table position
(
	pID int primary key not null,
	[name] nchar(15) not null
)
go



if object_id('Library.login_history', 'U') is not null
  drop table Library.login_history
go

create table login_history
(
	uID int primary key not null,
	startDate datetime2 not null,
	endDate datetime2 not null
)
go



if object_id('Library.parameters', 'U') is not null
  drop table Library.[parameters]
go

create table [parameters]
(
	[name] char(10) primary key not null,
	[value] int null
)
go