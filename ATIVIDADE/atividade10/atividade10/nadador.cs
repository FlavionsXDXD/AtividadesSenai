
using System;

namespace atividade10
{
	
	public class nadador
	{
		
		private int idade;
		
		public int Idade
		{
			get{return idade;}
		    set{idade = value;}
		}
		
		public string Categoria()
		{
			if(idade>=5 && idade<=7)
			{
				return "Categoria Infantil A";
			}
			if(idade>=8 && idade<=10)
			{
				return "Categoria Infantil B";
			}
			if(idade>=11 && idade<=13)
			{
				return "Categoria Juvenil A";
			}
			if(idade>=14 && idade<=17)
			{
				return "Categoria Juvenil B";
			}
			if(idade>=18)
			{
				return "Categoria Senior";
			}
			
			else 
			{
				return "erro";
			}
		}
		
	}
}
