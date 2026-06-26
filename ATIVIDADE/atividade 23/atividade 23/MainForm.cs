using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_23
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void BtnVerificarClubeClick(object sender, EventArgs e)
		{
			Beneficio Membro = new Beneficio();
			
			Membro.Resposta= Convert.ToString(txtMembroAtivo.Text);
			
			string final = Membro.Validar();
			lblResultado.Text = " " +final+ " ";
			txtMembroAtivo.Clear();
		}
		
		
		void TxtMembroAtivoTextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
