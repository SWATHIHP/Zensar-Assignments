/*2. Write a class called LoanProcess with Loan_No, Customer Name, LoanAmount, EMI_Amount, Account_Balance as its members. 
 * Create a method calculate_EMI() for the LoanAmount , with the rate of interest as 13% for a total of 3 years and store it in the EMI_Amount. 
 * The rest of the information to be passed through constructors. 
 * Write another function CheckBalance() which checks if the Account_Balance is less than the EMI_AMount. 
 * If yes then throw a custom exception. Display " Not Sufficient Balance to repay Loan" in the finally. Give explanatory comments.*/
using System;
using System.Runtime.Serialization;

namespace StudentInterface
{
    [Serializable]
    internal class BalanceException : Exception
    {
        public BalanceException()
        {
        }

        public BalanceException(string message) : base(message)
        {
        }

        public BalanceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BalanceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}