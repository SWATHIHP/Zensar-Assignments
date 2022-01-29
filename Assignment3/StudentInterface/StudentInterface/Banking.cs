/*2. Write a class called LoanProcess with Loan_No, Customer Name, LoanAmount, EMI_Amount, Account_Balance as its members. 
 * Create a method calculate_EMI() for the LoanAmount , with the rate of interest as 13% for a total of 3 years and store it in the EMI_Amount. 
 * The rest of the information to be passed through constructors. 
 * Write another function CheckBalance() which checks if the Account_Balance is less than the EMI_AMount. 
 * If yes then throw a custom exception. Display " Not Sufficient Balance to repay Loan" in the finally. Give explanatory comments.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInterface
{
    class LoanProcess
    {
        public long Loan_No;
        public string Customer_Name;
        public float LoanAmount;
        public float EMI_Amount;
        public float Acc_Bal;

        public LoanProcess(long lno,string cn)
        {
            Loan_No = lno;
            Customer_Name = cn;
           
        }
        public float calculate_EMI(float r = 13, float t = 3)
        {
            Console.WriteLine("Enter Loan Amount : ");
            LoanAmount = float.Parse(Console.ReadLine());
            float p = LoanAmount;
            r = r / (12 * 100); // one month interest
            t = t * 12; // one month period
            EMI_Amount = (p * r * (float)Math.Pow(1 + r, t)) / (float)(Math.Pow(1 + r, t) - 1);
            return (EMI_Amount);
        }
        public void CheckBalance()
        {
            Console.WriteLine("Enter Account Balance : ");
            Acc_Bal = float.Parse(Console.ReadLine());
            if (Acc_Bal < EMI_Amount)
            {
                throw (new BalanceException("Not Sufficient Balance to repay Loan"));
            }
            else
            {
                Console.WriteLine("EMI amount has been debited from your account");
            }


        }

    }
    class LoanClass
    {
        static void Main(string[] args)
        {
            LoanProcess lp = new LoanProcess(7660035478, "Swathi");
            lp.calculate_EMI();
            try
            {
                lp.CheckBalance();
            }
            catch (BalanceException Be)
            {
                Console.WriteLine(Be.Message);
            }
            
            Console.Read();
        }
    }
}


