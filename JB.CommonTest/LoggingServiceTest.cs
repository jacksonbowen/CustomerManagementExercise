using System.Collections.Generic;
using CM.BusinessLogic;
using JB.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JB.CommonTest
{
  [TestClass]
  public class LoggingServiceTest
  {
    [TestMethod]
    public void WriteToFileTest()
    {
      // Arrange
      var changedItems = new List<ILoggable>();

      var customer = new Customer(1)
      {
        EmailAddress = "jacksonbowen@gmail.com",
        FirstName = "Jack",
        LastName = "Bowen",
        AddressList = null
      };
      changedItems.Add(customer);

      var product = new Product(2)
      {
        ProductName = "Rake",
        ProductDescription = "Garden Rake with Steel Head",
        CurrentPrice = 6M
      };
      changedItems.Add(product);

      // Act
      LoggingService.WriteToFile(changedItems);

      // Assert
      // Nothing here to assert
    }
  }
}
