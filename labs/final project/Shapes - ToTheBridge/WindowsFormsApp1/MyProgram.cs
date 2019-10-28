using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

static class MyProgram
{
    static void Main()
    {

         Shape shape = new Rectangle(200, 120, Color.Blue);
        // Shape shape = new Triangle(180, 250, Color.Orange);

        ShapeDisplay shapeDisplay = new ShapeDisplay(shape);

        Application.Run(shapeDisplay);
    }
}

static class MyConfig
{     
    // use a uniform font throughout the program
    public static readonly Font MyFont = new Font("Tahoma", 12);

    // choose between Graphical display and textual output
    // not yet activated
    public enum DisplayMode { Graphical, Textual }

    public static DisplayMode myDisplayMode = DisplayMode.Graphical;
}

