using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class NewAccountTests
    {
        [Fact]

        public void NewAccountsHaveCorrectBalance()
        {   

            //WTCYWYH- "write the code you wish you had
            //given I have a brand new bank account

            //Just hard code it in until something else works


            var account = new BankAccount();
            
            
            //when I retrieve the balance
            decimal balance = account.GetBalance();
           
            
            //it has a balance of $5000.00
            Assert.Equal(5000M, balance);
        }
    }
}
//"Test per Type" base tests on scenarios