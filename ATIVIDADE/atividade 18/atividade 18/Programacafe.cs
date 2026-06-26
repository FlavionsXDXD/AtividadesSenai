using System;

namespace atividade_18
{

	public class Programacafe
	{
		private string pergunta1;
		private string pergunta2;
		
		public string Pergunta1
		{
			get{return pergunta1;}
			set{pergunta1=value;}
			
		}
		
		public string Pergunta2
		{
			get{return pergunta2;}
			set{pergunta2= value;}
		}
		
		public string Servir()
		{
			if(pergunta1 =="sim"||pergunta1=="s" &&( pergunta2=="sim"||pergunta2=="s" ))
			{
				return "adicionando açucar e leite";
			}
			else if (pergunta1 =="sim"||pergunta1=="s")
			{
				return "adicionando apenas açucar";
			}
			
			else if(pergunta2=="sim"||pergunta2=="s" )
			{
				return "adicionando apenas leite";
			}
			else 
			{
				return "Fazendo apenas o cafe sem adicional";
			}
		}
	}
}
