# QuickScale ProtoType
So far I have been able to play with Visual Studios to develop a more definitive feel for the front end portion of my app.
### Front Page
![Front Page](https://github.com/jpolanco94/QuickScale/blob/master/Prototype/FrontPage.JPG)
I have stated that I want the front page to be a very simple and easy to navigate page. There is still more work to be done 
in terms of choosing font size, color, and what to do with the blurb in the middle of the page.

### Scales and Chords Page.
![Gif](https://github.com/jpolanco94/QuickScale/blob/master/Prototype/UsingApp.gif)
The Scales and Chords page still needs a lot of work but I was able to implement on of the features I really wanted. That is the ability for the page to be customizable to the user. I still need to figure out a way to display the fretboard in a way that will be easy to change the number of frets and strings shown.

## Html, Css, and Javascript
I added the code I used to write the scales and chords in case there are any ideas my peers can think of that can help me build a better web page.
### Html
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
### Css
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
