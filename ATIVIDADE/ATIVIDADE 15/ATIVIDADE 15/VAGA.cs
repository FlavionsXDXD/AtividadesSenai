
using System;

namespace ATIVIDADE_15
{
	
	public class VAGA
	{
		private string diploma;
		private int idade;
		 
		public string Diploma
		{
			get{return diploma;}
			set{diploma = value;}
			
			
		}
			
		public int Idade 
		{
			get{return idade;}
			set{idade = value;}
			
		}
		public string Possui()
		{
			if(diploma=="sim" && diploma=="s"||idade>=21)
			{
				return"Parabéns você está qualificado para a vaga";
				
			}
			else{
				return"nao tem qualificaçao para vaga ";
			}
		}
		
	}
}
