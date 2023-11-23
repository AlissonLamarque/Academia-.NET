create table java
(
	professor varchar(50) null
)
 
create table net
(
	professor varchar(50) null
)

insert into net values ('Fabr�cio'), ('Ricardo'), ('Alexandre')
insert into java values ('Fabr�cio'), ('Gabriel'), ('Luan')

-- inner join
select * from java
inner join net on java.professor = net.professor

-- left join
select * from java
left join net on java.professor = net.professor

-- left join exclusivo
select * from java
left join net on java.professor = net.professor
where net.professor is null

-- right join
select * from java
right join net on java.professor = net.professor

-- right join exclusivo
select * from java
right join net on java.professor = net.professor
where java.professor is null

-- outer join
select * from java
full outer join net on java.professor = net.professor

-- outer join exclusivo
select * from java
full outer join net on java.professor = net.professor
where java.professor is null or net.professor is null