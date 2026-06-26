using System;

namespace atividade_24
{

	public class Palavra
	{
		private string resposta;
		
		public string Resposta
		{
			get{return resposta;}
			set{resposta = value;}
			
		}
		
		public string Validar()
		{
			
			if(string.IsNullOrWhiteSpace(resposta))
			{
				return "a palvra esta vazia, digite uma palavra";
			}
			else
			{
				return "Palavra valida";
			}
		}
	}
}
