using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_24
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			
		}
		void BtnVerificarPalavraClick(object sender, EventArgs e)
		{
			Palavra falar = new Palavra();
			
			falar.Resposta = Convert.ToString(txtPalavra.Text);
			
			string final = falar.Validar();
			lblResultado.Text = ""+final+"";
			txtPalavra.Clear();
		}
	}
}
