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

        [HttpPost("GetNIPAccountDetails")]
        public async Task<ActionResult> GetNIPAccount(NIPAccountRequest request)
        {
            var result = await _service.GetNIPAccountDeatials(request);
            return Ok(result);
            
        
        
        }

        [HttpPost("NIPAccountTransfer")]
        public async Task<ActionResult> NIPFundTransfer(NIPFundTransfer request)
        {
            var result = await _service.NIPFundTransfer(request);
            return Ok(result);

        }
    }
}
