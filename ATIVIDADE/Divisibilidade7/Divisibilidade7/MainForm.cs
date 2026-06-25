using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Divisibilidade7
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			
		}
		void BtnVerificarDivisoresClick(object sender, EventArgs e)
		{
			string valor = txtNumero.Text;
			double numero;
	if(double.TryParse(valor, out numero))
			{//verifica se a divisao vai restar 0 confirmando que e dividido
				if(numero % 3 ==0 && numero % 7 ==0)
				{
					lblResultado.Text = "O [ "+numero+" ] e divisivel por 3 e 7! ";
				}
				else
				{//quando nao e divisivel
					lblResultado.Text = " O [ " +numero+  " ] nao e divisivel por 3 e 7 !";
				}
			}
			else
			{//quando o valor nao e valido
				MessageBox.Show ("coloque um valor valido");
			}
		}
	}
}
