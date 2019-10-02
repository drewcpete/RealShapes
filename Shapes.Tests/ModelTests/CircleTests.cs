using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;
using System;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests
  {

    [TestMethod]
    public void Circle_GetCircumference_CicumferenceOfCircle()
    {
      Circle newCircle = new Circle(4);
      double result = newCircle.GetCircumference();
      double correctAnswer = 4 * Math.PI * 2;
      Assert.AreEqual(result, correctAnswer);
    }

    [TestMethod]
    public void Circle_GetDiameter_DiameterOfCircle()
    {
      Circle newCircle = new Circle(4);
      double result = newCircle.GetDiameter();
      Assert.AreEqual(result, 8);
    }



  }  
}