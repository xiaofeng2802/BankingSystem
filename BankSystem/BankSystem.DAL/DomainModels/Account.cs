﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystem.DAL.DomainModels
{
    public class Account : BaseEntity<int>
    {
        public string AccountName { get; set; }

        public string AccountNumber { get; set; }

        public double Balance { get; set; }

        public string Password { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<TransactionHistory> Histories { get; set; }

        public virtual ICollection<TransactionHistory> TransferredHistories { get; set; }
    }
}
