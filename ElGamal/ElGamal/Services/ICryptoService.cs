using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ElGamal.Services
{
    public interface ICryptoService
    {
        BigInteger GetBigPrime();
    }
}
