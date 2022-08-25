using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankApiEndpoint.Models
{
    public class GetProvidusTransactionStatus
    {
            [Key]
            [JsonProperty("transactionReference")]
            public string TransactionReference { get; set; }

            [JsonProperty("userName")]
            public string UserName { get; set; }

            [JsonProperty("password")]
            public string Password { get; set; }
    }
}
