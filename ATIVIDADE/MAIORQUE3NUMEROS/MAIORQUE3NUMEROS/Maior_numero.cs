using System;

namespace MAIORQUE3NUMEROS
{
	
	public class Maior_numero
	{
		public int valor1;
		public int valor2;
		public int valor3;
		
		public int Valor1
	{
			get{return valor1;}
			set{valor1 = value;}
	}
		public int Valor2
		{
			get{return valor2;}
			set{valor2 = value;}
		}
		
		public int Valor3
		{
			get{return valor3;}
			set{valor3 = value;}
		}
		
		public string Maior_tres()
		{
		if(valor1 > valor2 && valor1 > valor3)
		{
			return "Primeiro numero e Maior";
		}
		else if (valor2 > valor1 && valor2 > valor3)
		{
			return "Segundo numero e Maior";
		}
		else if (valor3 > valor1 && valor3 > valor2)
		{
			return "Terceiro numero e Maior";
		}
		else if (valor1 == valor2 && valor1 ==valor3 && valor2 == valor3)
		{
			return "os tres sao iguais";
		}
		
		else {return "dois numeros sao iguais";}
			
		}
		
	}
	
	
}
