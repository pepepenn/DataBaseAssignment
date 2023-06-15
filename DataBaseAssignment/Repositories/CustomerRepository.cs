using DataBaseAssignment.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAssignment.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        //public bool Example(Customer customer)
        //{
        //    Connect

        //    Make a command


        //    Reader

        //    Handle result
        //}


        public bool AddNewCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<CustomerSpender> GetHighestSpenders()
        {
            throw new NotImplementedException();
        }

        public CustomerGenre GetMostPopularGenre()
        {
            throw new NotImplementedException();
        }

        public List<CustomerCountry> GetNrCustomersInEachCountry()
        {
            throw new NotImplementedException();
        }

        public List<Customer> ReadAllCustomers()
        {
            List<Customer> custlist = new List<Customer>();
            string sql = "SELECT CustomerId, FirstName, LastName, Country, PostalCode, Phone, Email FROM Customer";
            try
            {


                using (SqlConnection conn = new SqlConnection(ConnectionStringHelper.GetConnectionString()))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Customer temp = new Customer();
                                temp.CustomerId = reader.GetInt32(0);
                                temp.FirstName = reader.GetString(1);
                                temp.LastName = reader.GetString(2);
                                temp.Country = reader.GetString(3);
                                temp.PostalCode = reader.GetValue(4).ToString();
                                temp.Phone = reader.GetValue(5).ToString();
                                temp.Email = reader.GetValue(6).ToString();
                                custlist.Add(temp);



                            }

                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Something went wrong in the ReadAllCustomers method");
            }

            return custlist;
        }

        public Customer ReadCustomer(int id)
        {

            Customer customer = new Customer();
            string sql = "SELECT CustomerId, FirstName, LastName, Country, PostalCode, Phone, Email FROM Customer WHERE CustomerId = @CustomerId";
            //try
            //{


            using (SqlConnection conn = new SqlConnection(ConnectionStringHelper.GetConnectionString()))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", id.ToString() );
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        
                            //Customer temp = new Customer();
                            customer.CustomerId = reader.GetInt32(0);
                            customer.FirstName = reader.GetString(1);
                            customer.LastName = reader.GetString(2);
                            customer.Country = reader.GetString(3);
                            customer.PostalCode = reader.GetValue(4).ToString();
                            customer.Phone = reader.GetValue(5).ToString();
                            customer.Email = reader.GetValue(6).ToString();
                        




                    }

                }
            }
            //}
            //catch(SqlException ex)
            //{

            //}
            return customer;
        }

        public List<Customer> ReadPageOfCustomers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
