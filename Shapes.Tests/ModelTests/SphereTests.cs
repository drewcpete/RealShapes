using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;
using System;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {

    [TestMethod]
    public void Sphere_GetVolume_VolumeOfSphere()
    {
      Circle newCircle = new Circle(4);
      Sphere newSphere = new Sphere(newCircle);
      double result = newSphere.GetSphereVolume();
      double correctVolume = (4/3) * Math.PI * (Math.Pow(4, 3));
      Assert.AreEqual(result, correctVolume);
    }

    [TestMethod]
    public void Sphere_GetSurfaceArea_SurfaceAreaOfSphere()
    {
      Circle newCircle = new Circle(4);
      Sphere newSphere = new Sphere(newCircle);
      double result = newSphere.GetSphereSurfaceArea();
      double correctArea = 4 * Math.PI * Math.Pow(4, 2);
      Assert.AreEqual(result, correctArea);
    }

  }  
}