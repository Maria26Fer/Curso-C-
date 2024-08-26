namespace Course.Entities
{
    //Para dizer que essa classe herda da classe Account eu uso os : 
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)//usa se o : base(), para chamar o construtor da conta Account
        { 
            LoanLimit = loanLimit;
        }

                 //Emprestimo
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)//Verifica se o valor é maior ou igual ao limite de emprestimo 
            {
                Balance += amount; 
            }
        }
    }
}
