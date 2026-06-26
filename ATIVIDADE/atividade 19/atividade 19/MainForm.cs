using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_19
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			

			
		}
		void BtnVerificarDivisibilidadeClick(object sender, EventArgs e)
		{
				Divisivibilidade dividir = new Divisivibilidade();
			
				dividir.Numero = Convert.ToInt32(txtNumero.Text);
				string resposta = dividir.Calculo();
				
				lblResultado.Text = " "+resposta+" ";
				txtNumero.Clear();
				
				
		}
	}
}
