using System;

namespace atividade_17
{
	
	public class Login
	{
		private string nome;
		private int idade;
		private int quantidade = 3;
		
		public string Nome
		{
			get{return nome;}
			set{nome = value;}
			
		}
		
		public int Idade
		{
			get{return idade;}
			set{idade = value;}
			
		}
	
		public string permissao()
		{
			if(nome.Length > quantidade && idade >= 18)
			{
				return"Acesso permitido";
			}
			
			
			else
			{
				return"Acesso negado";
				
			}
				
				
		}
	}
}
