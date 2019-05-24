using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using ElGamal.Services;
using Microsoft.AspNetCore.Mvc;
using ElGamal.Models;

namespace ElGamal.Controllers
{
    [Route("api/crypto")]
    [ApiController]
    public class CryptoController : ControllerBase
    {
        private ICryptoService _cryptoService;
        public CryptoController(ICryptoService cryptoService)
        {
            _cryptoService = cryptoService;
        }

        [HttpPost("sign")]
        public ActionResult<Signature> Sign([FromBody]string text)
        {
            return Ok(_cryptoService.GenerateSignature(text));
        }
        
        [HttpPost("check")]
        public ActionResult<bool> Check([FromBody]CheckModel model)
        {
            return Ok(_cryptoService.Check(model.Text, model.Signature));
        }
    }
}
