using static REgORSignin.Account;

namespace REgORSignin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you have an account? Enter 'Yes' or 'No' ");
            string answer = Console.ReadLine();
            if (answer == "Yes")
            {
                Account acc = new Account();
                Console.Write("UserName - ");
                string UserName = Console.ReadLine();
                Console.Write("ID - ");
                int ID = int.Parse(Console.ReadLine());
                acc.UserName = UserName;
                Random rnd = new Random();
                acc.Message += new MYDelegate(PrintValue);
                acc.PrintBalance(0);
                acc.AddBalance(rnd.Next(5000, 25000));
                acc.RemoveBalance(10000);
            }
            else if(answer == "No")
            {
                Random rnd = new Random();
                Console.Write("UserName - ");
                string UserName = Console.ReadLine();
                Console.Write("Password - ");
                int Password = int.Parse(Console.ReadLine());
                Console.Write("Your ID - ");
                int ID = rnd.Next(10,99)+2;
                Console.WriteLine(ID);
                Account acc=new Account(UserName, ID);
                acc.Message += new MYDelegate(PrintValue);
                acc.PrintBalance(0);
            }
            static void PrintValue(string value) {
                Console.WriteLine(" " + value);
            }
        }
    }
}