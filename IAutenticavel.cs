using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Funcionarios;


namespace ByteBank.Sistemas_Internos
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
        
    }
}
