using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_17
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void BntValidarAcessoClick(object sender, EventArgs e)
		{
			Login final1 = new Login();
			
			final1.Idade = Convert.ToInt16(txtIdade.Text);
			final1.Nome = Convert.ToString(txtNome.Text);
			
			string resposta = final1.permissao();
			
			lblResultado.Text =" " +resposta+ " ";
			txtIdade.Clear();
			txtNome.Clear();
		}
	}
}
