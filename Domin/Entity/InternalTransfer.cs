﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_APP.Domin.Entity
{
    public class InternalTransfer
    {
        public decimal TransferAmount { get; set; }
        public long ReciepeintBankAccountNumber { get; set; }
        public string RecipientBankAccountName { get; set; }
    }
}
