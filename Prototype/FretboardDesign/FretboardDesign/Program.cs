using System;

namespace FretboardDesign
{
    class Program
    {
        static void ScaleNotes (string [] rootNote, string scaleMode, string pentatonic)
        {
            if (pentatonic == "majorP")
            {
                if(scaleMode == "major")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "minor")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "harmonic minor")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == " melodic minor")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);

                }
                if (scaleMode == "aeolian")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "mixolydian")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "dorian")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "lydian")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "phrygian")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "ionian")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "locrian")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "blues")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);

                }
            }
            if (pentatonic == "")
            {
                if (scaleMode == "major")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[2] + " " + rootNote[4] + " " + rootNote[5] + " " + rootNote[7] + " " + rootNote[9] + " " + rootNote[11]);
                }
                if (scaleMode == "minor")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "harmonic minor")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == " melodic minor")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);

                }
                if (scaleMode == "aeolian")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "mixolydian")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "dorian")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "lydian")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "phrygian")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "ionian")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "locrian")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "blues")
                {
                    Console.WriteLine(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);

                }
            }
            if (pentatonic == "minorP")
            {
                if (scaleMode == "major")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "minor")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "aeolian")
                { 
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "mixolydian")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "dorian")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "lydian")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "phrygian")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "ionian")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "locrian")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
                if (scaleMode == "blues")
                {
                    Console.Write(rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0] + " " + rootNote[0]);
                }
            }
        }

        static void Main(string[] args)
        {
            string[] a = { "A", "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab" };
            string[] aSbF = { "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A" };
            string[] b = { "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "A#/Bb" };
            string[] c = { "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "A#/Bb", "B" };
            string[] cSdF = { "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "A#/Bb", "B", "C" };
            string[] d = { "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A" };
            string[] dSeF = { "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A" };
            string[] e = { "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A" };
            string[] f = { "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A" };
            string[] fSgF = { "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A" };
            string[] g = { "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A" };
            string[] gSaF = { "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A" };
            ScaleNotes(a, "major", "majorP");
        }
    }
}
