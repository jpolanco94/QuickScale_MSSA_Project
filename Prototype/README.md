# QuickScale ProtoTypes
This is where I keep all the the source code for my prototypes. I have created different prototypes for trying out different approaches to creating this application to see which one seems to be the most feasible for a project of this size.

## Code First Approach
The [code first approach](https://github.com/jpolanco94/QuickScale_MSSA_Project/tree/master/Prototype/Code_First_Approach/QuickScale) to creating a web application is the one I feel most confident with at the moment. Currently I have completed my models. I have created a handful of views and controllers that will take user input (either a user choosing a scale or creating an account) and been able to save that to a database and also display in on the web page to ensure my database and code are connected. I have also added encryption to the saved passwords. At the moment, my biggest concern is in finding a way to display an accurate and easily readable fretboard. 

## Fretboard Design
This [bit of source](https://github.com/jpolanco94/QuickScale_MSSA_Project/tree/master/Prototype/FretboardDesign) code focuses on finding ways to display an accurate and adjustable fretboard for my users. My plan is to create my own circular linked list data structure that will contain the twelve notes of western music (A to G#). Since one of the features of my app is to allow users to change the string tunings for each string, the circular linked list will help display those notes no matter what the note is. If the users wants to start with a G# (the last element of the linked list), that G# will point to the head of the linked list (A) and continue on from there.

This will also help when it comes to creating the actual scales. Scales contain seven notes out the the twelve. Once I have a linked list containing the twelve notes I only have to create methods that select certain notes based on what the root note is and what mode the scale is in (both specified by the user).

After I have create a circular linked list I have to figure out a way to actually display what the user exatly wants using html. I feel this is the biggest challenge and is still in the works.

## First Prototype
The source code found [here](https://github.com/jpolanco94/QuickScale_MSSA_Project/tree/master/Prototype/First_Prototype) was the very first ASP.NET Mvc code I wrote up for my project. I still had a very basic understanding in developing my app but learned a lot in terms of implementing third party packages (interact.js specifically) and being able to create a more user adjustable web page.

## Database First Approach
I have very little experience with the [database first](https://github.com/jpolanco94/QuickScale_MSSA_Project/tree/master/Prototype/DB_First_Approach/DBFirstQuickScale) approach but would still like to learn in order to understand their differences, similarities, and what makes one better than the other depending on the situation.
