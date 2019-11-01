using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas_Internos
{
    public class SistemaInterno
    { 
        public bool Logar(IAutenticavel funcionario, string senha)
        {

            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema ByteBank.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            }
        }

    }
}
