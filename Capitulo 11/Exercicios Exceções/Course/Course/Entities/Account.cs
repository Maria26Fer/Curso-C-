using Course.Entities.Exception;

namespace Course.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;//Titular
            Balance = balance;//Saldo
            WithdrawLimit = withdrawLimit;//Limite de retirada
        }
        public void Deposit(double amount) //Quantia
        {
            Balance += amount; //Esse metodo vai verificar se é um saldo maior ou igual ao quantia que está armazenada na conta
        }

        public void Withdraw(double amount)
            /*Se a quantia for maior que o limite que será retirado
             o programa vai me retornar um erro dizendo que o valor passou do limite de retirada*/
        {
            if (amount > WithdrawLimit) {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            /*Se a quantia for maior que o saldo que tem na conta o programa vai me retornar um erro
             dizendo que não tem saldo suficiente para realizr o saque*/
            if (amount > Balance) {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}