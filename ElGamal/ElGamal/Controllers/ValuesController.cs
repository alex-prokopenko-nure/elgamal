using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using ElGamal.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElGamal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ICryptoService _cryptoService;
        public ValuesController(ICryptoService cryptoService)
        {
            _cryptoService = cryptoService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<BigInteger> Get()
        {
            return _cryptoService.GetBigPrime();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
