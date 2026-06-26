using System;

namespace novaatividade16
{

	public class stream
	{
		private string assinar;
		private string assistir;
		
		public string Assinar
		{
			get{return assinar;}
			set{assinar = value;}
		}
		
		public string Assistir
		{
			get{return assistir;}
			set{assistir = value;}
		}
		
		public string Netflix()
		{
			if(assinar=="sim" || assinar=="s")
			{
				return"otimo agora você pode asssitir a nova temporada";
				
			}
			if(assinar=="nao"|| assinar=="n")
			{
				return "nao pode assistir a nova temporada";
			}
			else
			{
				return"não pode assitir a nova temporada";
				
			}
				
		}
	}
}
