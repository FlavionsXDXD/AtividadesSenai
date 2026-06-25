using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade11
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void BtnCalcularEquacaoClick(object sender, EventArgs e)
		{
			euquaçao calculo = new euquaçao();
			
			calculo.Numero1 = Convert.ToInt32(txtValorA.Text);
			calculo.Numero2 = Convert.ToInt32(txtValorB.Text);
			calculo.Numero3 = Convert.ToInt32(txtValorC.Text);
			
			string Final = calculo.SegundoGrau();
			
			lblResultado.Text = " "+Final+" ";
			txtValorA.Clear();
			txtValorB.Clear();
			txtValorC.Clear();
		}
	}
}
