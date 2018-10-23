USE BookingSystem;

Create Table Airline
(
Id int not null IDENTITY(1,1) PRIMARY KEY,
AirlineName nvarchar(6) not null
);

Create Table Airport
(
Id int not null IDENTITY(1,1) PRIMARY KEY,
AirportName nvarchar(3) not null
);

Create Table FlightSectionType
(
Id int not null IDENTITY(1,1) PRIMARY KEY,
FlightSectionName nvarchar(30) not null
);

Create Table Flight
(
Id int not null IDENTITY(1,1) PRIMARY KEY,
FlightId nvarchar(3) not null,
DepartureDate datetime not null,
AirlineId int not null FOREIGN KEY REFERENCES Airline(Id),
OriginId int not null FOREIGN KEY REFERENCES Airport(Id),
DestinationId int not null FOREIGN KEY REFERENCES Airport(Id),
--What's the difference?
--Constraint FK_AirlineID FOREIGN KEY(AirlineId) REFERENCES Airline(Id)
);

Create Table FlightSection
(
Id int not null IDENTITY(1,1) PRIMARY KEY,
FlightId int not null FOREIGN KEY REFERENCES Flight(Id),
FlightSectionTypeId int not null FOREIGN KEY REFERENCES FlightSectionType(Id)
);

Create Table Seat
(
Id int not null IDENTITY(1,1) PRIMARY KEY,
[Row] int not null,
[Column] int not null,
IsTaken bit not null,
FlightSectionId int not null FOREIGN KEY REFERENCES FlightSection(Id)
);



-------------------ADD TEST DATA------------------------------------
--Airports
INSERT INTO Airport
 Values('DEN'),('DFW'),('LON'),('JPN'),('DEH'),('NCE');

 --Airlines
 INSERT INTO Airline
 VALUES ('DELTA'),('AMER'),('JET'),('SWEST'),('FRONT');

 -- manager.CreateFlight("DELTA", "DEN", "LON", 2009, 10, 10, "123");
 --manager.CreateFlight("DELTA", "DEN", "DEH", 2009, 8, 8, "567");
 --manager.CreateFlight("DELTA", "DEN", "NCE", 2010, 9, 8, "567");// should be invalid - Delata already has the id
 --manager.CreateFlight("JET", "LON", "DEN", 2009, 5, 7, "123");
 --manager.CreateFlight("AMER", "DEN", "LON", 2010, 10, 1, "123");
 --manager.CreateFlight("JET", "DEN", "LON", 2010, 6, 10, "786");
 --manager.CreateFlight("JET", "DEN", "LON", 2009, 1, 12, "909");

--Flights
INSERT INTO Flight(AirlineId,OriginId,DestinationId,DepartureDate,FlightId)
VALUES(1,1,3,GETDATE(),'123'),
(1,1,5,GETDATE(),'567'),
(3,3,1,GETDATE(),'123'),
(2,1,3,GETDATE(),'123'),
(3,1,3,GETDATE(),'786'),
(3,1,3,GETDATE(),'909');

--FlightSectionTypes
INSERT INTO FlightSectionType
VALUES ('First'),('Business'),('Economy');

--FlightSections + Seats

INSERT INTO FlightSection(FlightId,FlightSectionTypeId)
VALUES(3,3),(3,1),(1,2),(1,3);

-- Hav added ju
Insert INTO Seat([Row],[Column],IsTaken,FlightSectionId)
VALUES (2,2,0,1),(2,3,0,2),(1,1,0,3),(1,2,0,4);

 --// manager.CreateSection("JET", "123", 2, 2, SeatClassType.Economy);
 --// manager.CreateSection("JET", "123", 1, 3, SeatClassType.Economy);
 --// manager.CreateSection("JET", "123", 2, 3, SeatClassType.First);
 --// manager.CreateSection("DELTA", "123", 1, 1, SeatClassType.Business);
 --// manager.CreateSection("DELTA", "123", 1, 2, SeatClassType.Economy);
 --// manager.CreateSection("SWSERTT", "123", 5, 5, SeatClassType.Economy);//invalid
 GO

 --Create Stored Procedure to find available flights 
 --based on Origin & Destination airports
 CREATE PROCEDURE spFindAvailableFlightsBetween
 @Origin nvarchar(3),@Destination nvarchar(3)
 AS
 Select distinct al.AirlineName, a.AirportName as Origin, aa.AirportName as Destination, fst.FlightSectionName, f.FlightId
 From Flight as f
 Inner Join Airline as al
 ON f.AirlineId = al.Id
 INNER JOIN Airport as a
 ON f.OriginId =a.Id
 Inner Join Airport as aa
 ON f.DestinationId = aa.Id
 INNER Join FlightSection as fs
 ON f.Id = fs.FlightId
 Inner Join FlightSectionType as fst
 ON fs.FlightSectionTypeId = fst.Id
 Inner Join Seat as se
 ON fs.Id = se.FlightSectionId
 Where a.AirportName = @Origin AND aa.AirportName = @Destination
 AND se.IsTaken = 0;
 GO

 exec spFindAvailableFlightsBetween @Origin = 'DEN',@Destination = 'LON'

 GO


 --Create view to display System Information
 CREATE VIEW vFlightsInformation
 AS
 Select al.AirlineName, a.AirportName as Origin, aa.AirportName as Destination, fst.FlightSectionName, f.FlightId, se.[Row], se.[Column],se.IsTaken
 From Flight as f
 Inner Join Airline as al
 ON f.AirlineId = al.Id
 INNER JOIN Airport as a
 ON f.OriginId =a.Id
 Inner Join Airport as aa
 ON f.DestinationId = aa.Id
 INNER Join FlightSection as fs
 ON f.Id = fs.FlightId
 Inner Join FlightSectionType as fst
 ON fs.FlightSectionTypeId = fst.Id
 Inner Join Seat as se
 ON fs.Id = se.FlightSectionId
 AND se.IsTaken = 0;
 GO

 --Airline History Table
 Create Table AirlineHistory
(
Id int not null IDENTITY(1,1) PRIMARY KEY,
AirlineName nvarchar(6) not null
);

GO

 CREATE TRIGGER LineHistory
 ON Airline
 After Insert
 AS
 BEGIN

	 DECLARE @AirlineName nvarchar

       SELECT @AirlineName = INSERTED.AirlineName       
       FROM INSERTED

	   INSERT INTO AirlineHistory
       VALUES(@AirlineName)
 END;
 GO
