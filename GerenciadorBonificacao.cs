using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Funcionarios;

namespace ByteBank.Modelos
{
    class GerenciadorBonificacao
    {
        private double _totalDeBonificacao;

        public void Registrar(Funcionario func)
        {
            _totalDeBonificacao += func.GetBonificacao();
        }
        public double GetTotalBonificacao()
        {
            return _totalDeBonificacao;
        }
    }
}