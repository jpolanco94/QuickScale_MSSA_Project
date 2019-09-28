# QuickScale :guitar:
## Table of Contents
* [Concept and Top Level User Requirements](#concept-and-top-level-user-requirements)
* [Requirements](#requirements)
* [Use Case Diagram](#use-case-diagram)
* [Database Design](#database-design)
* [Wireframe Details](#wireframe-details)
* [Progress and Challenges](#progress-and-challenges)
This readme focuses more on my application's documentation and only briefly touches on the code behind it. For a more detailed readme on the source code [click here](https://github.com/jpolanco94/QuickScale_MSSA_Project/tree/master/Prototype) 

## Concept and Top Level User Requirements
QuickScale is a web application that serves as an easily accessible, readable, and adjustable quick reference guide of scales and chords for guitarist of all levels. The following are the fundamental requirements this application must fulfill:
* The web app should be able to clearly present scales and chords in a way that makes sense.
* The web app should let users be able to select what scales and chords that want to view.
* The web app should be easy to navigate.
* The web app should allow for some level of customizazation.
The biggest challenge I face at the moment is how I will create an animated fretboard that is also adjustable by the user and also accurate.

<br/>

**Note** It is assumed that the users of this application will already have some knowldege of how to play the guitar. Even though this app caters to guitarist with some skill, it can help absolute beginners by providing links to other helpful materials.

<br/>

[Top](#table-of-contents)

## Requirements
![Requirements](https://github.com/jpolanco94/QuickScale/blob/master/Documentation/RequirementsTable20190925.jpg)
Above is my requirements table. This table is very basic and missing many requirements that I will add on in the future but it has hleped me better understand the test driven development apporach to creating applications. 

![TestCases](https://github.com/jpolanco94/QuickScale/blob/master/Documentation/TestCase20190925.jpg)
This test case diagram shows at least one test being created for everyone of my requirements. The tests all have the steps necessary to complete them and their expected outcomes.

![RTM](https://github.com/jpolanco94/QuickScale/blob/master/Documentation/RTM_20190926.jpg)
This requirements traceability matrix provides a better visual representation of what test cases fulfill which requirements. For larger web applications I will need to create a legend to help those who are looking at the RTM better understand what is going on.

[Top](#table-of-contents)

## Use Case Diagram
![UseCase](https://github.com/jpolanco94/QuickScale/blob/master/Documentation/UseCase.jpeg)
One of the features of this app is letting users create an account. I will still like users without an account to have full access to the app. This is why there are three users in this use case diagram. The only features a user with an account will have is a way to track which scales they viewed last and which scales are viewed often. The administrator will have access to a database that contains all users' login information.

[Top](#table-of-contents)

## Database Design
![ERD1](https://github.com/jpolanco94/QuickScale/blob/master/Documentation/DatabaseDiagram.JPG)

<br/>
This is the database diagram. It displays the different kinds of tables I will have and their relations. I will add an updated entity relationship diagram in the future.

[Top](#table-of-contents)

## Wireframe Details
### Front Page
![Home Page](https://github.com/jpolanco94/QuickScale/blob/master/Documentation/Home%20Page%20Quick%20Scale.jpeg)
The home page will be the most basic page on this web application. The first option the users can pick is the chord and scale viewer and
is explained below. The second option is to play a game meant to help guitarist memorize scales or fretboard notes. The user may also 
decide to visit his account. I have not yet decided that color scheme for the web app but I know I want to use softer colors and also
give the user the option to change up some colors.

[Top](#table-of-contents)

### Scales and Chords Page
![Scales Page](https://github.com/jpolanco94/QuickScale/blob/master/Documentation/ABluesScale.jpeg)
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

![Front Page](https://github.com/jpolanco94/QuickScale/blob/master/Prototype/Documentation/FrontPage.JPG)
I have stated that I want the front page to be a very simple and easy to navigate page. There is still more work to be done 
in terms of choosing font size, color, and what to do with the blurb in the middle of the page.



### Scales and Chords Page
Gif Below
![Gif](https://github.com/jpolanco94/QuickScale/blob/master/Prototype/Documentation/UsingApp.gif)
The Scales and Chords page still needs a lot of work but I was able to implement on of the features I really wanted. That is the ability for the page to be customizable to the user. 
The source code to how I implemented this can be found [here](https://github.com/jpolanco94/QuickScale_MSSA_Project/tree/master/Prototype/First_Prototype)


### Database Migration
I have also been able to migrate my database using a code first approach. Below is a Gif demonstrating me entering a specific scale I want to view and the database updating accordingly. 
![GifHTTP](https://github.com/jpolanco94/QuickScale/blob/master/Documentation/HTTPPost.gif)
The source code to how I implemented this can be found [here](https://github.com/jpolanco94/QuickScale_MSSA_Project/tree/master/Prototype/Code_First_Approach/QuickScale)
In the future I have to make sure that if a specific scale has already been added to that database that it is not duplicated. 

### Challenges
The biggest challenge I face in completing this app is figuring out a way to display a fretboard that can be changed by the user depeding what what scale they want to see and how many strings and frets they want to view. My idea right now is to have a table that that is shaped like a fretboard that will have the strings as columns and frets as rows. This table will change in size depending on what the user chooses. Certain cells will change color depending on the the root note and the mode of the scale. 

[Top](#table-of-contents)
