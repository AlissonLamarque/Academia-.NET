drop database MiniERP
create database MiniERP

use MiniERP

create table fornecedor
(
	id integer not null primary key identity,
	nome varchar(50),
	cnpj varchar(14)
)

create table produto
(
    id integer not null primary key identity,
    nome varchar(50),
    descricao varchar(200),
	valor decimal(12,2),
	fk_fornecedor integer,

	foreign key(fk_fornecedor) references fornecedor(id)
)

create table cliente
(
	id integer not null primary key identity,
	nome varchar(50),
	email varchar(50)
)

create table nota
(
	id integer not null primary key identity,
	fk_produto integer,
	fk_cliente integer

	foreign key(fk_produto) references produto(id),
	foreign key(fk_cliente) references cliente(id)
)

select * from fornecedor
select * from cliente
select * from produto

drop table nota

-- Ferramentas -> Pacote Nugget -> Console

-- Scaffold-DbContext "Data Source=localhost; Initial Catalog=MiniERP; User ID=aulaentity; password=senha_1234; language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;"