using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ATIVIDADE_12
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			

		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void BtnVerificarClick(object sender, EventArgs e)
		{
			parimpar calculo = new parimpar();
			 
			calculo.Numero = Convert.ToInt32(txtNumero.Text);
			
			string final = calculo.Verificador();
			
			lblResultado.Text = " "+final+" ";
			txtNumero.Clear();
			
		}
	}
}
