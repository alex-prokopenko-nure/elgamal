using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ElGamal.Models
{
    public class SessionKeys
    {
        public BigInteger Y { get; set; }
        public BigInteger G { get; set; }
        public BigInteger P { get; set; }
        public BigInteger X { get; set; }
    }
}
