using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REgORSignin
{
    internal class Account
    {
        public string UserName { get;set; }
        private int ID { get; set; }
        private double Balance { get; set; }
        public Account(string UserName, int ID)
        {
            this.UserName = UserName;
            this.ID = ID;
        }
        public Account(double Balance)
        {
            this.Balance = Balance;
        }
        public Account()
        {
            
        }
        public void PrintBalance(double Balance)
        {
            Message.Invoke($"Your balance - {Balance}");
        }
        public void AddBalance(int sum)
        {
            Message.Invoke($"+ {sum}");
            Balance += sum;
            Message.Invoke($"Your balance - {Balance}");
        }
        public void RemoveBalance(double sum)
        {
            if (Balance > sum)
            {
                Message.Invoke($"- {sum}");
                Balance -= sum;
                Message.Invoke($"Your balance - {Balance}");
            }
            else
            {
                Message.Invoke("Not enough");
                Message.Invoke($"Your balance - {Balance}");
            }
        }
        public delegate void MYDelegate(string message);
        public event MYDelegate Message;
    }
}
