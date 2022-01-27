using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    class Accounts
    {
       
        
            public string AccNo;
            public string CustName;
            public string AccType;
            public float amount;
            public float balance;

            public Accounts(string an, string cn, string at, float bal)
            {
                AccNo = an;
                CustName = cn;
                AccType = at;
                balance = bal;
            }

            public int TransDepWid()
            {
                int n;
                char ans;
                Console.WriteLine("--------------------Transaction Type------------------");
                do
                {
                    Console.WriteLine("\t 1. Deposit   \n\t 2. Withdrawal ");
                    Console.WriteLine("Enter your Choice : ");
                    n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Enter the Amount to be Deposited : ");
                            amount = int.Parse(Console.ReadLine());
                            balance = balance + amount;
                            Console.WriteLine($"The Total Balance after the Deposit Operation \n Amount to Deposit : {amount} \n Balance after Depositing the Amount : {balance} ");
                            break;
                        case 2:
                            Console.WriteLine("Enter the Amount to be Withdrawed : ");
                            amount = int.Parse(Console.ReadLine());
                            balance = balance - amount;
                            Console.WriteLine($"The Total Balance after the Withdrawal Operation \n Amount to Withdraw : {amount} \n Balance after Withdrawing the Amount : {balance} ");
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                    Console.WriteLine("Do You Want to continue : Yes or No");
                    ans = char.Parse(Console.ReadLine());
                } while ((ans == 'y') || (ans == 'Y'));

                return 0;
            }
        public void Show()
        {
            Console.WriteLine("The Account Number is : {0} ", AccNo);
            Console.WriteLine("The Customer Name is : {0} ", CustName);
            Console.WriteLine("The Account Type is : {0} ", AccType);
            Console.WriteLine("The Total Balance in Account is : {0}", balance);
        }
    }


        class Program
        {
            static void Main(string[] args)
            {
                Accounts Acc = new Accounts("ABC456788", "SWATHI H P", "Savings", 400000f);
                Acc.Show();
                Acc.TransDepWid();

            }
        }
    }


