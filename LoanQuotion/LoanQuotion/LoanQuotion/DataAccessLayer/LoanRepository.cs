using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

namespace LoanQuotion.DataAccessLayer
{
    public class LoanRepository
    {
        private IConfiguration _configuration { get; }
        private string _conn = "";
        public LoanRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _conn = _configuration.GetConnectionString("mydb");
        }

       public dynamic getAllLoan()
        {
            string sql = $@"SELECT loan_amount,interest_rate,repayment FROM LOAN ";

            using (SqlConnection con = new SqlConnection(_conn))
            {

                return con.Query(sql);
            }
        }
    }
}
