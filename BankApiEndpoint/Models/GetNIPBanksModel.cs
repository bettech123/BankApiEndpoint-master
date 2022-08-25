using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApiEndpoint.Models
{
    public class Bank
    {
        public string bankCode { get; set; }
        public string bankName { get; set; }
    }
    public class GetNIPBanksModel
    {

        public List<Bank> banks { get; set; }

        public string responseMessage { get; set; }

        public string responseCode { get; set; }

    }

}


