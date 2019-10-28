IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'db_directiva')
BEGIN
	ALTER DATABASE [db_directiva] SET OFFLINE WITH ROLLBACK IMMEDIATE;
	ALTER DATABASE [db_directiva] SET ONLINE;
	DROP DATABASE [db_directiva];
END
GO
/*******************************************************************************
   Create database
********************************************************************************/
CREATE DATABASE [db_directiva];
GO

USE [db_directiva];
GO

--Tabla Personas

CREATE TABLE Personas
(IdPersona VARCHAR(6) NOT NULL,
PrimerNombre VARCHAR(50) NOT NULL,
SegundoNombre VARCHAR(50),
TercerNombre VARCHAR(50),
PrimerApellido VARCHAR(50) NOT NULL,
SegundoApellido VARCHAR(50),
Telefono VARCHAR(9),
Email VARCHAR(50)
--Llave primaria
CONSTRAINT pk_persona PRIMARY KEY (IdPersona)
)
GO

--Tabla Profesores

CREATE TABLE Profesores
(IdProfesor VARCHAR(6) NOT NULL,
IdPersona VARCHAR(6) NOT NULL
--Llave primaria 
CONSTRAINT pk_profesor PRIMARY KEY (IdProfesor),
--Llaves foraneas 
CONSTRAINT fk_persona_pro foreign KEY(IdPersona) REFERENCES Personas(IdPersona),
--Restricciones
CONSTRAINT uq_persona_profesor UNIQUE (IdPersona)
)
GO

--Tabla Grados

CREATE TABLE Grados
(IdGrado VARCHAR(6) NOT NULL,
Grado int,
--Llave primaria
CONSTRAINT pk_grado PRIMARY KEY (IdGrado),
--Restricciones
CONSTRAINT ck_grado CHECK (Grado>=1 AND Grado<=9)
)
GO

--Tabla Secciones

CREATE TABLE Secciones 
(IdSeccion VARCHAR(6) NOT NULL,
IdGrado VARCHAR(6) NOT NULL,
IdProfesor VARCHAR(6) NOT NULL,
Seccion VARCHAR(1) NOT NULL
--Llave primaria 
CONSTRAINT pk_seccion PRIMARY KEY (IdSeccion),
--Llave foranea 
CONSTRAINT fk_grado_sec foreign KEY(IdGrado) REFERENCES Grados(IdGrado),
CONSTRAINT fk_profesor_sec foreign KEY(IdProfesor) REFERENCES Profesores(IdProfesor),
--Restricciones
CONSTRAINT ck_seccion CHECK (Seccion in('A', 'B', 'C'))
)
GO

--Tabla Cargo

CREATE TABLE Cargos
(IdCargo VARCHAR(6) NOT NULL,
Cargo VARCHAR(50) NOT NULL
--Llave primaria 
CONSTRAINT pk_cargo PRIMARY KEY (IdCargo),
--Restricciones
CONSTRAINT ck_cargo CHECK (Cargo in('Presidente', 'Vicepresidente', 'Tesorer@', 'Secretari@', 'Vocal 1', 'Vocal 2', 'Vocal 3'))
)
GO

--Tabla Padres

CREATE TABLE Padres 
(IdPadre VARCHAR(6) NOT NULL,
IdPersona VARCHAR(6) NOT NULL
--Llave primaria
CONSTRAINT pk_padre PRIMARY KEY (IdPadre),
--Llaves foraneas 
CONSTRAINT fk_persona_pad foreign KEY(IdPersona) REFERENCES Personas(IdPersona),
--Restricciones
CONSTRAINT uq_persona_padre UNIQUE (IdPersona)
)
GO

--Tabla Alumnos

CREATE TABLE Alumnos 
(IdAlumno VARCHAR(6) NOT NULL,
IdPadre VARCHAR(6) NOT NULL,
IdPersona VARCHAR(6) NOT NULL,
IdSeccion VARCHAR(6) NOT NULL,
Carnet VARCHAR(8)
--Llave primaria
CONSTRAINT pk_alumno PRIMARY KEY (IdAlumno),
--Llave foranea
CONSTRAINT fk_padre_alu foreign KEY(IdPadre) REFERENCES Padres(IdPadre),
CONSTRAINT fk_persona_alu foreign KEY(IdPersona) REFERENCES Personas(IdPersona),
CONSTRAINT fk_seccion_alu foreign KEY(IdSeccion) REFERENCES Secciones(IdSeccion),
--Restricciones
CONSTRAINT uq_persona_alumno UNIQUE (IdPersona)
)
GO


--Tabla Directivas

