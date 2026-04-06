using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace passwordcsharp.Service.Validator
{
    public interface ISenhaValidacao
    {
        bool Validar(string senha);
    }
}