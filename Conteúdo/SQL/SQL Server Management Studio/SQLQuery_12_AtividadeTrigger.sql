create database Atividade_12_Triggers

create table grupo
(
	id integer not null primary key identity,
	nome varchar(50) not null
)

create table era
(
	id integer not null primary key identity,
	nome varchar(50) not null,
	inicio integer not null,
	fim integer not null,
)

create table pais
(
	id integer not null primary key identity,
	nome varchar(50) not null
)

create table descobridor
(
	id integer not null primary key identity,
	nome varchar(50) not null
)

create table dinossauro
(
	id integer not null primary key identity,
	nome varchar(50) not null,
	fk_Grupo integer,
	toneladas integer,
	anoDescoberta integer,
	fk_Descobridor integer,
	fk_Era integer,
	inicio integer,
	fim integer,
	fk_Pais integer

	foreign key (fk_Grupo) references grupo(id),
	foreign key (fk_Descobridor) references descobridor(id),
	foreign key (fk_Era) references era(id),
	foreign key (fk_Pais) references pais(id),
)

insert into grupo values ('Anquilossauros');
insert into grupo values ('Ceratopsídeos');
insert into grupo values ('Estegossauros');
insert into grupo values ('Terápodes');

insert into era values ('Triássico', 251, 200);
insert into era values ('Jurássico', 200, 145);
insert into era values ('Cretáceo', 145, 65);

insert into pais values ('Mongólia');
insert into pais values ('Canadá');
insert into pais values ('Tanzânia');
insert into pais values ('China');
insert into pais values ('América do Norte');
insert into pais values ('USA');

insert into descobridor values ('Maryanska');
insert into descobridor values ('John Bell Hatcher');
insert into descobridor values ('Cientistas alemães');
insert into descobridor values ('Museu Americano de História Natural');
insert into descobridor values ('Othniel Charles Marsh');
insert into descobridor values ('Barnum Brown');

insert into dinossauro values ('Saichania', 1, 4, 1977, 1, 3, 145, 66, 1);
insert into dinossauro values ('Triceratóps', 2, 6, 1887, 2, 3, 70, 66, 2);
insert into dinossauro values ('Kentrossauro', 3, 2, 1909, 3, 2, 200, 145, 3);
insert into dinossauro values ('Pinacossauro', 1, 6, 1999, 4, 1, 85, 75, 4);
insert into dinossauro values ('Alossauro', 4, 3, 1877, 5, 2, 155, 150, 5);
insert into dinossauro values ('Torossauro', 2, 8, 1891, 2, 3, 67, 65, 6);
insert into dinossauro values ('Anquilossauro', 1, 8, 1906, 6, 1, 66, 63, 5);

select * from grupo;
select * from era;
select * from pais;
select * from descobridor;
select * from dinossauro;

-- Exercício 5

go
create trigger DinoInsert
on dinossauro
after insert
as
	declare @inicio integer;
	declare @fim integer;

	select @inicio = (select inicio from inserted)
	select @fim = (select fim from inserted)
begin
	if (@fim > @inicio)
		begin
			ROLLBACK TRANSACTION;
			print('Período de início e fim da espécie inválido');
		end
end

insert into dinossauro values ('Teste', 1, 10, 1900, 3, 1, 50, 100, 3);

-- Exercício 6

go
create trigger validaInsereDinossauroEra
on dinossauro
after insert
as
begin
	declare @inicioDino int
	declare @fimDino int
	declare @inicioEra int
	declare @fimEra int
 
	select @inicioDino = (select inserted.inicio from inserted)
	select @fimDino = (select inserted.fim from inserted)
	select @inicioEra = (select era.inicio from era where ERAS.id_era = (select inserted.fk_era from inserted))
	select @fimEra = (select era.fim from era where ERAS.id_era = (select inserted.fk_era from inserted))
	if (@inicioDino > @inicioEra) and (@fimDino < @fimEra)
	begin
		-- insert into log values ('Inserção', 'Novo dinossauro inserido em Dinossauros', GETDATE());
		print('Dinossauro inserido com sucesso!')
	end
	else
	begin
		ROLLBACK;
		-- insert into log values ('Inserção', 'tentativa de inserção de novo dinossauro na tabela Dinossauros', GETDATE());
		RAISERROR('INVALIDO', 14,1);
		RETURN;
	end
end