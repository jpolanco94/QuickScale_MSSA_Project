# QuickScale :guitar:
## Table of Contents
* [Concept and Top Level User Requirements](#concept-and-top-level-user-requirements)
* [Requirements](#requirements)
* [Use Case Diagram](#use-case-diagram)
* [Database Design](#database-design)
* [Wireframe Details](#wireframe-details)
* [Progress and Challenges](#progress-and-challenges)
* [Solution](#solution)

Checkout my app [here](https://quickscale.azurewebsites.net/)

This readme focuses more on my application's documentation and only briefly touches on the code behind it. For a more detailed readme on the source code [click here](https://github.com/jpolanco94/QuickScale_MSSA_Project/tree/master/Prototype) 

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
![Requirements](https://github.com/jpolanco94/QuickScale/blob/master/Documentation/RequirementsTable20190925.jpg)
Above is my requirements table. This table is very basic and missing many requirements that I will add on in the future but it has hleped me better understand the test driven development apporach to creating applications. 

![TestCases](https://github.com/jpolanco94/QuickScale/blob/master/Documentation/TestCase20190925.jpg)
This test case diagram shows at least one test being created for everyone of my requirements. The tests all have the steps necessary to complete them and their expected outcomes.

![RTM](https://github.com/jpolanco94/QuickScale/blob/master/Documentation/RTM_20190926.jpg)
This requirements traceability matrix provides a better visual representation of what test cases fulfill which requirements. For larger web applications I will need to create a legend to help those who are looking at the RTM better understand what is going on.

![RTM2](https://github.com/jpolanco94/QuickScale_MSSA_Project/blob/master/Documentation/RTM_Two.png)
This second requirements traceability matrix displays my progress up to this point. Currently 100% of my requirements are covered by test cases and 75% of those requirements have passing test cases. Only one of my test cases has failed so far but there are 4 important requirements which have not had features implemented to even be able to test yet.

Most of the front end features of this app are passing, meaning that from a users perspective it may seem that this is a completed application. 

[Top](#table-of-contents)

## Use Case Diagram
![UseCase](https://github.com/jpolanco94/QuickScale_MSSA_Project/blob/master/Documentation/UseCase2.jpeg)
One of the features of this app is letting users create an account. I will still like users without an account to have full access to the app. This is why there are three users in this use case diagram. The only features a user with an account will have is a way to track which scales they viewed last and which scales are viewed often. The administrator will have access to a database that contains all users' login information.

[Top](#table-of-contents)

## Database Design
![db1](https://github.com/jpolanco94/QuickScale_MSSA_Project/blob/master/Documentation/DatabaseDiagram20191010.JPG)
This is the database diagram. It displays the different kinds of tables I will have and their relations.

![db2](https://github.com/jpolanco94/QuickScale_MSSA_Project/blob/master/Documentation/IdentityDbDiagram20191010.JPG)
This database diagram is what I am using to let users create accounts and login as well as control users and roles with an admin account.

![final dbd](https://github.com/jpolanco94/QuickScale_MSSA_Project/blob/master/Documentation/Database_Diagram_Two.PNG)
I finally decided to just implement my own tables into the identity database to keep things simple.

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
The Scales and Chords page still needs a lot of work but I was able to implement on of the features I really wanted. That is the ability for the page to be customizable to the user. This is a feature I have decided to hold off on with my current project becuase I want to take care of the more important requirements first
The source code to how I implemented this can be found [here](https://github.com/jpolanco94/QuickScale_MSSA_Project/tree/master/Prototype/First_Prototype)

I was able to find some code that accomplished almost all of what I need from this app. This code allows users to choose a scale and mode and see that displayed on a fret board.

I did have to make a couple changes however. First I had to add a lot more scales since there were only a few available. The second change I made was to make the fretboard horizontal becuase this is how most guitarist are used to viewing a fretboard. I decided I would give users the option to decide whether they wanted a vertical or horizontal fretboard. There is a lot of front end work to be done but I am focused more on fulfilling my basic requirements.
![Vertical Scale](https://github.com/jpolanco94/QuickScale_MSSA_Project/blob/master/Documentation/HorizontalScales.PNG)
![Horizontal Scale](https://github.com/jpolanco94/QuickScale_MSSA_Project/blob/master/Documentation/Vertical%20Scales.PNG)
![Switch Gif](https://github.com/jpolanco94/QuickScale_MSSA_Project/blob/master/Documentation/ChangeView.gif)
The original source code for this feature can be found [here](https://codepen.io/XCC/pen/zPjqgr)

### Task At Hand
[Click here](https://github.com/jpolanco94/QuickScale_MSSA_Project/projects) for more information on my current and completed tasks.


### Database Migration
I have also been able to migrate my database using a code first approach. Below is a Gif demonstrating me entering a specific scale I want to view and the database updating accordingly. 
![GifHTTP](https://github.com/jpolanco94/QuickScale/blob/master/Documentation/HTTPPost.gif)
The source code to how I implemented this can be found [here](https://github.com/jpolanco94/QuickScale_MSSA_Project/tree/master/Prototype/Code_First_Approach/QuickScale)
In the future I have to make sure that if a specific scale has already been added to that database that it is not duplicated. 

### Challenges
My previous biggest challenge was actually displaying a fretboard. While I have accomplished that, I still want to find a way to have users decide how many strings and frets they want to view. I feel like a deeper understanding of JavaScript maybe required to finish this task but what I have for now is sufficient. I do plan on further developing my JavaScript skills in the future to help me become a better front end developer.

[Top](#table-of-contents)

### Solution
## Integrated Technologies
One of the most useful technologies I've integrated was JavaScript. Learning JavaScript was not one of the requirements for this course but I felt that what I wanted to do would be very difficult without JavaScript. I needed JavaScript to implement an adjustable fretboard. I was fortunated enough to find some code that already accomplished a lot of what I needed. This code can be found [here](https://codepen.io/XCC/pen/zPjqgr). I had to make a couple changes to this to better fit my requirements, and there are future changes I will need to make this fretboard more adjustable by the user.

I didn't want to learn JavaScript from the ground up but just by analyzing pre-written JavaScript code and with my understanding of Object-Oriented principles I was able to make my changes. JavaScript is a skill I want to further pursue in order to build future apps that incorporate Google Maps API for JavaScript.

## Paths Explored
I originally wanted to create this app using Blazor. I felt it would be a great way to get ahead of the curve in terms of new technologies. Blazor would also help be use C# as a scripting language instead of having to learn JavaScript. I decided against this though since there wasn't a lot of information or expertise in Blazor that I could turn to if any issues arose. I am still planning on creating my own Blazor apps but I will do so on my own time with other projects.

## Future Plans
The biggest challenge I've face with app and the one I'm struggling with is how to implement Azure Key Vaults to hide the secrets that I don't want others to see when pushing my app to GitHub. This is something I still plan to work on for the future.

Another feature I want to implement is having email verification. I was able to do this on a seperate project but I just have to code it into this project without having it break anything. The tutorial I used to learn how to use this can be found [here](https://docs.microsoft.com/en-us/aspnet/identity/overview/features-api/account-confirmation-and-password-recovery-with-aspnet-identity) and my link the code to this can be found [here](https://github.com/jpolanco94/Email-Confirmation-and-Password-Recovery). The API used to implement this can be found [here](https://sendgrid.com/).

Since the code I used to build the fretboard was pre-written, I want to eventually build up the proficieny in JavaScript to write my own code for this from the ground up. 
