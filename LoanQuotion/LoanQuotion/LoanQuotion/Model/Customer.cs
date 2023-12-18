namespace LoanQuotion.Model
{
    public class Customer : ICustomer
    {
        public string id_number { get; set; }
        
        public string first_name { get ; set ; }
        public string last_name { get ; set ; }
        public string date_of_birth { get  ; set; }
        public string contact_number { get ; set ; }
        public decimal income { get ; set ; }
        public string job { get ; set ; }
        public string employer { get ; set ; }
    }
}
