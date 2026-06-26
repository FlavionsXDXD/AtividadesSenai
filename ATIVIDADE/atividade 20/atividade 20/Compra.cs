using System;

namespace atividade_20
{
	
	public class Compra
	{
		
		private string resposta;
		
		public string Resposta
		{
			get{return  resposta;}
			set{resposta = value;}
		}
		
		public string Confirmar()
		{
			if(resposta=="sim" || resposta=="s")
			{return "Obrigado pela compra!";}
			else {return "cancelando compra";}
		}
	}
}
