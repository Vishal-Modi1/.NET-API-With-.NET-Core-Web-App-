--Drop table ItemDetails
CREATE TABLE ItemDetails
(
Id Int Primary Key Identity(1,1),
[Name] Varchar(300) Not Null,
Price Numeric(18,3),
CreateOn Datetime Not null
)

Go

--Drop table Bidders
CREATE TABLE Bidders
(
Id Int Primary Key Identity(1,1),
[Name] Varchar(300) Not Null,
CreateOn Datetime Not null
)

Go

--drop table BidDetails
CREATE TABLE BidDetails
(
Id Int Primary Key Identity(1,1),
ItemId Int,
BidderId Int,
BidAmount Numeric(18,3),
Profit Numeric(18,3),
CreateOn Datetime Not null,
FOREIGN KEY (ItemId) REFERENCES ItemDetails(Id),
FOREIGN KEY (BidderId) REFERENCES Bidders(Id),

)

Go

--drop table Winner
Create Table Winners
(
Id Int Primary Key Identity(1,1),
BidDetailsId Int,
CreateOn Datetime Not null,
FOREIGN KEY (BidDetailsId) REFERENCES BidDetails(Id),
)

Go



delete from Winners
delete from BidDetails
delete from Bidders
delete from ItemDetails
select * from ItemDetails
select * from Bidders
select * from BidDetails
select * from Winners