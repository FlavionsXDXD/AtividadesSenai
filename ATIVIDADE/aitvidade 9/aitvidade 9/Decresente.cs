
using System;

namespace aitvidade_9
{

	public class Decresente
	{
		
		private int numero1;
		private int numero2;
		private int numero3;
		private int temp;
		
		public int Numero1
		{
			get{return numero1;}
			set{numero1 = value;}
			
		}
		public int Numero2
		{
			get{return numero2;}
			set{numero2 = value;}
			
		}
		public int Numero3
		{
			get{return numero3;}
			set{numero3 = value;}
		}
		public string MudarPosicao()
		{//variavel temp serve de campo vazio para permitir a troca de numeros sem perder ou misturar os valores
			//temp de temporario para os valores trasitar na troca por um tempo curto 
			if (numero1<numero2){temp = numero1; numero1 = numero2; numero2 = temp;}
			if (numero1<numero3){temp = numero1; numero1 = numero3; numero3 = temp;}
			if (numero2<numero3){temp = numero2; numero2 = numero3; numero3 = temp;}
			
			return " "+numero1+" "+numero2+" "+numero3+" ";
		}
			
		}
	}

