----------------------------------------------Creating and using database----------------------------------------------
DROP DATABASE IF EXISTS GuitarApp;
CREATE DATABASE GuitarApp;
USE GuitarApp;
-----------------------------------------------Making appUser Table----------------------------------------------------
DROP TABLE IF EXISTS appUser
CREATE TABLE appUser
(
	 userid		  INT	        NOT NULL  --I want people to be able to use the app without
	,firstname	  NVARCHAR(20)  NULL	  --needing to make an account. They will just be 
	,lastname	  NVARCHAR(20)  NULL	  --assigned a random userid temporarily
	,email	      NVARCHAR(35)  NULL
	,userpassword NVARCHAR(20)  NULL
	,skilllevel	  NVARCHAR(10)  NULL
	,CONSTRAINT PK_appUser PRIMARY KEY (userid)
)
----------------------------------------------Making the Scale table-----------------------------------------------------
DROP TABLE IF EXISTS Scale
CREATE TABLE Scale
(
	 scaleid INT NOT NULL
	,rootnote VARCHAR(5) NOT NULL
	,mode VARCHAR(20) NOT NULL
	,CONSTRAINT PK_Scale PRIMARY KEY (scaleid)
)   
-------------------------------------------Making the fretboard table------------------------------------------------------
DROP TABLE IF EXISTS Fretboard
CREATE TABLE Fretboard
(
	 fretboardid INT NOT NULL
	,numberoffrets INT NOT NULL
	,numberofstrings INT NOT NULL
	,scaleid INT NOT NULL
	FOREIGN KEY (scaleid) REFERENCES Scale(scaleid)
)
-------------------------------------------Making the game table------------------------------------------------------
DROP TABLE IF EXISTS GamePlayed
CREATE TABLE GamePlayed
(
	 gameid INT NOT NULL
	,difficulty VARCHAR(20) NOT NULL
	,timelimit TIME NOT NULL
	,fretsdisplayed VARCHAR(10) NOT NULL
	,numberofnotes INT NOT NULL
	,userid INT NOT NULL
	,PRIMARY KEY (gameid)
	,FOREIGN KEY (userid) REFERENCES appUser (userid)
)
--------------------------------------------Making viewcounter table--------------------------------------------------
DROP TABLE IF EXISTS ViewCounter
CREATE TABLE ViewCounter
(
	 scaletouserid INT NOT NULL
	,scaleid	   INT NOT NULL
	,userid        INT NOT NULL
	,timeviewed	   INT NOT NULL
	,CONSTRAINT PK_ViewCounter PRIMARY KEY (scaletouserid)
	,						   FOREIGN KEY (userid) REFERENCES appUser(userid)
	,						   FOREIGN KEY (scaleid) REFERENCES Scale(scaleid)
)
--------------------------------------------Adding Values to Scale Table--------------------------------------------------------
DROP SEQUENCE IF EXISTS ScaleIDSeq
CREATE SEQUENCE ScaleIDSeq AS INT -- Using a sequence here becuase I feel it will be helpful
	START WITH 1000				  --in the future.
	NO CYCLE;

INSERT INTO Scale
	(scaleid, rootnote, mode)
VALUES
	 (NEXT VALUE FOR ScaleIDSeq, 'A', 'MINOR')
	,(NEXT VALUE FOR ScaleIDSeq, 'A#/Bb', 'MINOR')
	,(NEXT VALUE FOR ScaleIDSeq, 'B', 'MINOR')
---------------------------------------------------------------------------------------------------------------------------------
INSERT INTO appUser
	(userid, firstname, lastname, email, userpassword, skilllevel)
VALUES
	 (1000, 'steve', 'weatherspoon', 'sw94@fakeemail.com', 'qwerty1234', 'beginner')
	,(1001, NULL, NULL, NULL ,NULL ,NULL)
	,(1002, 'sandy', 'krabs', 'sk90@fakeemail.com', 'notagoodpassword', 'advanced')
---------------------------------------------------------------------------------------------------------------------------------
INSERT INTO GamePlayed
	(gameid, difficulty, timelimit, fretsdisplayed, numberofnotes, userid)
VALUES
	 (1001, 'beginner', '00:02:45',  7, 20, 1000)
	,(1007, 'advanced', '00:01:00', 24, 26, 1002)
	,(1276, 'intermediate', '00:03:00', 12, 36, 1234)
-----------------------------------------------------------------------------------------------------------------------------------
INSERT INTO Fretboard
	(fretboardid, numberoffrets, numberofstrings, scaleid)
VALUES
	 (1657, 12, 7, 2)
	,(1869, 15, 6, 3)
	,(1020, 24, 8, 45)


	




























































