CREATE DATABASE CATALOGODINOSSAURO

create table pais
(
	ID integer not null primary key identity,
	nome varchar(30) not null
)

create table era
(
	ID integer not null primary key identity,
	nome varchar(30) not null
)

create table descobridor
(
	ID integer not null primary key identity,
	nome varchar(40) not null
)

create table grupo
(
	ID integer not null primary key identity,
	nome varchar(30) not null
)

create table dinossauro
(
	ID integer not null primary key identity,
	especie varchar(30) not null,
	toneladas integer,
	anoDescoberta integer,
	inicio integer not null,
	fim integer not null,
	fk_pais integer not null,
	fk_era integer not null,
	fk_descobridor integer not null,
	fk_grupo integer not null
	
	foreign key(fk_pais) references pais(ID),
	foreign key(fk_era) references era(ID),
	foreign key(fk_descobridor) references descobridor(ID),
	foreign key(fk_grupo) references grupo(ID)
)

create table descobridor_dinossauro
(
	ID integer not null primary key identity,
	fk_dinossauro integer not null,
	fk_descobridor integer not null

	foreign key(fk_dinossauro) references dinossauro(ID),
	foreign key(fk_descobridor) references descobridor(ID)
)