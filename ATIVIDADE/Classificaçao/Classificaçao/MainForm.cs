using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Classificaçao
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void BtnClassificarNumeroClick(object sender, EventArgs e)
		{
			string valor = txtNumero.Text;
			int numero;
			if(int.TryParse(valor,out numero))
			{
				if(numero >0)
				{
					lblResultado.Text = "O [ "+numero+" ] e numero positivo";
					
				}
				else if (numero<0)
				{
					lblResultado.Text = "O [ "+numero+" ] e um numero negativo";
				}
				else
				{
					lblResultado.Text ="O [ "+numero+" ] e nulo";
				}
			}
			else
			{
				MessageBox.Show ("valor invalido");
			}
			txtNumero.Clear();
		}
	}
}
