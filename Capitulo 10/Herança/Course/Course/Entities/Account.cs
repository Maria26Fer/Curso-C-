namespace Course.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }//Vai permitir o acesso apenas em subclasses dessa classe

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //METODO QUE REALIZA O SAQUE DA CONTA
                   //Saque          Quantia
        public void Withdraw(double amount)
        {
            Balance -= amount;// Saldo menos a quantia retirada da conta
        }

        //METODO QUE REALIZA O DEPOSITO DA CONTA
        public void Deposit(double amount) 
        { 
            Balance += amount;// Adicionar valor a conta
        }

    }
}
