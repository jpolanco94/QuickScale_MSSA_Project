# QuickScale :guitar:
## Table of Contents


## 1.Concept and Top Level User Requirements
QuickScale is a web application that serves as an easily accessible, readable, and adjustable quick reference guide of scales and chords for guitarist of all levels. The following are the fundamental requirements this application must fulfill:
* The web app should be able to clearly present scales and chords in a way that makes sense.
* The web app should let users be able to select what scales and chords that want to view.
* The web app should be easy to navigate.
* The web app should allow for some level of customizazation.

<br/>

**Note** It is assumed that the users of this application will already have some knowldege of how to play the guitar. Even though this app caters to guitarist with some skill, it can help absolute beginners by providing links to other helpful materials.

<br/>

(Top Link)

## 2.Requirements
![RTM](https://github.com/jpolanco94/QuickScale/blob/master/RTM%20(1).jpg)
Above is a preliminary requirements traceability matrix. As I continue to add to the prototype of the web application the software and systems requirements will grow.

## 3.Solution Design
![UseCase](https://github.com/jpolanco94/QuickScale/blob/master/UseCase.jpeg)
One of the features of this app is letting users create an account. I will still like users without an account to have full access to the app. This is why there are three users in this use case diagram. The only features a user with an account will have is a way to track which scales they viewed last and which scales are viewed often. The administrator will have access to a database that contains all users' login information.

## 4.Database Design
![ERD1](https://github.com/jpolanco94/QuickScale/blob/master/Quick%20Scales%20ERD.jpeg)
![ERD2](https://github.com/jpolanco94/QuickScale/blob/master/DataBase%20Diagram.JPG)
One of the bigger issues I face in creating this app is the way in which the scales and chords are displayed. Once I can figure that out the ERD will change almost entirely. More information here (link).

## 5.Wireframe Details
### Front Page
![Home Page](https://github.com/jpolanco94/QuickScale/blob/master/Home%20Page%20Quick%20Scale.jpeg)
The home page will be the most basic page on this web application. The first option the users can pick is the chord and scale viewer and
is explained below. The second option is to play a game meant to help guitarist memorize scales or fretboard notes. The user may also 
decide to visit his account. I have not yet decided that color scheme for the web app but I know I want to use softer colors and also
give the user the option to change up some colors.

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







