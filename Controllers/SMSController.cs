using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendSMSWithTwillo.Dtos;
using SendSMSWithTwillo.Services;

namespace SendSMSWithTwillo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSController : ControllerBase
    {
        private readonly ISMSService _smsservice;
        public SMSController(ISMSService smsservice)
        {
            _smsservice = smsservice;
        }

        [HttpPost("send")]
        public IActionResult Send(SendSMSDto dto)
        {
            var result = _smsservice.Send(dto.MobileNumber, dto.body);
            if (!string.IsNullOrEmpty(result.ErrorMessage))
                return BadRequest(result.ErrorMessage);


            return Ok(result);
           

        }
    }
}
