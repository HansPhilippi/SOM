using System;
using System.Drawing;

public abstract class Shape
{
    protected string description;

    protected Color edgeColor;
    protected Pen pen;

    public virtual void Draw(ShapeDisplay sd, Graphics canvas)
    {
        // we define a uniform pen size for all shapes
        pen = new Pen(this.edgeColor, 3);
    }
}



    
