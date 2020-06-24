﻿using System;

namespace BankingDomain
{
    public class BankAccount
    {
        private decimal _currentBalance = 5000;
        public BankAccount()
        {
        }

        public decimal GetBalance()
        {
            return _currentBalance;
        }

        public void Deposit(decimal amountToDeposit)
        {
            this._currentBalance += amountToDeposit;

        }

        public void Withdraw(decimal amountToWithdraw)
        {

            if(amountToWithdraw <= _currentBalance)
            {
                this._currentBalance -= amountToWithdraw;

            }
            else
            {
                throw new OverdraftException();
            }

        }

       


    }
}

//withdraw