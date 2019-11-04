using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BusinessLogic

{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            AddressRepository = new AddressRepository();
        }

        private AddressRepository AddressRepository { get; set; }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            // Pass in the requested id
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return 
            // a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "jacksonbowen@gmail.com";
                customer.FirstName = "Jack";
                customer.LastName = "Bowen";
                customer.AddressList = AddressRepository.RetrieveByCustomerId(customerId).
                                            ToList();
            }
            return customer;
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer

            return true;
        }

    }
}




