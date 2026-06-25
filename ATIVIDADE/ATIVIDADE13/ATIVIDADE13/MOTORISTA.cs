using System;

namespace ATIVIDADE13
{
	
	public class MOTORISTA
	{
		private int idade;
		private string permissao;
		
		public int Idade
		{
			get{return idade;}
			set{idade = value;}
		}
		
		public string Permissao
		{
			get{return permissao;}
			set{permissao = value;}
		}
		
		public string Dirigir()
		{
			if(idade>=18||Permissao=="sim" && permissao=="SIM")
			{
				return "vc tem permissao para dirigir";
			}
			else
			{
				return "vc nao tem permissao para dirigir";
			}
		}
	}
}
