using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElGamal.Models
{
    public class Signature
    {
        public Guid SignatureId { get; set; }
        public String R { get; set; }
        public String S { get; set; }
    }
}
