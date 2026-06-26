using System;

namespace ATIVIDADE14
{

	public class concessionária
	{
		private string dindin;
		private string interesse;
		
		
		public string Dindin
		{
			get{return dindin;}
			set{dindin = value;}
		}
		public string Interesse
		{
			get{return interesse;}
			set{interesse = value;}
		}
		
		public string Negociar()
		{
			if(interesse=="nao"||interesse=="n")
			{
				return "volte quando estiver interessado ";
			}
			if(interesse=="sim"||interesse=="s"&& dindin=="sim"||dindin=="s")
			{
				return "Parabens vc pode Comprar um carro";
			}
			
			else
			{
				return "vc nao pussui recursos para comprar um carro";
			}
		}
	}
}
