using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ATIVIDADE14
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
			
		}
		void BtnVerificarCompraClick(object sender, EventArgs e)
		{
			concessionária carro = new concessionária();
			
			carro.Dindin = Convert.ToString(txtDinheiro.Text);
			carro.Interesse = Convert.ToString(txtDesejoCarro.Text);
			
			string final = carro.Negociar();
			
			lblResultado.Text = " " +final+ " ";
			txtDinheiro.Clear();
			txtDesejoCarro.Clear();
		}
	}
}
