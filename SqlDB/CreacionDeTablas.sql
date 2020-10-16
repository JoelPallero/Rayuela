Use Rayuela
go
create table Administrador(
Id int primary key identity not null,
Nombre varchar(50) not null,
Apellido varchar(50) not null, 
DNI varchar(20) not null,
RolId varchar(20) not null
)
go
create table Terapeutas(
Id int primary key identity not null,
Nombre varchar(50) not null, 
Apellido varchar(50) not null,
DNI varchar(20) not null,
Contraseña nvarchar(50) not null, 
Terapia varchar(50) not null,
RolId varchar(20) not null
)
go
Create table Pacientes(
IdPaciente int primary key identity not null,
Nombre varchar(50) not null, 
Apellido varchar(50) not null,
ObraSocial varchar(50) not null, 
Terapia varchar(50) not null,
DNI varchar(20) not null,
CertificadoDiscapacidad varchar(50) not null,
NroAfiliado varchar(50) not null,
IdTerapeuta int not null,
RolId varchar(20) not null
)
go
create table Turnos(
Id int primary key identity not null,
Dia varchar(10) not null,
HoraInicio varchar(10) not null,
HoraFin varchar(10) not null,
PacienteId int not null,
TerapeutaId int not null
)
go
create table Roles(
Id int primary key identity not null,
Rol varchar(20) not null
)
go
Insert into Roles (Rol) values ('Administrador')
Insert into Roles (Rol) values ('Terapeuta')
Insert into Roles (Rol) values ('Paciente')
