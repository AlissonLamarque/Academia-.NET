CREATE PROCEDURE procedimento (@parametro int)
AS
	teu codigo


create procedure teste
as
select 'Fabrício' as Nome

exec teste
execute teste

create procedure teste2
with encryption
as
select especie, year(anoDescoberta) as Ano
from dinossauro

exec teste2

drop procedure teste2

exec sp_helptext teste2

create procedure teste3 (@par as int)
as
select @par

exec teste3 5

create procedure teste4 (@ano as Int)
as
select * from dinossauro where year(anoDescoberta) = @ano

exec teste4 1999

create procedure teste5 (@nome as Varchar(50))
as
insert into descobridor values (@nome)

exec teste5 @nome='Isaque'


-- Retornar o nome dos dinossauros que pertencem ao nome do grupo informado
-- Faça uma store procedure que receba dois parametros, um ID e um peso em toneladas. Altere o peso do dinossauro  pelo seu ID.