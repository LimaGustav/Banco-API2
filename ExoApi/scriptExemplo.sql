CREATE DATABASE Clinica
GO

USE Clinica
GO
 
CREATE TABLE Medico
(
    Id INT PRIMARY KEY NOT NULL,
    NomeMedico VARCHAR(50),
    Especialidade VARCHAR(50)
);
GO


INSERT Medico VALUES (1,'Fabricio','Cardiologista')
GO

INSERT Medico VALUES (2,'Roberto','Endocrenologista')
GO

INSERT Medico VALUES (3,'Lucas','Endocrenologista')
GO

SELECT * from Medico
GO