using DataBaseAssignment.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// This takes care of the 3) Repository pattern requirement

namespace DataBaseAssignment.Repositories
{
    public interface ICustomerRepository
    {

        // Different methods that are described in the assignment doc



        // Read all customers
        public List<Customer> ReadAllCustomers();

        //// Read specific customer by Id
        public Customer ReadCustomer(int id);

        //// Return a page of customers (limit and offset)
        //public List<Customer> ReadPageOfCustomers();
        
        //// Add a new customer (from customer object
        //public bool AddNewCustomer(Customer customer);

        //// Update a customer
        //public bool UpdateCustomer(Customer customer);

        //// Return the number of customers in each country (high to low)                 (CustomerCountry Class)
        //public List<CustomerCountry> GetNrCustomersInEachCountry();

        //// Highest spending customers                                                   (CustomerSpender Class)
        //public List<CustomerSpender> GetHighestSpenders();

        //// Most popular genre for a customer                                            (CustomerGenre Class)
        //public CustomerGenre GetMostPopularGenre();

    }
}
