using System;
using System.Drawing;

class Triangle : Shape
// we limit ourselves to equal sided triangles
{
    protected int Basis { get; }
    protected int Height { get; }

    public Triangle(int b, int h, Color c)
    {
        this.Basis = b;
        this.Height = h;
        this.edgeColor = c;
        this.description = "triangle";
    }

    public override void Draw(ShapeDisplay sd, Graphics canvas)
    {
        base.Draw(sd, canvas);

        int xStart = sd.Xoffset;
        int yStart = sd.Yoffset + Height;

        canvas.DrawLine(pen, xStart, yStart, xStart + Basis, yStart);
        canvas.DrawLine(pen, xStart, yStart, xStart + Basis / 2, yStart - Height);
        canvas.DrawLine(pen, xStart + Basis, yStart, xStart + Basis / 2, yStart - Height);
    }
}