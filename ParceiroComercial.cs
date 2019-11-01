using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Sistemas_Internos;

namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            AutenticavelHelper autenticador = new AutenticavelHelper();

            return autenticador.Autenticacao(Senha, senha);
        }
    }
}
