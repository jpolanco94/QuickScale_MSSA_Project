--This is a preliminary database for my 'QuickScales' app project I am working on.
--I made this only as a reference for myself in the future and to get
--a better idea of what changes I need to make in the future.
--A readme will be added in the future to my github to explain the purpose behind
--my tables, columns, and the overall app.
--https://github.com/jpolanco94
-------------------------------------------Creating and using the database--------------------------------------------
DROP DATABASE IF EXISTS GuitarApp;
CREATE DATABASE GuitarApp;
USE GuitarApp;
------------------------------------------------First Table(AppUser)--------------------------------------------------
DROP TABLE IF EXISTS AppUser
CREATE TABLE AppUser
(
	 userid INT NOT NULL			--Only userid is 'NOT NULL' becuase I want users to be able to
	,username VARCHAR(20) NULL      --be able to play the game without having to make an account
	,firstname VARCHAR(20) NULL
	,lastname VARCHAR(20) NULL
	,email VARCHAR(30) NULL
	,userpassword VARCHAR(20) NULL
	,skilllevel VARCHAR(15) NULL
	,PRIMARY KEY (userid)
)
---------------------------------------------------Second Table(GamesPlayed)----------------------------------------------------
--This table tracks the games that a user has played the settings the user chose, and their results
DROP TABLE IF EXISTS GamesPlayed
CREATE TABLE GamesPlayed
(
	 gameid INT NOT NULL
	,difficulty VARCHAR(15) NOT NULL
	,timeneeded TIME NOT NULL
	,notesreached INT NOT NULL
	,numberoffrets INT NOT NULL
	,userid INT NOT NULL
	,PRIMARY KEY (gameid)
	,FOREIGN KEY (userid) REFERENCES AppUser(userid)
)
----------------------------------------------------Third Table(Scale)-----------------------------------------------
DROP TABLE IF EXISTS Scale
CREATE TABLE Scale
(
	 scaleid INT NOT NULL
	,rootnote VARCHAR(5) NOT NULL
	,mode VARCHAR(20) NOT NULL
	,PRIMARY KEY (scaleid)
)
---------------------------------------------------Fourth Table(FretBoard)-------------------------------------------
DROP TABLE IF EXISTS FretBoard
CREATE TABLE FretBoard
(
	 fretboardid INT NOT NULL
	,numberofstring INT NOT NULL
	,numberoffrets INT NOT NULL
	,scaleid INT NOT NULL
	,PRIMARY KEY (fretboardid)
	,FOREIGN KEY (scaleid) REFERENCES Scale(scaleid)
)
--------------------------------------------------Fifth Table(ScaleViewCounter)---------------------------------------
DROP TABLE IF EXISTS ScaleViewCounter
CREATE TABLE ScaleViewCounter
(
	 scaletouserid INT NOT NULL
	,scaleid INT NOT NULL
	,userid INT NOT NULL
	,timesviewed INT NOT NULL
	,PRIMARY KEY (scaletouserid)
	,FOREIGN KEY (scaleid) REFERENCES Scale(scaleid)
	,FOREIGN KEY (userid) REFERENCES AppUser(userid)
)
------------------------------------------------------Inserting dummy data----------------------------------------------
INSERT INTO AppUser
	(userid, username, firstname, lastname, email, userpassword, skilllevel)
VALUES
	 (1000, 'thedude', 'dude', 'dudester', 'dude@fakeemail.com', 'qwerty1234', 'beginner')
	,(1001, 'theduder', 'duder', 'dudesterer', 'duder@fakeemail.com', 'qwerty1234', 'beginner')
INSERT INTO GamesPlayed
	(gameid, difficulty, timeneeded, notesreached, numberoffrets, userid)
VALUES
	(11, 'advanced', '00:21:32', 12, 6, 1000)
INSERT INTO Scale
	(scaleid, rootnote, mode)
VALUES
	(134, 'E', 'Major')
INSERT INTO FretBoard
	(fretboardid, numberoffrets, numberofstring, scaleid)
VALUES
	(12, 12, 6, 134)
INSERT INTO ScaleViewCounter
	(scaletouserid, scaleid, userid, timesviewed)
VALUES
	(14235, 134, 1000, 1)
----------------------------------------------------------------------------------------------------------------------
DROP SEQUENCE IF EXISTS UserIdSequence; --I'm using a sequence here to create values for
CREATE SEQUENCE UserIdSequence          --userid. I feel this will be helpful in the future.
	START WITH 2000															
	NO CYCLE;

INSERT INTO AppUser
	(userid, username, firstname, lastname, email, userpassword, skilllevel)
VALUES
	 (NEXT VALUE FOR UserIdSequence, 'gp123', 'george', 'pochanclas', 'gp@fakeemail.com', 'qwerty1234', 'advanced')
	,(NEXT VALUE FOR UserIdSequence, 'sp123', 'steve', 'pochanclas', 'sp@fakeemail.com', 'qwerty4321', 'intermediate')
	,(NEXT VALUE FOR UserIdSequence, 'rp123', 'roger', 'pochanclas', 'rp@fakeemail.com', 'qwerty1234', 'advanced')






