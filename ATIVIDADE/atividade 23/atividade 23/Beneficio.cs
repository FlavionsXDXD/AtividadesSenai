using System;

namespace atividade_23
{

	public class Beneficio
	{
		private string resposta;
		public string Resposta
		{
			get{return resposta;}
			set{resposta=value;}
		}
		
		public string Validar()
		{
			string resposta2 = this.resposta.Trim().ToLower();
			if(resposta2=="sim"||resposta2=="s")
			{
				return "Por favor,atualize sua inscrição para continuar usufruindo dos benefícios do clube.";
				
			}
			else
			{
				return "continue usufruir dos beneficios do membro!";
			}
		}
	}
}
