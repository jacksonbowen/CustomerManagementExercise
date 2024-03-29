﻿using System;
using JB.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JB.CommonTest
{
  [TestClass]
  public class StringHandlerTest
  {
    [TestMethod]
    public void InsertSpacesTestValid()
    {
      // Arrange
      var source = "SonicScrewdriver";
      var expected = "Sonic Screwdriver";

      // Act
      var actual = source.InsertSpaces();

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void InsertSpacesTestWithExistingSpace()
    {
      // Arrange
      var source = "Sonic Screwdriver";
      var expected = "Sonic Screwdriver";

      // Act
      var actual = source.InsertSpaces();

      // Assert
      Assert.AreEqual(expected, actual);
    }

  }
}
