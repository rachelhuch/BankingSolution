﻿using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class BankAccountWithdrawals
    {

        [Fact]

        public void WithdrawingMoneyDecreasesBalance()
        {
            //Given
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToWithdraw = 1M;

            //When

            account.Withdraw(amountToWithdraw);

            //Then

            var expectedBalance = openingBalance - amountToWithdraw;
            Assert.Equal(expectedBalance, account.GetBalance());
        }

        [Fact]
        public void YouCanTakeAllYourMoney()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();

            account.Withdraw(openingBalance);

            Assert.Equal(0, account.GetBalance());
        }

        /*[Fact]*/ //use this until the other does what it's supposed to do then get rid of it

        //public void TempReplicateIssueWithTakingMoneyToZero()
        //{
        //    var account = new BankAccount();

        //    Assert.Throws<OverdraftException>(()=>  account.Withdraw(account.GetBalance()));
        //}
    }
}
    

