using System;

namespace atividade_21
{

	public class reconhecer
	{
		private string nome;
		public string Nome
		{
			get{return nome;}
			set{nome=value;}
		}
		
		public string Validar()
		{
			
			string nome2 = this.nome.Trim().ToLower();
			if(nome2=="wilson"||nome2=="gloria")
			{
				return "“Olá, bem-vindo(a) de volta! "+nome+" ";
			}
			else
			{
				return "acesso negado!";
			}
		}
	}
}
