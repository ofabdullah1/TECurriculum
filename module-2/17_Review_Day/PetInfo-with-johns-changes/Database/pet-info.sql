
-- Switch to the system (aka master) database
USE master;
GO

-- Delete the Database (IF EXISTS)
IF EXISTS(select * from sys.databases where name='pet-info')
DROP DATABASE [pet-info];
GO

-- Create a new World Database
CREATE DATABASE [pet-info];
GO

-- Switch to the World Database
USE [pet-info]
GO

-- Begin a TRANSACTION that must complete with no errors
BEGIN TRANSACTION;

GO
CREATE TABLE [pets](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](60) NOT NULL,
	[type] [nvarchar](60) NOT NULL,
	[breed] [nvarchar](60) NOT NULL,
	CONSTRAINT pk_pets_id PRIMARY KEY (id)
);

CREATE TABLE [users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](255) NOT NULL,
	[password_hash] [varchar](48) NOT NULL,
	[salt] [varchar](256) NOT NULL,
	CONSTRAINT pk_users_user_id PRIMARY KEY (user_id)
);
	

GO
SET IDENTITY_INSERT [dbo].[pets] ON 
INSERT [dbo].[pets] ([id], [name], [type], [breed]) VALUES (1, N'Bella', N'dog', N'GSD')
INSERT [dbo].[pets] ([id], [name], [type], [breed]) VALUES (2, N'Primrose', N'cat', N'DSH')
INSERT [dbo].[pets] ([id], [name], [type], [breed]) VALUES (3, N'Gabriel', N'cat', N'DSH')
INSERT [dbo].[pets] ([id], [name], [type], [breed]) VALUES (4, N'Penelope', N'cat', N'DSH')
SET IDENTITY_INSERT [dbo].[pets] OFF

GO

SET IDENTITY_INSERT [dbo].[users] ON 
-- admin, admin
INSERT [dbo].[users] ([user_id], [username], [password_hash], [salt]) VALUES (1, N'admin', N'BdxyDMZv4QOGdg6OzM/rTMeHO2k=', N't23AJ8cY+HI=')
SET IDENTITY_INSERT [dbo].[users] OFF
GO

COMMIT TRANSACTION;
