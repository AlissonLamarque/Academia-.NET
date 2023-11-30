create database aulaentity

create login aulaentity with password='senha_1234'
create user aulaentity from login aulaentity

EXEC sp_addrolemember 'DB_DATAREADER', 'aulaentity';
EXEC sp_addrolemember 'DB_DATAWRITER', 'aulaentity';

select * from Pessoas
select * from Emails