create table Administrador(
Id int primary key identity (1000, 1) not null,
Nombre varchar(50) not null,
Apellido varchar(50) not null, 
DNI varchar(20) not null,
Usuario varchar(20) not null,
Clave nvarchar(50) not null
)
go
create table Terapeutas(
Id int primary key identity (1000, 1) not null,
Nombre varchar(50) not null, 
Apellido varchar(50) not null,
TipoDocumento varchar (30) not null,
NroDocumento varchar(20) not null,
Contraseña nvarchar(50) not null, 
Terapia varchar(50) not null
)
go
Create table Pacientes(
Id int primary key identity (1000, 1) not null,
Nombre varchar(50) not null, 
Apellido varchar(50) not null,
TipoDocumento varchar (30) not null,
NroDocumento varchar(20) not null,
ObraSocial varchar(50) not null, 
NroAfiliado varchar(50) not null,
CertificadoDiscapacidad varchar(50) not null,
NroCarnetDiscapacidad varchar(50) null,
Terapia varchar(50) not null
)
go
create table Calendario(
Id int primary key identity (1000, 1) not null,
Dia varchar(10) not null,
HoraInicio varchar(10) not null,
HoraFin varchar(10) not null,
PacienteId int not null,
TerapeutaId int not null
)


alter table Calendario
   add constraint fk_Calendario_Terapeuta foreign key (TerapeutaId)
      references Terapeutas (Id)
      go
alter table Calendario
   add constraint fk_Calendario_Paciente foreign key (PacienteId)
      references Pacientes (Id)

alter table TablaDondeEstaFK
   add constraint NombreDeLaRestriccion foreign key (ColumnaFK)
      references TablaDondeEstaPK (ColumnaPK)



truncate table Terapeutas