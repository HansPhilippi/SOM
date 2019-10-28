using System;
using System.Drawing;


class Rectangle : Shape
{
    protected int Width { get; }
    protected int Height { get; }

    public Rectangle(int w, int h, Color c)
    {
      this.Width = w; this.Height = h;
      this.edgeColor = c;
      this.description = "rectangle";
    }


    public override void Draw(ShapeDisplay sd, Graphics canvas)
    {
       base.Draw(sd, canvas);

        // determine position for drawing
        int xStart = sd.Xoffset;
        int yStart = sd.Yoffset + this.Height;

        canvas.DrawLine(pen, xStart, yStart, xStart, yStart - Height);
        canvas.DrawLine(pen, xStart, yStart, xStart + Width, yStart);
        canvas.DrawLine(pen, xStart, yStart - Height, xStart + Width, yStart - Height);
        canvas.DrawLine(pen, xStart + Width, yStart, xStart + Width, yStart - Height);
    }
}

