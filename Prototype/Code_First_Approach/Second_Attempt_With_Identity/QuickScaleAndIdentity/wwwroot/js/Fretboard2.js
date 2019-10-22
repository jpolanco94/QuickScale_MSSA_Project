// note array
var notes = ["A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"];
// scales
var major = [2, 2, 1, 2, 2, 2, 1];
var minor = [2, 1, 2, 2, 1, 2, 2];
var minorMelDes = minor;
var minorMelAsc = [2, 1, 2, 2, 2, 2, 1];
var minorHar = [2, 1, 2, 2, 1, 3, 1];
var whole = [2, 2, 2, 2, 2, 2];
var gypsy = [2, 1, 3, 1, 1, 3, 1];
var pentatonic = [2, 3, 2, 2, 3];
var octatonic = [1, 2, 1, 2, 1, 2, 1, 2, 1];
var blues = [2, 1, 1, 1, 1, 1, 2, 1, 1, 1];

$(document).ready(function() {
    // initially set to EADGBE for standard guitar tuning
    rootChange($(".string.one"), "E");
    rootChange($(".string.two"), "A");
    rootChange($(".string.three"), "D");
    rootChange($(".string.four"), "G");
    rootChange($(".string.five"), "B");
    rootChange($(".string.six"), "E");
    // listeners
    // individual string open note change function
    $(".open").change(function() {
        rootChange(
            $(this).parent(),
            $(this)
                .val()
                .toString()
        );
    });
    // note switches
    $(".note").click(function() {
        $(this).toggleClass("selected");
        resetSelection();
    });
    // set scale button
    $(".setScale").click(function() {
        var note = $(".rootNote")
            .val()
            .toString();
        var scale = $(".scale")
            .val()
            .toString();
        setScale(note, scale);
    });
    // start in mono mode
    $('.fretBoard').addClass("mono");
    $('.noteSelector').addClass("mono");
    // color code change class swap
    $('.colorCode').change(function() {
        if (this.checked) {
            $(".mono").removeClass("mono");
        } else {
            $('.fretBoard').addClass("mono");
            $('.noteSelector').addClass("mono");
        }
    });
});
// scale setting function
function setScale(note, scale) {
    // remove all previously selected notes
    $(".selected").removeClass("selected");
    // create an array variable to hold the selected intervals
    var scaleArray;
    // check to see what position the root note is in
    var rootNote = $.inArray(note, notes);
    // select the root note
    $(".note[rel='" + note + "']").addClass("selected");
    // check the selected scale and pull in the correct array of intervals
    switch (scale.toString()) {
        case "major":
            scaleArray = major;
            break;
        case "minor":
            scaleArray = minor;
            break;
        case "minorMelDes":
            scaleArray = minor;
            break;
        case "minorMelAsc":
            scaleArray = minorMelAsc;
            break;
        case "minorHar":
            scaleArray = minorHar;
            break;
        case "whole":
            scaleArray = whole;
            break;
        case "gypsy":
            scaleArray = gypsy;
            break;
        case "pentatonic":
            scaleArray = pentatonic;
            break;
        case "octatonic":
            scaleArray = octatonic;
            break;
        case "blues":
            scaleArray = blues;
            break;
        default:
            scaleArray = major;
    }
    // move up the neck based on the intervals in the array
    for (i = 0; i < scaleArray.length; i++) {
        rootNote = rootNote + scaleArray[i];
        if (rootNote >= notes.length) {
            rootNote = rootNote - notes.length;
        }
        $(".note[rel='" + notes[rootNote] + "']").addClass("selected");
    }
    resetSelection();
}
// apply the classes to the selected notes across the fretboard
function resetSelection() {
    $(".fret .selected").removeClass("selected");
    $(".noteSelector .note.selected").each(function() {
        $('.string[rel="' + $(this).attr("rel").toString() + '"]').addClass("selected");
    });
}
// string tuning change function
function rootChange(stringNum, note) {
    // change the dropdown
    $(stringNum)
        .children(".open")
        .val(note);
    $(stringNum).attr("rel", note);
    var currString =
        "." +
        $(stringNum)
            .attr("class")
            .replace(" ", ".");
    currString = currString.replace(" selected", "");
    $(currString).removeClass("selected");
    // perform the mapping
    mapString($(stringNum), note);
}
// remaps notes for a string
function mapString(stringNum, note) {
    // get the current string
    var currString =
        "." +
        $(stringNum)
            .attr("class")
            .replace(" ", ".");
    currString = currString.replace(" selected", "");
    // get the index of the note in the notes array
    var currNote = $.inArray(note, notes);
    // move up a note for each fret
    for (i = 1; i < 25; i++) {
        currNote++;
        // set the current note to 0 to reset to A if it tries to go past G#
        if (currNote == notes.length) {
            currNote = 0;
        }
        // write the value to the fretboard
        $(".fret[rel=" + i + "]")
            .children(currString)
            .html(notes[currNote].toString());
        $(".fret[rel=" + i + "]")
            .children(currString)
            .attr("rel", notes[currNote].toString());
    }
    // add the highlighted notes
    resetSelection();
}
