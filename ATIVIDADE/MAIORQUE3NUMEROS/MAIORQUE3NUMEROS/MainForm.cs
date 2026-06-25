using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MAIORQUE3NUMEROS
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		void BtnEncontrarMaiorClick(object sender, EventArgs e)
		{
			Maior_numero fazer = new Maior_numero();
			
			fazer.valor1= Convert.ToInt32(txtNumero1.Text);
			fazer.valor2= Convert.ToInt32(txtNumero2.Text);
			fazer.valor3= Convert.ToInt32(txtNumero3.Text);
			
			string Maiordeles= fazer.Maior_tres();
			
			lblResultado.Text= "( "+Maiordeles+" )";
		}
	}
}
