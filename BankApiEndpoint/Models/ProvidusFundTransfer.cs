using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankApiEndpoint.Models
{
    public class ProvidusFundTransfer
    {
       
        [Key]
        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("creditAccount")]
        public string CreditAccount { get; set; }

        [JsonProperty("debitAccount")]
        public string DebitAccount { get; set; }

        [JsonProperty("transactionAmount")]
        public string TransactionAmount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("narration")]
        public string Narration { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string PassWord { get; set; }
    }
}

