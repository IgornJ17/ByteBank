using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos
{
    class AutenticavelHelper
    {
        public bool Autenticacao(string SenhaCorreta, string TentativaSenha)
        {
            return SenhaCorreta == TentativaSenha;
        }
    }
}