CREATE TABLE Alumnos_Directivas 
(IdDirectiva VARCHAR(6) NOT NULL,
IdAlumno VARCHAR(6) NOT NULL,
IdCargo VARCHAR(6) NOT NULL
--Llave primaria 
CONSTRAINT pk_directiva PRIMARY KEY (IdDirectiva),
--Llave foranea 
CONSTRAINT fk_alumno_adi foreign KEY(IdAlumno) REFERENCES Alumnos(IdAlumno),
CONSTRAINT fk_cargo_adi foreign KEY(IdCargo) REFERENCES Cargos(IdCargo)
)
GO

--Tabla Padres_Directivas

CREATE TABLE Padres_Directivas
(
IdDirectiva VARCHAR(6),
IdPadre VARCHAR(6),
IdCargo VARCHAR(6)
--Llaves foreneas
CONSTRAINT fk_padre_pdi foreign KEY(IdPadre) REFERENCES Padres(IdPadre),
CONSTRAINT fk_cargo_pdi foreign KEY(IdCargo) REFERENCES Cargos(IdCargo)
)
GO

--Tabla Usuarios

CREATE TABLE Usuarios
(
IdUsuario VARCHAR(6) NOT NULL,
IdProfesor VARCHAR(6) NOT NULL,
TipoUsuario int,
Correo VARCHAR(50),
Clave VARCHAR(16)
--Llave primaria 
CONSTRAINT pk_usuario PRIMARY KEY (IdUsuario),
CONSTRAINT fk_profesor_usu foreign KEY(IdProfesor) REFERENCES Profesores(IdProfesor),
--Restricciones
CONSTRAINT uq_correo UNIQUE (Correo)
)



------------INSERTS---------------------

INSERT INTO Personas VALUES('P00001', 'Diego', 'Aldair', '', 'Vasquez', 'Arias', '', '');
INSERT INTO Personas VALUES('P00002', 'Ronald', 'Alexander', '', 'Bonilla', 'Umanzor', '', '');
INSERT INTO Personas VALUES('P00003', 'David', 'Alejandro', '', 'Valencia', 'Guzman', '', '');
INSERT INTO Personas VALUES('P00004', 'Lisbeth', 'Susana', '', 'Gonzalez', 'Arias', '', '');
INSERT INTO Personas VALUES('P00005', 'Axel', 'Vladimir', '', 'Menjivar', 'Perez', '', '');
INSERT INTO Personas VALUES('P00006', 'Ernesto', 'Sebastián', '', 'Morales', 'Pineda', '', '');
INSERT INTO Personas VALUES('P00007', 'Victor', 'Rene', '', 'Castro', 'Gonzalez', '', '');
INSERT INTO Personas VALUES('P00008', 'Maria', 'Victoria', '', 'Prudencio', 'Rivas', '', '');
INSERT INTO Personas VALUES('P00009', 'Fernanda', 'Paola', '', 'Tobar', 'Castillo', '', '');

INSERT INTO Profesores VALUES('PR0001', 'P00001');
INSERT INTO Profesores VALUES('PR0002', 'P00002');
INSERT INTO Profesores VALUES('PR0003', 'P00003');
INSERT INTO Profesores VALUES('PR0004', 'P00004');
INSERT INTO Profesores VALUES('PR0005', 'P00005');
INSERT INTO Profesores VALUES('PR0006', 'P00006');
INSERT INTO Profesores VALUES('PR0007', 'P00007');

INSERT INTO Usuarios VALUES('U00001','PR0001', 1, 'admin@correo.com', 'clave');

--------------GRADOS----------------------

INSERT INTO Grados VALUES('G00001', 1);
INSERT INTO Grados VALUES('G00002', 2);
INSERT INTO Grados VALUES('G00003', 3);
INSERT INTO Grados VALUES('G00004', 4);
INSERT INTO Grados VALUES('G00005', 5);
INSERT INTO Grados VALUES('G00006', 6);
INSERT INTO Grados VALUES('G00007', 7);
INSERT INTO Grados VALUES('G00008', 8);
INSERT INTO Grados VALUES('G00009', 9);

-----------------SECCIONES-----------------------

INSERT INTO Secciones VALUES('S00001', 'G00001', 'PR0001', 'A');
INSERT INTO Secciones VALUES('S00002', 'G00001', 'PR0002', 'B');
INSERT INTO Secciones VALUES('S00003', 'G00001', 'PR0003', 'C');

------------PADRES-----------------------

INSERT INTO Padres VALUES('PA0001', 'P00008');

------------ALUMNOS------------------------

INSERT INTO Alumnos VALUES('A00001', 'PA0001', 'P00009', 'S00001', 'VA172839');

---------------CARGOS----------------------

INSERT INTO Cargos VALUES('C00001', 'Presidente');

-------------SELECTS---------------------

SELECT * FROM Personas
SELECT * FROM Profesores
SELECT * FROM Grados
SELECT * FROM Secciones
SELECT * FROM Cargos
SELECT * FROM Padres
SELECT * FROM Alumnos
SELECT * FROM Alumnos_Directivas
SELECT * FROM Padres_Directivas
SELECT * FROM Usuarios

