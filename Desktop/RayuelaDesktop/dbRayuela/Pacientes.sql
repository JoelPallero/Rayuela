CREATE TABLE [dbo].[Pacientes]
(
	Id int primary key identity not null,
	Nombre varchar(50) not null, 
	Apellido varchar(50) not null,
	TipoDocumento varchar (30) not null,
	NroDocumento varchar(20) not null,
	ObraSocial varchar(50) not null,
	NroAfiliado varchar(50) not null, 
	CertificadoDiscapacidad varchar(50) not null,
	NroCarnetDiscapacidad int not null,
	Terapia varchar(50) not null
)
