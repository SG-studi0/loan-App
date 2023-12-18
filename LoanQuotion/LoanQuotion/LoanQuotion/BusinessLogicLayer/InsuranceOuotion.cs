using LoanQuotion.Model;
using LoanQuotion.DataAccessLayer;
using System.Linq.Expressions;
using System.Globalization;

namespace LoanQuotion.BusinessModel
{
    public class InsuranceOuotion 
    {
      private CustomerRepository _customerRepository { get; set; }
   
      const decimal interestRate = 0.15M;
      private string id_number = "";
      private string age = "";
      
      private ILoan _loan;
      private Customer _customer;
        

        public void quotion()
        {
   
            var customerIncome = new List<int>(
                _customerRepository.Income(_customer.id_number));

            var age = new List<string>(
                _customerRepository.Age(_customer.id_number));
            
            DateTime dt = new DateTime();
            var currentYear = dt.Year;
            var ageYear = age.FirstOrDefault()?.Substring(0,4);
            var calcAge = Convert.ToInt32(ageYear) - currentYear;

            foreach (var income in customerIncome)
            {
                decimal loanAmt = 0;
                decimal interest = 0;
                decimal repayment = 0;

                if(calcAge < 30)
                {
                    loanAmt = 5000;
                    interest = interestRate;
                    repayment = loanAmt * interest / 12;
                    switch (income)
                    {
                    case 5000:
                        loanAmt = 1000; 
                        _loan.loan_amount = loanAmt;
                        interest = 0.1M ;
                        _loan.interest_rate = interest;
                        _loan.repayment = loanAmt * interest / 12; 
                        break;

                    case > 10000:
                        loanAmt = _loan.loan_amount = 1000;
                        interest = _loan.interest_rate = 0.2M ;
                        _loan.repayment = loanAmt * interest / 12;
                        break;



                    }
             
                }
               
                }
            }
     

        }

    }

