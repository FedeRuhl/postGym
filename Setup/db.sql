create table tablaPersona
(
	 idPersona int not null,
	 nombrePersona varchar (100),
	 constraint [Pk_idPersona] primary key (idPersona)
 )

 create table tablaDetallesPersona
 (
	idDetalles int not null,
	idPersona int not null,
	fotoPersona nvarchar (200),
	alturaPersona float,
	pesoPersona float,
	fecha datetime
	constraint [Pk_idDetallesPersona] primary key (idDetalles)
	constraint [Fk_idPersona] foreign key (idPersona) references tablaPersona (idPersona)
 )

 create table tablaEjercicio
 (
	idEjercicio int not null,
	nombreEjercicio nvarchar (50)
	constraint [Pk_idEjercicio] primary key (idEjercicio)
 )

 create table tablaDetallesEjercicio
 (
	idDetalles int not null,
	idEjercicio int not null,
	idPersona int not null,
	cantidadSeries int,
	fecha date,
	constraint [Pk_idDetallesEjercicio] primary key (idDetalles),
	constraint [Fk_idEjercicio] foreign key (idEjercicio) references tablaEjercicio (idEjercicio),
	constraint [Fk_idPersonaa] foreign key (idPersona) references tablaPersona (idPersona)
 )

 create table tablaSerie
 (
	idSerie int not null,
	idDetallesEjercicio int not null,
	peso float
	constraint [Pk_idSerie] primary key (idSerie)
	constraint [Fk_idDetallesEjercicio] foreign key (idDetallesEjercicio) references tablaDetallesEjercicio (idDetalles)
 )

 create procedure crearPersona
 
	@idPersona int, @nombrePersona nvarchar(50)

	as

	if (not exists (select idPersona from tablaPersona where idPersona = @idPersona))
	insert into tablaPersona (idPersona, nombrePersona) values (@idPersona, @nombrePersona)
 
 create procedure crearEjercicio

 @idEjercicio int, @nombreEjercicio nvarchar(50)

as

if not exists(select idEjercicio from tablaEjercicio where idEjercicio = @idEjercicio)
insert into tablaEjercicio (idEjercicio, nombreEjercicio) values (@idEjercicio, @nombreEjercicio)

create procedure actualizaPersona

@idPersona int, @nombrePersona varchar(50), @fotoPersona nvarchar(200), @alturaPersona float, @pesoPersona float

as


declare @idDetalles int 
if not exists(select idDetalles from tablaDetallesPersona)
set @idDetalles = 0


else 
set @idDetalles = (select top 1 idDetalles from tablaDetallesPersona  order by idDetalles DESC) + 1


if exists (select idPersona from tablaPersona where idPersona =@idPersona)
DECLARE @TheDate datetime, @Today datetime
SET @TheDate = GetDate()
SET @Today = DateAdd(dd, DateDiff(dd, 0, @TheDate), 0)

insert into tablaDetallesPersona (idPersona, idDetalles ,fotoPersona, alturaPersona, pesoPersona, fecha) 
values (@idPersona, @idDetalles, @fotoPersona, @alturaPersona, @pesoPersona, DateAdd(s, DateDiff(s, @Today, @TheDate), @Today))

create procedure actualizaDetallesEjercicio

@nombrePersona nvarchar(100), @nombreEjercicio nvarchar(50), @fecha date, @cantidadSeries int

AS
declare @idPersona int
declare @idEjercicio int
declare @idDetallesEjercicio int 

set @idPersona = (select idPersona from tablaPersona where nombrePersona = @nombrePersona)
set @idEjercicio = (select idEjercicio from tablaEjercicio where nombreEjercicio = @nombreEjercicio)

if not exists(select idDetalles from tablaDetallesEjercicio)
set @idDetallesEjercicio = 0

else 
set @idDetallesEjercicio = (select top 1 idDetalles from tablaDetallesEjercicio  order by idDetalles DESC) + 1


if exists (select idEjercicio from tablaEjercicio where idEjercicio = @idEjercicio) 
insert into tablaDetallesEjercicio (idPersona, idEjercicio, idDetalles, cantidadSeries, fecha) values
(@idPersona, @idEjercicio, @idDetallesEjercicio, @cantidadSeries, @fecha)

create procedure crearSerie

@peso float, @nombreEjercicio nvarchar(50)

as

declare @idEjercicio int
set @idEjercicio = (select idEjercicio from tablaEjercicio where nombreEjercicio = @nombreEjercicio)

declare @idDetalles int
set @idDetalles = (select top 1 idDetalles from tablaDetallesEjercicio order by idDetalles DESC)

/*select top 1 idDetalles from tablaDetallesEjercicio order by idDetalles DESC*/

declare @idSerie int 
if not exists(select idSerie from tablaSerie)
set @idSerie = 0

else 
set @idSerie = (select top 1 idSerie from tablaSerie  order by idSerie DESC) + 1

