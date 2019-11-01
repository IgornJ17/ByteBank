using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
	public class OperacaoFinanceiraException : Exception
	{
		public OperacaoFinanceiraException(){}
		
		public OperacaoFinanceiraException(string msg)
			: base(msg){}
			
		public OperacaoFinanceiraException(string msg, Exception excecaoInterna) 
			: base(msg, ex) {}
		
	}

}