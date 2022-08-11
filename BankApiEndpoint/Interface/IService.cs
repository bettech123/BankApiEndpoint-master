using BankApiEndpoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApiEndpoint.Interface
{
   public interface IService
    {
        Task<NIPAccountResponse> GetNIPAccountDeatials(NIPAccountRequest accountRequest);
        Task<NIPFundTransferSucessResponse> NIPFundTransfer(NIPFundTransfer fundTransfer);

    }
}
