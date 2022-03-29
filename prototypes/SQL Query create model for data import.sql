-- Create a new database called 'Integrador'
-- for import local data test on docker
CREATE DATABASE Integrador
-- Create a new table called '[usuario]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[usuario]', 'U') IS NOT NULL
DROP TABLE [dbo].[usuario]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[usuario]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [nome] NVARCHAR(50) NOT NULL,
    [login] NVARCHAR(50) NOT NULL
    [senha] NVARCHAR(50) NOT NULL

);
GO
-- Create a new table called '[Aluno]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Aluno]', 'U') IS NOT NULL
DROP TABLE [dbo].[Aluno]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Aluno]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [usuario_id] NVARCHAR(50) NOT NULL,

);
GO
-- Create a new table called '[preofessor]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[professor]', 'U') IS NOT NULL
DROP TABLE [dbo].[professor]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[professor]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [usuario_id] NVARCHAR(50) NOT NULL,
);
GO
-- Create a new table called '[matricula]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[matricula]', 'U') IS NOT NULL
DROP TABLE [dbo].[matricula]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[matricula]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [aluno] NVARCHAR(50) NOT NULL,
    [turma_id] NVARCHAR(50) NOT NULL
);
GO
-- Create a new table called '[prova]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[prova]', 'U') IS NOT NULL
DROP TABLE [dbo].[prova]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[prova]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [nome] NVARCHAR(50) NOT NULL,
    [professor_id] NVARCHAR(50) NOT NULL
);
GO
-- Create a new table called '[questao]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[questao]', 'U') IS NOT NULL
DROP TABLE [dbo].[questao]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[questao]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [enunciado] NVARCHAR(50) NOT NULL,
    [professor_id] NVARCHAR(50) NOT NULL
);
GO
-- Create a new table called '[avaliacao_aluno]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[avaliacao_aluno]', 'U') IS NOT NULL
DROP TABLE [dbo].[avaliacao_aluno]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[avaliacao_aluno]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [avaliacao_id] NVARCHAR(50) NOT NULL,
    [matricula_id] NVARCHAR(50) NOT NULL,
    [nota] NVARCHAR(50) NOT NULL
);
GO
-- Create a new table called '[turma]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[turma]', 'U') IS NOT NULL
DROP TABLE [dbo].[turma]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[turma]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [nome] NVARCHAR(50) NOT NULL,
    [professor_id] NVARCHAR(50) NOT NULL
);
GO
-- Create a new table called '[avaliacao]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[avaliacao]', 'U') IS NOT NULL
DROP TABLE [dbo].[avaliacao]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[avaliacao]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [turma_id] NVARCHAR(50) NOT NULL,
    [prova_id] NVARCHAR(50) NOT NULL
    -- Specify more columns here
);
GO
-- Create a new table called '[prova_questao]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[prova_questao]', 'U') IS NOT NULL
DROP TABLE [dbo].[prova_questao]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[prova_questao]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [prova_id] NVARCHAR(50) NOT NULL,
    [questao_id] NVARCHAR(50) NOT NULL
);
GO
-- Create a new table called '[alternativa]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[alternativa]', 'U') IS NOT NULL
DROP TABLE [dbo].[alternativa]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[alternativa]
(
    [Id] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [questao_id] NVARCHAR(50) NOT NULL,
    [texto] NVARCHAR(50) NOT NULL,
    [eh_resposta] NVARCHAR(50) NOT NULL
);
GO
