using System;

namespace atividade_25
{

	public class Confirmar
	{
		private string resposta;
		
		public string Resposta
		{
			get{return resposta;}
			set{resposta = value;}
		}
		
		public string Validar()
		{
			string resposta2 =this.resposta.Trim().ToLower();
			if(resposta2=="sim"||resposta2=="s")
			{
				return "“Por favor,confirme o cancelamento da operação.";
			}
			
			else
			{
				return "cancelando a operaçao.";
			}
		}
	}
}
