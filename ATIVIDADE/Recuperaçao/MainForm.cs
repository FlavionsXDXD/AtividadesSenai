using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AprovadoouReprovado
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		void BtnCalcularMediaClick(object sender, EventArgs e)
		{
			//todas as variaveis declaradas
			string  nota1 = txtNota1.Text;
			string nota2 = txtNota2.Text;
			string nota3 = txtNota3.Text;
			string nome = txtNome.Text;
			//as variaveis convertidas 
			double numero1;
			double numero2;
			double numero3;
				//verificar se e numero
			if(double.TryParse(nota1,out numero1)&&
			   double.TryParse(nota2,out numero2) &&
			   double.TryParse(nota3, out numero3))
				
			{//calculo da media
				double media = (numero1 + numero2 + numero3) /3;
				if (media >=7) 
				{//resposta se aprovado
					lblResultado.Text = "O aluno: "+nome+" esta com "+media.ToString("F2")+" e foi Aprovado";
				}
				else if(media >=5)
				{//resposta recuperacao
					lblResultado.Text = " O aluno: "+nome+" esta com "+media.ToString("F2")+" esta de Recuperaçao";
				}
				else 
				{//resposta se reprovado
					lblResultado.Text = " O aluno: "+nome+" esta com "+media.ToString("F2")+" e foi Reprovado";
				}
			}
			//se deixar em branco as notas
			else if (string.IsNullOrWhiteSpace(nota1)&&
			         string .IsNullOrWhiteSpace(nota2)&&
			          string . IsNullOrWhiteSpace(nota3))
			{
				MessageBox.Show ("Coloque o valor na caixa");
			}
			else
			{//se colocar valor que nao seja numero
				MessageBox.Show ("Valor invalido");
			}
			//apaga os formularios pos uso do programa
			  txtNome.Clear();
              txtNome.Focus();
              txtNota1.Clear();
              txtNota1.Focus();
              txtNota2.Clear();
              txtNota2.Focus();
              txtNota3.Clear();
              txtNota3.Focus();

		}
	}
}
