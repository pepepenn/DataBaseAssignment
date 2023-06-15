using System;
using Microsoft.Data.SqlClient;

using DataBaseAssignment.Models;
using DataBaseAssignment.Repositories;
using DataBaseAssignment.Models;


namespace DataBaseAssignment
{       

        

        class Program
        {
            static void Main(string[] args)
            {

                ICustomerRepository repository = new CustomerRepository();
            //TestSelectAll(repository);

            TestFindCustomerByID(repository);
            }



        

            static void TestSelectAll(ICustomerRepository repository)
            {
                PrintCustomers(repository.ReadAllCustomers());
            }

            static void TestFindCustomerByID(ICustomerRepository repository)
            {
                PrintCustomer(repository.ReadCustomer(1));
            }



            static void PrintCustomers(IEnumerable<Customer> customers) 
            {
                foreach (Customer customer in customers)
                {
                    PrintCustomer(customer);
                }
        
        
            }

            static void PrintCustomer(Customer customer)
            {
                Console.WriteLine($"--- { customer.CustomerId} {customer.FirstName} {customer.LastName} {customer.Country} {customer.PostalCode} {customer.Phone} {customer.Email} ---");
            }


    }


}