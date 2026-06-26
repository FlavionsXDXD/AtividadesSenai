using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_20
{
public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			Compra finalizar = new Compra();
			
			finalizar.Resposta = Convert.ToString(txtRespostaCompra.Text);
			
			string Fim = finalizar.Confirmar();
			
			lblResultado.Text = " "+Fim+" ";
			txtRespostaCompra.Clear();
		}
	}
}
