
create table editora
(
	ID integer not null primary key identity,
	nome varchar(50) not null
)

create table autor
(
	ID integer not null primary key identity,
	nome varchar(50) not null,
	nacionalidade varchar(30)
)

create table categoria
(
	ID integer not null primary key identity,
	nome varchar(50) not null,
)

create table livro
(
	isbn varchar(20) not null primary key,
	titulo varchar(50) not null,
	ano integer,
	fk_editora integer not null,
	fk_categoria integer not null,

	foreign key (fk_editora) references editora(ID),
	foreign key (fk_categoria) references categoria(ID)
)

create table livro_autor
(
	fk_autor integer not null,
	fk_livro varchar(20) not null,

	foreign key (fk_autor) references autor(ID),
	foreign key (fk_livro) references livro(isbn)
)

delete from autor
delete from categoria
delete from editora

select * from autor
select * from categoria
select * from editora
select * from livro

INSERT INTO categoria
VALUES ('Literatura Juvenil');
INSERT INTO categoria
VALUES ('Ficção Centífica');
INSERT INTO categoria
VALUES ('Humor');
 
INSERT INTO editora
VALUES ('Rocco');
INSERT INTO editora
VALUES ('Wmf Martins Fontes');
INSERT INTO editora
VALUES ('Casa da Palavra');
INSERT INTO editora
VALUES ('Belas Letras');
INSERT INTO editora
VALUES ('Matrix');
 
INSERT INTO autor
VALUES ('J. K. Rowling', 'Inglaterra');
INSERT INTO autor
VALUES ('Clive Staples Lewis', 'Inglaterra');
INSERT INTO autor
VALUES ('Affonso Solano', 'Brasil');
INSERT INTO autor
VALUES ('Marcos Piangers', 'Brasil');
INSERT INTO autor
VALUES ('Ciro Botelho', 'Brasil');
INSERT INTO autor
VALUES ('Bianca Mól', 'Brasil');
INSERT INTO autor
VALUES ('Tiririca', 'Brasil');
 
INSERT INTO livro
VALUES ('5132135123', 'Harry Potter e a pedra filosofal', 2000, 1, 1);
INSERT INTO livro
VALUES ('1231215123', 'As Crônicas de Nárnia', 2009, 2, 1);
INSERT INTO livro
VALUES ('5123123158', 'O espadachim de carvão', 2013, 3, 2);
INSERT INTO livro
VALUES ('4125124123', 'O Papai é Pop', 2015, 4, 3);
INSERT INTO livro
VALUES ('5234523432', 'Pior que tá não fica', 2015, 5, 3);
INSERT INTO livro
VALUES ('6345623423', 'Garota desdobrável', 2015, 3, 1);
INSERT INTO livro
VALUES ('5123543532', 'Harry Potter e o prisoneiro de Azkaban', 2000, 1, 1);
 
INSERT INTO livro_autor
VALUES (1, '5132135123');
INSERT INTO livro_autor
VALUES (2, '1231215123');
INSERT INTO livro_autor
VALUES (3, '5123123158');
INSERT INTO livro_autor
VALUES (4, '4125124123');
INSERT INTO livro_autor
VALUES (5, '5234523432');
INSERT INTO livro_autor
VALUES (6, '6345623423');
INSERT INTO livro_autor
VALUES (1, '5123543532');
INSERT INTO livro_autor
VALUES (7, '5234523432');


select livro.isbn, livro.titulo, livro.ano, autor.nome, editora.nome, categoria.nome
from livro, editora, categoria, autor, livro_autor
where livro.fk_editora = editora.ID and
	livro.fk_categoria = categoria.ID and
	livro_autor.fk_livro = livro.isbn and
	livro_autor.fk_autor = autor.ID
order by autor.nome asc

select livro.isbn, livro.titulo, livro.ano, categoria.nome
from livro, categoria
where livro.fk_categoria = categoria.id and
		categoria.nome = 'Literatura Juvenil'
order by livro.titulo

select livro.isbn, livro.titulo, livro.ano, autor.nome, editora.nome, categoria.nome
from livro, editora, categoria, livro_autor, autor
where livro.fk_editora = editora.id and
	livro.fk_categoria = categoria.id and
	livro_autor.fk_livro = livro.isbn and
	livro_autor.fk_autor = autor.id and
	categoria.nome = 'Literatura Juvenil'
order by livro.ano


SELECT livro.isbn, livro.titulo, livro.ano, autor.nome, editora.nome as editora, categoria.nome as categoria 
from livro, editora, categoria, livro_autor, autor
WHERE livro.fk_editora = editora.id AND
	livro.fk_categoria = categoria.id AND
	livro_autor.fk_livro = livro.isbn AND
	livro_autor.fk_autor = autor.id AND
	(categoria.nome = 'Humor' OR categoria.nome = 'Ficção Científica') AND
	(ano > 2000 AND ano < 2010)
ORDER BY nome asc;

select * from livro