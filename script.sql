use master
go

drop database if exists QuizletLite
go

create database QuizletLite
go

use QuizletLite
go

create table Role(
	Id		int identity(1,1) primary key,
	Role	varchar(30)
)

create table [User](
	Id			int identity(1,1) primary key,
	RoleId		int foreign key references Role(Id),
	Email		varchar(255) not null,
	Username	varchar(26) not null,
	Password	varchar(30) not null
)

create table Quiz(
	Id			int identity(1,1) primary key,
	Name		varchar not null,
	CreatedBy	int foreign key references [User](Id),
	Status		smallint default 0
)

create table QuestionType(
	Id		int identity(1,1) primary key,
	Name	varchar(30) not null
)

create table Question(
	Id				int identity(1,1) primary key,
	Content			varchar(255) not null,
	QuizId	int foreign key references Quiz(Id),
	QuestionTypeId	int foreign key references QuestionType(Id)
)

create table Answer(
	Id			int identity(1,1) primary key,
	Content		varchar(255) not null,
	QuestionId	int foreign key references Question(Id),
	IsCorrect	bit
)

create table QuizResult(
	Id			int identity(1,1) primary key,
	UserId		int foreign key references [User](Id),
	QuizId		int foreign key references Quiz(Id),
	Score		float not null
)

create table SelectedAnswer(
	Id					int identity(1,1) primary key,
	QuizResultId		int foreign key references QuizResult(Id),
	QuestionId			int foreign key references Question(Id),
	AnswerId			int foreign key references Answer(Id)
)
