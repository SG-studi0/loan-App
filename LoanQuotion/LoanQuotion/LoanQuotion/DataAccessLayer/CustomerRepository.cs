using Dapper;
using LoanQuotion.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data.SqlTypes;

namespace LoanQuotion.DataAccessLayer
{
    public class CustomerRepository
    {
        private IConfiguration _configuration { get; }
        private string _conn = "";
        public CustomerRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _conn = _configuration.GetConnectionString("mydb");
        }

       /* public dynamic createCustomer(string id_number, string first_name, string last_name, string date_of_birth, string contact_number, decimal income, string job, string empolyer)
        {
            string sql = $@"INSERT INTO Customer (id_number, first_name ,last_name ,date_of_birth,contact_number,income,job,employer)
                            VALUES ('{id_number}','{first_name}','{last_name}','{date_of_birth}','{contact_number}',{income},'{job}','{empolyer}')";

            using (SqlConnection con = new SqlConnection(_conn))
            {

                return con.Query(sql);
            }

        }*/

        public dynamic AddCustomer( Customer customer)
        {
            string sql = $@"INSERT INTO Customer (id_number, first_name ,last_name,date_of_birth ,contact_number,income,job,employer)
                            VALUES ('{customer.id_number}','{customer.first_name}','{customer.last_name}','{customer.date_of_birth}','{customer.contact_number}',{customer.income},'{customer.job}','{customer.employer}')";

            using (SqlConnection con = new SqlConnection(_conn))
            {

                return con.Query(sql);
            }

        }


        public dynamic Income(string id_number)
        {
            string sql = $@"SELECT income FROM  Customer WHERE id_number={id_number} ";
            using (SqlConnection con = new SqlConnection(_conn))
            {

                return con.Query(sql);
            }

        }

        public dynamic Age(string id_number)
        {
            string sql = $@"SELECT date_of_birth FROM  Customer WHERE id_number={id_number} ";
            using (SqlConnection con = new SqlConnection(_conn))
            {

                return con.Query(sql);
            }

        }


    }
}
