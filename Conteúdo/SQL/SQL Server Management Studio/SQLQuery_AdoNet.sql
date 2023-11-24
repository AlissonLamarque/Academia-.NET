create database ado_net

create table pessoas
(
	id integer primary key identity,
	nome varchar(50) not null,
	idade integer
)

create login adonet with password='senha1234';
create user adonet from login adonet;

exec sp_addrolemember 'DB_DATAREADER', 'adonet';
exec sp_addrolemember 'DB_DATAWRITER', 'adonet';

insert into pessoas values ('Gabriel', 25), ('Felipe', 33)

select * from pessoas