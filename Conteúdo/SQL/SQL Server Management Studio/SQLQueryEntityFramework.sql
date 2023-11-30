create database banco

create table Clientes
(
	id int primary key identity,
	nome varchar(100),
	email varchar(100)
);

create table Pedido
(
	id int primary key identity,
	datapedido date,
	valor decimal(12,2),
	id_Cliente int,

	foreign key(id_Cliente) references Clientes(id)
);

insert into Clientes (nome, email) values ('Alisson Lamarque', 'alissonlmq@gmail.com')
insert into Clientes (nome, email) values ('Lara Fração', 'larafracao@gmail.com')

insert into Pedido (datapedido, valor, id_Cliente) values ('2023-12-10', 154.50, 1);
insert into Pedido (datapedido, valor, id_Cliente) values ('2023-12-15', 1540.50, 2);

select * from Pedido
