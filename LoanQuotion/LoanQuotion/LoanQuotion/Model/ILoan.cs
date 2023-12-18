namespace LoanQuotion.Model
{
    public interface ILoan
    {
        public  decimal loan_amount{ get; set; }
        public  decimal interest_rate { get; set; }
        public  decimal repayment{ get; set; }
    }
}
