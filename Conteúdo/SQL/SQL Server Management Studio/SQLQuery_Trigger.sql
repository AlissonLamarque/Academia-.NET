
create table java
(
	professor varchar(50) not null
)
 
create table dotnet
(
	professor varchar(50) not null
)

-- E EVENTO
-- C CONDI��O
-- A A��O

-- triggers

create table log
(
	id integer not null primary key identity,
	acao varchar(15) not null,
	descricao varchar(250),
	quando datetime not null
)

go
create trigger primeiratrigger
on java
after insert -- after | before | instead of | insert
as
begin
	--Condi��o
	insert into log values ('Inser��o', 'Inserindo um novo professor em java', GETDATE())--A��o
	print('Professor inserido com sucesso!')
end

select * from java
select * from log

insert into java values ('Ricardo')

go
create trigger triggerdelete
on java
after delete
as
begin
	insert into log values('Exclus�o', 'O professor foi exclu�do com sucesso', GETDATE());
	print('Exclu�do com sucesso!')
end

delete from java where professor = 'Ricardo';

drop trigger triggerdelete

go
create trigger triggerdelete
on java
after delete
as
	declare @nome varchar(15)
	select @nome = (select deleted.professor from deleted)
begin
	insert into log values ('Exclus�o', 'O professor' + @nome + 'doi excluido da academia Java', GETDATE());
	print(@nome + ' exclu�do com sucesso!');
end

insert into java values ('Fabricio')

delete from java where professor = 'Fabricio'

select * from log
select * from java

drop trigger primeiratrigger

drop trigger triggerinsert

go
create trigger triggerinsert
on java
after insert
as
	declare @quantidade integer
	declare @nome varchar(15)
	select @quantidade = (select count(professor) from java)
	select @nome = (select professor from inserted)
begin
	print('Quantidade de registros: ' + convert(varchar(3), @quantidade));

	IF @quantidade <= 3
		begin
			insert into log values ('Inser��o', 'O professor ' + @nome + ' foi inserido na academia Java', GETDATE())
			print(@nome + ' inserido com sucesso!')
		end
	ELSE
		begin
			ROLLBACK; --desfaz tudo
			insert into log values ('Inser��o', 'O professor ' + @nome + ' n�o foi inserido na academia Java devido ao limite de professores
			ter sido atingido!', GETDATE())
			print(@nome + ' n�o foi inserido!');
			RAISERROR('Regra de 3 professores bloqueou o insert', 14,1)
		end
end

insert into java values ('Guilherme')
delete from java where professor = 'Guilherme'

select * from log
select * from java

go
create trigger triggerupdate
on java
after update
as
	declare @novo varchar(15)
	declare @antigo varchar(15)

	select @novo = (select professor from inserted)
	select @antigo = (select professor from deleted)

	IF(ROWCOUNT_BIG() = 0)
		return;
begin
	if (@novo = @antigo)
		begin
			raiserror('sem altera��es, dados identicos', 14,1);
			rollback transaction;
			insert into log values ('Altera��o', 'Nada alterado, pois ' + @novo + ' n�o foi alterado', GETDATE());
		end
	else
		begin
			insert into log values ('Altera��o', 'Professor ' + @antigo + ' foi substitu�do por ' + @novo, GETDATE());
		end
end

drop trigger triggerupdate

select * from log
select * from java

update java set professor = 'Herysson' where professor = 'Fabricio'
