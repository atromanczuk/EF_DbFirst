--Create database db_first

create table Post (
PostId int not null IDENTITY,
Title varchar(50),
Body text,
CONSTRAINT PK_PostId PRIMARY KEY CLUSTERED (PostId)
)

--drop table Post