CREATE TABLE [dbo].[solar_panel]
(
	[Id]         INT NOT NULL PRIMARY KEY,
	[Name]       varchar(128) NULL,
	[Power]      FLOAT NULL,
	[Efficiency] FLOAT NULL,
	[Count]      INT NULL,
)
