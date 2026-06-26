using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_25
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void BtnVerificarCancelamentoClick(object sender, EventArgs e)
		{
			Confirmar Operaçao = new Confirmar();
			
			Operaçao.Resposta= Convert.ToString(txtCancelar.Text);
			
			string final = Operaçao.Validar();
			lblResultado.Text = " "+final+" ";
			txtCancelar.Clear();
	
		}
	}
}
