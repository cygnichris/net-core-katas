using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignments;
using System;

namespace TestSuite
{
  [TestClass]
  public class NumberModifierTests
  {
    private NumberModifier sut = new NumberModifier();

    [TestMethod]
    public void ShouldReturnErrorForLessThan1()
    {
      // Arrange
      var errorInput = -1;
      // Act
      Action errorAct = () => sut.NumberToRoman(errorInput);
      // Assert
      Assert.ThrowsException<ArgumentException>(errorAct);

    }

    [TestMethod]
    public void ShouldReturnErrorForLessThan0()
    {
      // Arrange
      var errorInput = 0;
      // Act
      Action errorAct = () => sut.NumberToRoman(errorInput);
      // Assert
      Assert.ThrowsException<ArgumentException>(errorAct);

    }

    [TestMethod]
    public void ShouldReturnIfor1()
    {
      // Arrange
      var I = 1;
      var romanOne = "I";
      // Act
      var result = sut.NumberToRoman(I);
      // Assert
      Assert.AreEqual(romanOne, result);
    }

    [TestMethod]
    public void shouldReturnVfor5()
    {
      // Arrange
      var V = 5;
      var romanFive = "V";
      // Act
      var result = sut.NumberToRoman(V);
      // Assert
      Assert.AreEqual(romanFive, result);
    }

    [TestMethod]
    public void shouldReturnfor10()
    {
      // Arrange
      var X = 10;
      var romanTen = "X";
      // Act
      var result = sut.NumberToRoman(X);
      // Assert
      Assert.AreEqual(romanTen, result);

    }

    [TestMethod]
    public void shouldReturnfor15()
    {
      // Arrange
      var XV = 15;
      var romanFifteen = "XV";
      // Act
      var result = sut.NumberToRoman(XV);
      // Assert
      Assert.AreEqual(romanFifteen, result);

    }

    [TestMethod]
    public void shouldReturnfor42()
    {
      // Arrange
      var XLII = 42;
      var romanFortyTwo = "XLII";
      // Act
      var result = sut.NumberToRoman(XLII);
      // Assert
      Assert.AreEqual(romanFortyTwo, result);

    }



    [TestMethod]
    public void shouldReturnfor9()
    {
      // Arrange
      var IX = 9;
      var romanNine = "IX";
      // Act
      var result = sut.NumberToRoman(IX);
      // Assert
      Assert.AreEqual(romanNine, result);

    }

    [TestMethod]
    public void shouldReturnfor94()
    {
      // Arrange
      var XCIV = 94;
      var romanNinetyFour = "XCIV";
      // Act
      var result = sut.NumberToRoman(XCIV);
      // Assert
      Assert.AreEqual(romanNinetyFour, result);

    }
    [TestMethod]
    public void shouldReturnfor1776()
    {
      // Arrange
      var MDCCLXXVI = 1776;
      var romanSeventeenSeventySix = "MDCCLXXVI";
      // Act
      var result = sut.NumberToRoman(MDCCLXXVI);
      // Assert
      Assert.AreEqual(romanSeventeenSeventySix, result);
    }

  }
}
