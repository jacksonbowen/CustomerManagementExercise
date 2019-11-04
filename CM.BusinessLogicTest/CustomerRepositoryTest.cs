using System;
using System.Collections.Generic;
using CM.BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CM.BusinessLogicTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {

                EmailAddress = "jacksonbowen@gmail.com",
                FirstName = "Jack",
                LastName = "Bowen",
            };

            //--Act
            var actual = customerRepository.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

    [TestMethod]
    public void RetrieveExistingWithAddress()
    {
        //-- Arrange
        var customerRepository = new CustomerRepository();
        var expected = new Customer(1)
        {
            EmailAddress = "jacksonbowen@gmail.com",
            FirstName = "Jack",
            LastName = "Bowen",
            AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "1600 Pennsylvania Ave",
                        StreetLine2 = "White House",
                        City = "Washington",
                        State = "DC",
                        Country = "USA",
                        PostalCode = "50100"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "5010 Main St",
                        City = "Rockford",
                        State = "IL",
                        Country = "USA",
                        PostalCode = "60150"
                    }
                }
        };

        //-- Act
        var actual = customerRepository.Retrieve(1);

        //-- Assert
        Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        Assert.AreEqual(expected.FirstName, actual.FirstName);
        Assert.AreEqual(expected.LastName, actual.LastName);

        for (int i = 0; i < 1; i++)
        {
            Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
            Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
            Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
            Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
            Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
            Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
        }
    }

    }

}
