Begin Tran T1
--CREATE DATABASE PramodLoop;
Go

CREATE TABLE GalaDetails
(
    Id INT PRIMARY KEY IDENTITY,
    GalaNo NVARCHAR(50),
	IsActive BIT DEFAULT  1,
	CreateDate DateTime DEFAULT GETDATE(),
	UpdateDate DateTime DEFAULT GETDATE()
)
Go


CREATE TABLE QualityDetails
(
    Id INT PRIMARY KEY IDENTITY,
    QualityType NVARCHAR(50),
	IsActive BIT DEFAULT  1,
	CreateDate DateTime DEFAULT GETDATE(),
	UpdateDate DateTime DEFAULT GETDATE()
)
Go


CREATE TABLE GalaQualitySerialNoTrack
(
    Id INT PRIMARY KEY IDENTITY,
    GalaNo INT,
	QualityType INT,
	SerialNo INT,
	StartDate DateTime,
	EndDate DateTime,
	IsActive BIT DEFAULT  1,
	CreateDate DateTime DEFAULT GETDATE(),
	UpdateDate DateTime DEFAULT GETDATE()

	CONSTRAINT FK_GalaDetails_GalaQualitySerialNoTrack_Id_GalaNo 
		FOREIGN KEY (GalaNo)
		REFERENCES GalaDetails(Id),
	CONSTRAINT FK_QualityDetails_GalaQualitySerialNoTrack_Id_QualityType 
		FOREIGN KEY (QualityType)
		REFERENCES QualityDetails(Id),
)
Go

CREATE TABLE GalaQualitySerialNoTrackHistory
(
    Id INT PRIMARY KEY IDENTITY,
    GalaNo INT,
	QualityType INT,
	SerialNo INT,
	StartDate DateTime,
	EndDate DateTime,
	IsActive BIT DEFAULT  1,
	CreateDate DateTime DEFAULT GETDATE(),
	UpdateDate DateTime DEFAULT GETDATE()

	CONSTRAINT FK_GalaDetails_GalaQualitySerialNoTrackHistory_Id_GalaNo 
		FOREIGN KEY (GalaNo)
		REFERENCES GalaDetails(Id),
	CONSTRAINT FK_QualityDetails_GalaQualitySerialNoTrackHistory_Id_QualityType 
		FOREIGN KEY (QualityType)
		REFERENCES QualityDetails(Id),
)
Go


CREATE TABLE Taka
(
    Id INT PRIMARY KEY IDENTITY,
    GalaNo INT,
	QualityType INT,
	SerialNo INT,
	LoomNo INT,
	Meter DECIMAL,
	NetWeight DECIMAL,
	Avg_NetWeight DECIMAL,
	IsActive BIT DEFAULT  1,
	CreateDate DateTime DEFAULT GETDATE(),
	UpdateDate DateTime DEFAULT GETDATE()

	CONSTRAINT FK_GalaDetails_Inventory_Id_GalaNo 
		FOREIGN KEY (GalaNo)
		REFERENCES GalaDetails(Id),
	CONSTRAINT FK_QualityDetails_Inventory_Id_QualityType 
		FOREIGN KEY (QualityType)
		REFERENCES QualityDetails(Id),
)
Go

 
 -- GalaDetails
Insert into GalaDetails (GalaNo) values ('Boring');
Insert into GalaDetails (GalaNo) values ('Office');
Insert into GalaDetails (GalaNo) values ('90Loom');
Insert into GalaDetails (GalaNo) values ('Deepak');
Insert into GalaDetails (GalaNo) values ('Miraj');
Insert into GalaDetails (GalaNo) values ('Bharni');
Insert into GalaDetails (GalaNo) values ('Padmanagar');

 -- QualityDetails

 Insert into QualityDetails (QualityType) values ('7KG');
 Insert into QualityDetails (QualityType) values ('54GM');
 Insert into QualityDetails (QualityType) values ('58GM');
 Insert into QualityDetails (QualityType) values ('INDO 45GM');
 
-- Commit Tran T1
-- RollBack Tran T1