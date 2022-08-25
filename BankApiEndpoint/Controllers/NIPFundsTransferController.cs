using BankApiEndpoint.Interface;
using BankApiEndpoint.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
namespace BankApiEndpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NIPFundsTransferController : ControllerBase
    {
        private readonly IService _service;
        public NIPFundsTransferController(IService service)
        {
            _service = service;
        }

        // Endpoints to get BVN details        
         [HttpPost("GetBVNDetails")]
        public async Task<ActionResult> GetBVN(GetBvnDetailsRequest request)
        {
            var result = await _service.GetBVNDetails(request);
            return Ok(result);

        }

        // enpoints for account details
        [HttpPost("GetNIPAccountDetails")]
        public async Task<ActionResult> GetNIPAccount(NIPAccountRequest request)
        {
            var result = await _service.GetNIPAccountDeatials(request);
            return Ok(result);
            
        
        
        }
        //Endpoints to transfer from one Providus Account to another Providus account
        [HttpPost("NIPAccountTransfer")]
        public async Task<ActionResult> NIPFundTransfer(NIPFundTransfer request)
        {
            var result = await _service.NIPFundTransfer(request);
            return Ok(result);
        }

        //Endpoint for to check transaction status
        [HttpPost("GetNIPTransactionStatus")]
        public async Task<ActionResult> GetNIPTransactionStatus(NIPTransactionStatusRequest request)
        {
            var result = await _service.GetNIPTransactionStatus(request);
            return Ok(result);

        }

        [HttpGet("GetNIPBanks")]
        public async Task<IActionResult> GetNIPBanks() //(string BankCode, string BankName)
        {

            GetNIPBanksModel getNipBanks = new GetNIPBanksModel();

            getNipBanks = await _service.GetNIPBanks(); //(BankCode, BankName);

            return Ok(getNipBanks);
        }

        [HttpPost("ProvidusFundTransfer")]
        public async Task<ActionResult> ProvidusFundTransfer(ProvidusFundTransfer request)
        {
            var result = await _service.ProvidusFundTransfer(request);
            return Ok(result);
        }


        [HttpPost("GetProvidusTransactionStatus")]
        public async Task<ActionResult> GetProvidusTransactionStatus(GetProvidusTransactionStatus request)
        {
            var result = await _service.GetProvidusTransactionStatus(request);
            return Ok(result);
        }
    }
}
