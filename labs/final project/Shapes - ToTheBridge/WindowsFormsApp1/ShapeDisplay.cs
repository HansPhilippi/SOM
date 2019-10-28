using System;
using System.Drawing;
using System.Windows.Forms;

public class ShapeDisplay : Form
{
    // define size and offset for window
    public int Xsize { get { return 600; } }
    public int Ysize { get { return 400; } }
    public int Xoffset { get { return 20; } }
    public int Yoffset { get { return 20; } }

    private Shape shape;

    public ShapeDisplay(Shape curShape)
    {
        this.ClientSize = new Size(Xsize, Ysize);
        this.Text = "Shape Display";
        this.BackColor = Color.White;

        this.shape = curShape;

        // button Toggle
        Button toggle = new Button();
        toggle.Size = new Size(60, 20);
        toggle.Location = new Point(Xsize - Xoffset - 60, Yoffset);
        toggle.Text = "Mode";
        toggle.Click += this.ClickToggle; // smells like Observer pattern
        this.Controls.Add(toggle);

        this.Paint += this.DrawShape; // smells like Observer pattern
    }

    private void ClickToggle(object sender, EventArgs ea)
    {
        // the toggle button should be activated as soon as the bridge is operational 
        // if (MyConfig.myDisplayMode == MyConfig.DisplayMode.Graphical)
        //     MyConfig.myDisplayMode = MyConfig.DisplayMode.Textual;
        // else
        //     MyConfig.myDisplayMode = MyConfig.DisplayMode.Graphical;

        this.Invalidate(); // enforce redraw after click
    }


    private void DrawShape(object sender, PaintEventArgs pea)
    {
        Graphics canvas = pea.Graphics;

        shape.Draw(this, canvas);  
    }
}
