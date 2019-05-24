using ElGamal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ElGamal.Services
{
    public interface ICryptoService
    {
        Signature GenerateSignature(String message);
        bool Check(string text, Signature signature);
    }
}
