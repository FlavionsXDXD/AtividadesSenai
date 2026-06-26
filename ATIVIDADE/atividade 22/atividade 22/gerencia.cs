using System;

namespace atividade_22
{

	public class gerencia
	{
		private int numero;
		
		public int Numero
			{
			get{return numero;}
			set{numero = value;}
		}
		
		public string Validar()
		{
			if(numero>=0 && numero<=10)
			{
				return "numero "+numero+" dentro da escala";
				
			}
			else
			{
				return "numero invalido";
			}
		}
	}
}
