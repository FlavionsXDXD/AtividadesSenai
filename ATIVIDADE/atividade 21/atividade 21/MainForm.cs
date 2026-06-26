using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_21
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void TxtNomeTextChanged(object sender, EventArgs e)
		{
	
		}
		void BtnVerificarUsuarioClick(object sender, EventArgs e)
		{
			
			reconhecer usuario = new reconhecer();
			
			usuario.Nome = Convert.ToString(txtNome.Text);
			
			
			
			string final = usuario.Validar();
			
			
			lblResultado.Text = " "+final+" ";
			txtNome.Clear();
			
			
		}
	}
}
