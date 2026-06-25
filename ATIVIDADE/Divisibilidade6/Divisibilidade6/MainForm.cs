using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Divisibilidade6
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void BtnVerificarDivisibilidadeClick(object sender, EventArgs e)
		{
			string valor = txtNumero.Text;
			double numero;
			if(double.TryParse(valor, out numero))
			{
				if(numero % 3 ==0 && numero % 7 ==0)
				{
					lblResultado.Text = "O [ "+numero+" ] e divisivel por 3 e 7! ";
				}
				else
				{
					lblResultado.Text = " O [ " +numero+  " ] nao e divisivel por 3 e 7 !";
				}
			}
			else
			{
				MessageBox.Show ("coloque um valor valido");
			}
		}
	}
}
