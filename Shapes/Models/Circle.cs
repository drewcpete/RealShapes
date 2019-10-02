using System;

namespace Shapes.Models
{
  public class Circle
  {
    public double Radius { get; set; }
    public double Pi { get; set; }

    public Circle(double radius)
    {
      Radius = radius;
      Pi = Math.PI;
    }

    public double GetCircumference()
    {
      return 2 * Pi * Radius;
    }
    
    public double GetDiameter()
    {
      return 2 * Radius;
    }


  }
}