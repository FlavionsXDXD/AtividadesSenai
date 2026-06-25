
using System;

namespace ATIVIDADE_12
{
	
	public class parimpar
	{
		
		private int numero;
		public int Numero
		{
			get{return numero;}
			set{numero = value;}
		}
		
		public string Verificador()
		{
			if(numero % 2 == 0)
			{
				return "o numero é par";
				
			}
			else
			{
				return "o numero é impar";
				
			}
			
				
			
			} 
		
		
		
	}
}
