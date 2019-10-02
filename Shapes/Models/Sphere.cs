using System;

namespace Shapes.Models
{
  public class Sphere
  {
    public Circle SomeCircle { get; set; } 
        
    public Sphere (Circle someCircle)
    {
      SomeCircle = someCircle;
    }

    public double GetSphereVolume()
    {      
      double RadiusCubed = Math.Pow(SomeCircle.Radius,3);
      return (4/3) * Math.PI * RadiusCubed;
    }

    public double GetSphereSurfaceArea()
    {
      double RadiusSquared = Math.Pow(SomeCircle.Radius, 2);
      return 4 * Math.PI * RadiusSquared;
    }
  }
}