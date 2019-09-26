USE QuickScale
-------------------------------------------------------------------------
DROP TABLE IF EXISTS Users
CREATE TABLE Users(
	 userID       INT         NOT NULL
	,username     VARCHAR(15) NOT NULL
	,userPassword VARCHAR(30) NOT NULL
	,email        VARCHAR(30) NOT NULL
	,PRIMARY KEY (userID)
	)
-------------------------------------------------------------------------
DROP TABLE IF EXISTS Scales
CREATE TABLE Scales(
	 scaleID INT NOT NULL
	,scaleKey VARCHAR(5) NOT NULL
	,scaleMode VARCHAR(5) NOT NULL
	,PRIMARY KEY (scaleID)
	)
-------------------------------------------------------------------------
DROP TABLE IF EXISTS SavedFretBoard
CREATE TABLE SavedFretBoard(
	 fretboardID       INT        NOT NULL
	,numberOfFrets     INT        NOT NULL
	,numberOfStrings   INT        NOT NULL
	,firstStringNote   VARCHAR(5) NOT NULL
	,secondStringNote  VARCHAR(5) NOT NULL
	,thirdStringNote   VARCHAR(5) NOT NULL
	,fourthStringNote  VARCHAR(5) NOT NULL
	,fifthStringNote   VARCHAR(5) NULL
	,sixthStringNote   VARCHAR(5) NULL
	,seventhStringNote VARCHAR(5) NULL
	,eightStringNote   VARCHAR(5) NULL
	,userID			   INT        NOT NULL
	,scaleID           INT        NOT NULL
	,FOREIGN KEY (userID) REFERENCES Users(userID)
	,FOREIGN KEY (scaleID)REFERENCES Scales(scaleID)
	)
	