if not exists(select idSerie from tablaSerie where idSerie = @idSerie)
insert into tablaSerie (idSerie, peso, idDetallesEjercicio) values (@idSerie, @peso, @idDetalles)

create procedure eliminarDetallesEjercicio

@idDetalles int

as

if exists (select idDetalles from tablaDetallesEjercicio where idDetalles = @idDetalles)
delete from tablaSerie where idDetallesEjercicio = @idDetalles
delete from tablaDetallesEjercicio where idDetalles = @idDetalles


create procedure eliminarDetallesPersona

@idDetalles int

as

if exists (select idDetalles from tablaDetallesPersona where idDetalles = @idDetalles)
delete from tablaDetallesPersona where idDetalles = @idDetalles

create procedure eliminarEjercicio

@idEjercicio int

as

if exists (select idEjercicio from tablaEjercicio where idEjercicio = @idEjercicio)
declare @detalles as int
declare rs cursor for
select idDetalles 
from tablaDetallesEjercicio
where idEjercicio = @idEjercicio

open rs 
	fetch next from rs
	into @detalles
	while @@FETCH_STATUS = 0
		begin	
		delete from tablaSerie where idDetallesEjercicio = @detalles
		fetch next from rs
		into @detalles
	end
close rs
deallocate rs

delete from tablaDetallesEjercicio where idEjercicio = @idEjercicio
delete from tablaEjercicio where idEjercicio = @idEjercicio

create procedure eliminarPersona

@idPersona int

as

if exists (select idPersona from tablaPersona where idPersona = @idPersona)
declare @detalles as int
declare rs cursor for
select idDetalles 
from tablaDetallesEjercicio
where idPersona = @idPersona

open rs 
	fetch next from rs
	into @detalles
	while @@FETCH_STATUS = 0
		begin
		delete from tablaSerie where idDetallesEjercicio = @detalles
		fetch next from rs
		into @detalles
	end
close rs
deallocate rs

delete from tablaDetallesEjercicio where idPersona = @idPersona
delete from tablaDetallesPersona where idPersona = @idPersona
delete from tablaPersona where idPersona = @idPersona

create procedure modificarEjercicio

@idEjercicio int, @nombreEjercicio nvarchar(50)

as

if exists (select idEjercicio from tablaEjercicio where idEjercicio = @idEjercicio)
update tablaEjercicio set nombreEjercicio = @nombreEjercicio where idEjercicio = @idEjercicio

create procedure modificarPersona

@idPersona int, @nombrePersona nvarchar(50)

as

if exists (select idPersona from tablaPersona where idPersona = @idPersona)
update tablaPersona set nombrePersona = @nombrePersona where idPersona = @idPersona

create procedure unirEjercicio /* PARA WINDOWS 10*/

as

SELECT
    nombrePersona, tablaEjercicio.idEjercicio, tablaDetallesEjercicio.idDetalles, nombreEjercicio, cantidadSeries, 
    STRING_AGG(tablaSerie.peso,', ') 'Lista de pesos', tablaDetallesEjercicio.fecha
FROM
	tablaEjercicio inner join tablaDetallesEjercicio on tablaEjercicio.idEjercicio = tablaDetallesEjercicio.idEjercicio
    inner join tablaSerie on tablaDetallesEjercicio.idDetalles = tablaSerie.idDetallesEjercicio
	inner join tablaPersona on tablaDetallesEjercicio.idPersona = tablaPersona.idPersona
GROUP BY
    nombrePersona, tablaEjercicio.idEjercicio, tablaDetallesEjercicio.idDetalles, nombreEjercicio, cantidadSeries, tablaDetallesEjercicio.fecha

create procedure unirEjercicio /*PARA WINDOWS ANTERIORES*/
SELECT nombrePersona, tablaEjercicio.idEjercicio, tablaDetallesEjercicio.idDetalles, nombreEjercicio, cantidadSeries,
STUFF(
(SELECT
    ', ' + CONVERT (VARCHAR(50), tablaSerie.peso,128)
FROM
	 tablaSerie
FOR XML PATH ('')), 
1,1, '') as Pesos, tablaDetallesEjercicio.fecha
FROM tablaEjercicio inner join tablaDetallesEjercicio on tablaEjercicio.idEjercicio = tablaDetallesEjercicio.idEjercicio
    inner join tablaSerie on tablaDetallesEjercicio.idDetalles = tablaSerie.idDetallesEjercicio
	inner join tablaPersona on tablaDetallesEjercicio.idPersona = tablaPersona.idPersona
GROUP BY nombrePersona, tablaEjercicio.idEjercicio, tablaDetallesEjercicio.idDetalles, nombreEjercicio, cantidadSeries,
tablaDetallesEjercicio.fecha


create procedure unirPersona

as

select
P.idPersona, DP.idDetalles, P.nombrePersona, DP.alturaPersona, DP.pesoPersona, DP.fecha
from 
tablaPersona P inner join tablaDetallesPersona DP on P.idPersona = DP.idPersona