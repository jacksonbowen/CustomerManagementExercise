using System;
using CM.BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CM.BusinessLogicTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange

            Customer customer = new Customer
            {
                FirstName = "Jack",
                LastName = "Bowen"
            };

            string expected = "Bowen, Jack";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FirstNameEmptyTestValid()
        {
            //-- Arrange

            Customer customer = new Customer
            {
                LastName = "Bowen"
            };

            string expected = "Bowen";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void LastNameEmptyTestValid()
        {
            //-- Arrange

            Customer customer = new Customer
            {
                FirstName = "Jack",
            };

            string expected = "Jack";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Jack";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c1.FirstName = "Bruce";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.FirstName = "Judy";
            Customer.InstanceCount += 1;
            //-- Act

            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var customer = new Customer
            {
                LastName = "Bowen",
                EmailAddress = "jacksonbowen@gmail.com"
            };
            var expected = true;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        public void ValidateMissingLastName()
        {
            //--Arrange
            var customer = new Customer
            {
                EmailAddress = "jacksonbowen@gmail.com"
            };
            var expected = false;

            //--Act
            var actual = customer.Validate();


            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
