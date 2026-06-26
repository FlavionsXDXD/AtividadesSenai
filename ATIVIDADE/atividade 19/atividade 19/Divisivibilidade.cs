using System;

namespace atividade_19
{

	public class Divisivibilidade
	{
		private int numero;
		public int Numero
		{
			get{return numero;}
			set{numero=value;}
		}
		
		public string Calculo()
		{
			if(numero % 3 ==0 && numero % 5 ==0)
				{
					return " e divisivel por 3 e 5! ";
				}
			else if (numero % 3 ==0)
			{
				return "e divisivel por 3";
			}
			
			else if (numero % 5 ==0)
			{
				return "e divisivel por 5";
			}
				else
				{
					return " nao e divisivel por 3 e 5 !";
				}
		}
			
		
	}
}
