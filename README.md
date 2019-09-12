# QuickScale :guitar:
## Table of Contents
* [Concept and Top Level User Requirements](#concept-and-top-level-user-requirements)
* [Requirements](#requirements)
* [Solution Design](#solution-design)
* [Database Design](#database-design)
* [Wireframe Details](#wireframe-details)
* [Progress and Challenges](#progress-and-challenges)
* [Code](#code)


## Concept and Top Level User Requirements
QuickScale is a web application that serves as an easily accessible, readable, and adjustable quick reference guide of scales and chords for guitarist of all levels. The following are the fundamental requirements this application must fulfill:
* The web app should be able to clearly present scales and chords in a way that makes sense.
* The web app should let users be able to select what scales and chords that want to view.
* The web app should be easy to navigate.
* The web app should allow for some level of customizazation.

<br/>

**Note** It is assumed that the users of this application will already have some knowldege of how to play the guitar. Even though this app caters to guitarist with some skill, it can help absolute beginners by providing links to other helpful materials.

<br/>

[Top](#table-of-contents)

## Requirements
![RTM](https://github.com/jpolanco94/QuickScale/blob/master/RTM%20(1).jpg)
Above is a preliminary requirements traceability matrix. As I continue to add to the prototype of the web application the software and systems requirements will grow.

[Top](#table-of-contents)

## Solution Design
![UseCase](https://github.com/jpolanco94/QuickScale/blob/master/UseCase.jpeg)
One of the features of this app is letting users create an account. I will still like users without an account to have full access to the app. This is why there are three users in this use case diagram. The only features a user with an account will have is a way to track which scales they viewed last and which scales are viewed often. The administrator will have access to a database that contains all users' login information.

[Top](#table-of-contents)

## Database Design
![ERD1](https://github.com/jpolanco94/QuickScale/blob/master/Quick%20Scales%20ERD.jpeg)
![ERD2](https://github.com/jpolanco94/QuickScale/blob/master/DataBase%20Diagram.JPG)

<br/>

One of the bigger issues I face in creating this app is the way in which the scales and chords are displayed. Once I can figure that out the ERD will change almost entirely. More information [here](#challenges)

[Top](#table-of-contents)

## Wireframe Details
### Front Page
![Home Page](https://github.com/jpolanco94/QuickScale/blob/master/Home%20Page%20Quick%20Scale.jpeg)
The home page will be the most basic page on this web application. The first option the users can pick is the chord and scale viewer and
is explained below. The second option is to play a game meant to help guitarist memorize scales or fretboard notes. The user may also 
decide to visit his account. I have not yet decided that color scheme for the web app but I know I want to use softer colors and also
give the user the option to change up some colors.

[Top](#table-of-contents)

### Scales and Chords Page
![Scales Page](https://github.com/jpolanco94/QuickScale/blob/master/ABluesScale.jpeg)
There is a lot going on in this sketch! I will explain each element but first want to clarify that the users of this app will have
almost total control into how they want this page to be displayed. First, I want each element of this page to be its own seperate 
window that users can move around to their liking. They will be able to open, close, and resize these windows as they please. I also want users to be able to change colors if they prefer. I prefer softer lighter colors, some may like harsher and darker colors. I may even have an option to change the fretboard desgin to a more traditional and realistic model. Now I will explain the sperate elements
in the next paragraphs.

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
are displayed but I may just display the chords in the traditional fashion 
shown below (or maybe both).

![Chord Diagram](https://d1i98lg1qi3tmd.cloudfront.net/media/W1siZiIsIjIwMTcvMDgvMzEvNjNmcmMwNm5qOV8xNTFfQTdfY2hvcmQuZ2lmIl1d?sha=1853ac47634b5abc)

[Top](#table-of-contents)

## Progress and Challenges
Below is what I have been able to accomplish on Visual Studios on the front end.
### Front Page

![Front Page](https://github.com/jpolanco94/QuickScale/blob/master/Prototype/FrontPage.JPG)
I have stated that I want the front page to be a very simple and easy to navigate page. There is still more work to be done 
in terms of choosing font size, color, and what to do with the blurb in the middle of the page.

### Scales and Chords Page

### Scales and Chords Page.
Gif Below
![Gif](https://github.com/jpolanco94/QuickScale/blob/master/Prototype/UsingApp.gif)
The Scales and Chords page still needs a lot of work but I was able to implement on of the features I really wanted. That is the ability for the page to be customizable to the user. 

### Challenges
The biggest challenge I face in completing this app is figuring out a way to display a fretboard that can be changed by the user depeding what what scale they want to see and how many strings and frets they want to view. My idea right now is to have a table that that is shaped like a fretboard that will have the strings as columns and frets as rows. This table will change in size depending on what the user chooses. Certain cells will change color depending on the the root note and the mode of the scale. 

[Top](#table-of-contents)

## Code
### SQL
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

[Top](#table-of-contents)

### HTML
```html
<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" href="~/css/ScalesPage.css"/>
    <script src="~/js/ScalesPage.js"></script>
    <title>Scale Page</title>
</head>
<body>
    <div id="drag-1" class="draggable">
        <div style="display:table-row">Choose Mode and Key</div>
        <div style="display:table-cell" class="dropdown">
            <button class="dropbtn">Key</button>
            <div class="dropdown-content">
                <a href="#">A</a>
                <a href="#">A#/Bb</a>
                <a href="#">B </a>
                <a href="#">C</a>
                <a href="#">C#/Db</a>
                <a href="#">D</a>
                <a href="#">D#/Eb</a>
                <a href="#">E</a>
                <a href="#">F</a>
                <a href="#">F#/Gb</a>
                <a href="#">G</a>
                <a href="#">G#/Ab</a>
            </div>
        </div>
        <div style="display:table-cell" class="dropdown">
            <button class="dropbtn">Mode</button>
            <div class="dropdown-content">
                <a href="#">Major</a>
                <a href="#">Natural Minor</a>
                <a href="#">Harmonic Minor</a>
                <a href="#">Blues</a>
                <a href="#">Phrygian</a>
                <a href="#">Mixolydian</a>
                <a href="#">Lydian</a>
                <a href="#">Aeolian</a>
                <a href="#">Locrian</a>
                <a href="#">Ionian</a>
                <a href="#">Dorian</a>
            </div>
        </div>
        <button type="button" class="gobutton">Go!</button>
    </div>
    <div id="drag-1" class="draggable">
        <div style="display:table-row">Choose Fret and String Number</div>
        <div style="display:table-cell" class="dropdown">
            <button class="dropbtn">String #</button>
            <div class="dropdown-content">
                <a href="#">4</a>
                <a href="#">5</a>
                <a href="#">6</a>
                <a href="#">7</a>
                <a href="#">8</a>
                <a href="#">9</a>
                <a href="#">10</a>
            </div>
        </div>
        <div style="display:table-cell" class="dropdown">
            <button class="dropbtn">Fret#</button>
            <div class="dropdown-content">
                <a href="#">12</a>
                <a href="#">13</a>
                <a href="#">14</a>
                <a href="#">15</a>
                <a href="#">16</a>
                <a href="#">17</a>
                <a href="#">18</a>
                <a href="#">19</a>
                <a href="#">20</a>
                <a href="#">21</a>
                <a href="#">22</a>
                <a href="#">23</a>
                <a href="#">24</a>

            </div>
        </div>
        <button type="button" class="gobutton">Go!</button>
    </div>
    <a asp-action="Index">Front Page</a>
</body>
</html>
```

[Top](#table-of-contents)

### CSS
```css
#drag-1, #drag-2 {
    width: 200px;
    background-color: #29e;
    color: indianred;
    border-radius: 10px;
    padding: 1%;
    touch-action: none;
    user-select: none;
    -webkit-transform: translate(0px, 0px);
    transform: translate(0px, 0px);
    background-color: aquamarine;
    margin: 50px;
}
.gobutton {
    cursor: pointer;
    -webkit-transition-duration: 0.4s; /* Safari */
    transition-duration: 0.4s;
    cursor: pointer;
    border: none;
}
.gobutton:hover{
    cursor:  alias;
    color: yellowgreen;
}
.dropbtn {
    background-color: indianred;
    color:aquamarine;
    padding: 8px;
    font-size: 20px;
    border: none;
    border-radius: 10px;
}

.dropdown {
    position: relative;
    display: inline-block;
}

.dropdown-content {
    display: none;
    position: absolute;
    background-color: lightgrey;
    min-width: 15px;
    box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
    z-index: 1;
}
.dropdown-content a {
   color: black;
   padding: 12px 16px;
   text-decoration: none;
   display: block;
}

.dropdown-content a:hover {
    background-color: darkgrey;
}

.dropdown:hover .dropdown-content {
    display: block;
}

.dropdown:hover .dropbtn {
    background-color: gold;
}
```
[Top](#table-of-contents)

### JavaScript
```javascript
// target elements with the "draggable" class
interact('.draggable')
    .draggable({
        // enable inertial throwing
        inertia: true,
        // keep the element within the area of it's parent
        modifiers: [
            interact.modifiers.restrictRect({
                restriction: 'parent',
                endOnly: true
            })
        ],
        // enable autoScroll
        autoScroll: true,

        // call this function on every dragmove event
        onmove: dragMoveListener,
        // call this function on every dragend event
        onend: function (event) {
            var textEl = event.target.querySelector('p')

            //textEl && (textEl.textContent =
            //    'moved a distance of ' +
            //    (Math.sqrt(Math.pow(event.pageX - event.x0, 2) +
            //        Math.pow(event.pageY - event.y0, 2) | 0))
            //        .toFixed(2) + 'px')
        }
    })

function dragMoveListener(event) {
    var target = event.target
    // keep the dragged position in the data-x/data-y attributes
    var x = (parseFloat(target.getAttribute('data-x')) || 0) + event.dx
    var y = (parseFloat(target.getAttribute('data-y')) || 0) + event.dy

    // translate the element
    target.style.webkitTransform =
        target.style.transform =
        'translate(' + x + 'px, ' + y + 'px)'

    // update the posiion attributes
    target.setAttribute('data-x', x)
    target.setAttribute('data-y', y)
}

// this is used later in the resizing and gesture demos
window.dragMoveListener = dragMoveListener

function myFunction() {
    var x = document.getElementById("myTopnav");
    if (x.className === "topnav") {
        x.className += " responsive";
    } else {
        x.className = "topnav";
    }
}
```

[Top](#table-of-contents)









