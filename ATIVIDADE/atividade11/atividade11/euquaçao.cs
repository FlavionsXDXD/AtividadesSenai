using System;

namespace atividade11
{
	/// <summary>
	/// Description of euquaçao.
	/// </summary>
	public class euquaçao
	{
		private double numero1;
		private double numero2;
		private double numero3;
		
		public double Numero1
		{
			get{return numero1;}
			set{numero1 = value;}
		}
		public double Numero2
		{
			get{return numero2;}
			set{numero2 = value;}
			
		}
		
		
		public double Numero3
		{
			get{return numero3;}
			set{numero3 = value;}
			
		}
		public string SegundoGrau()
		{if(numero1==0)
			{
				return "o coeficiente a não pode ser igual a 0";
			}
			
			double delta = (numero2 * numero2) -(4 * numero1 * numero3);
			
			if(delta>0)
			{
				double raizDelta = CalcularRaizQuadrada(delta);
				double x1 = (-Numero2 + raizDelta) / (2 * numero1);
				double x2 = (-Numero2 - raizDelta) / (2 * numero1);
				
				return "duas raízes reais  "+x1+" e "+x2+" ";
			}
			
			else if (delta == 0)
			{
				double x = -numero2 / (2 * numero1);
				return "uma unica raiz "+x+" ";
			}
			else
			{
				return "nao possui raizes reias";
			}
		}
		static double CalcularRaizQuadrada(double numero)
		{
			if (numero < 0) return double.NaN;
			
			
			double margemErro = 0.000000000000001;
			double estimativa = numero / 2.0;

			while (SubtrairAbsoluto(estimativa * estimativa, numero) > margemErro)
			{
				estimativa = 0.5 * (estimativa + (numero / estimativa));
			}

			return estimativa;
		}

		
		static double SubtrairAbsoluto(double valor1, double valor2)
		{
			double resultado = valor1 - valor2;
			return resultado < 0 ? -resultado : resultado;
		}

	}
}



