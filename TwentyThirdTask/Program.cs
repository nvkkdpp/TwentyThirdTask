using System;

namespace TwentyThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание объекта банковского счета.");
            BankAccount ba = new BankAccount();
            ba.InitBankAccount();
            double deposit = 123.454;
            Console.WriteLine("Зачисление {0:C}", deposit);
            ba.Deposit(deposit);
            Console.WriteLine("Счёт = {0}", ba.GetString());
            double fractoinalAddition = 0.002;
            Console.WriteLine("Вклад {0:C}", fractoinalAddition);
            ba.Deposit(fractoinalAddition);
            Console.WriteLine("В результате счёт = {0}, а баланс равен: {1:C}", ba.GetString(), ba.GetBalance());
            Console.WriteLine("Нажмите <enter> для завершения программы . . . ");
            Console.Read();
        }
    }
    public class BankAccount
    {
        private static int _nextAccountNumber = 1000;
        private int _accountNumber;
        private decimal _balance;
        public void InitBankAccount()
        {
            _accountNumber = ++_nextAccountNumber;
            _balance = 0.0M;
        }
        public double GetBalance()
        {
            return (double)_balance;
        }
        public int GetAccountNumber()
        {
            return _accountNumber;
        }
        public void SetAccountNumber(int accountNumber)
        {
            this._accountNumber = accountNumber;
        }
        public void Deposit(double amount)  
        {
            if(amount > 0.0)
            {
                decimal temp = (decimal)amount;
                temp = Decimal.Round(temp, 2);
                _balance += temp;
               // _balance = _balance + temp; тоже самое что строка 52
            }
        }
        public double Withdraw(double withdrawal)
        {
            decimal decWithdrawal = (decimal)withdrawal;
            if (_balance <= decWithdrawal);
            {
                decWithdrawal = _balance;
            }
            _balance -= decWithdrawal;
            // _balance = _balance - decWithdrawal; тоже самое что строка 63
            return (double)decWithdrawal;
        }
        public string GetString()
        {
            string s = String.Format("#{0}={1:C}",GetAccountNumber(), GetBalance());

            return s;
        }

    }

}
