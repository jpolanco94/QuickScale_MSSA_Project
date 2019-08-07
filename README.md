# QuickScale :guitar:
## Concept Description
QuickScale is a web application that provides easily readable and adjustable guitar scales for guitarist of all levels. This project 
also helps me further build on my developing skills. This README will containt entity-relationship diagrams, database diagrams, wire-frame sketches of a the
web pages, and example databases. I will follow this order:
1. Site Map
2. Wire Frame sketches and features
3. Entity Relationship Diagram in Chen Notation
4. Example Database
5. Database Diagram

## 1.Site Map
![Site Map](https://github.com/jpolanco94/QuickScale/blob/master/Site%20Map%20GuitarApp%20(1).jpeg)
The home page will be the most basic page on this web application
## 2. Wireframe Sketches and Features
![Home Page](https://github.com/jpolanco94/QuickScale/blob/master/Front%20Page.jpeg)
The main page will have a menu bar that links to the other pages and a description of the web application and how to use it.
The menu bar will have links to the actual scales and chords page, the account page, and an about page that will further explain the
app. I have not yet decided that color scheme for the web app but it will be made to be easily changeable.

The bulk of the work and information will be found on the scales and chords page.
![Scales Page](https://github.com/jpolanco94/QuickScale/blob/master/ABluesScale.jpeg)
On the left is the option that allows a user to change the tunings of the strings. The user can either select from common tunings or
choose what they want the strings to be individually.

The middle of the page is where you'll find the actual guitar fretboard and on the fretboard the scales. Readability of the scale 
is my top priority. The fretboard design above is one that I personally enjoy but I need to talk with other guitarist of different levels
to decide on one that is easily readable for them. I will also try to implement an option to allow users to chose whether they want to 
display the scale into positions.

Under the fretboard is an option for the user to change the number of frets and the number of strings of the fretboard. They can also choose 
what scale mode and root they want to display. Under this you will find the chords best associate with the chosen scale. The chord will display
at the lowest position on the fretboard. The user can click through the chords to display the chords at higher positions.

At the moment the way the chords are displayed may be confusing. I was trying to display the chords in a smiliar fashion to the way my scales
are displayed but I may just display the chords in the traditional fashion shown below (or maybe both).
![Chord Diagram](https://d1i98lg1qi3tmd.cloudfront.net/media/W1siZiIsIjIwMTcvMDgvMzEvNjNmcmMwNm5qOV8xNTFfQTdfY2hvcmQuZ2lmIl1d?sha=1853ac47634b5abc)

Once feature I want to add to this page is the chance for the user to change from a light theme to a dark theme. I also want to put 
different parts of this page into smaller windows that the user can move around to a position that helps them the most.

# 3. Entity Relationship Diagram
![ERD](https://github.com/jpolanco94/QuickScale/blob/master/Quick%20Scales%20ERD.jpeg)
# 4. Database
```sql
-This is a preliminary database for my 'QuickScales' app project I am working on.
--I made this only as a reference for myself in the future and to get
--a better idea of what changes I need to make in the future.
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
DROP TABLE IF EXISTS ScaleViewCounter      --The Scale view counter table was not one I originally intended to have but
CREATE TABLE ScaleViewCounter              --it is an important table for foreign keys.
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
```
## 5. Database Diagram
![Database Diagram](https://github.com/jpolanco94/QuickScale/blob/master/DataBase%20Diagram.JPG)
