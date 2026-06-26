using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_18
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			Programacafe Cafezinho = new Programacafe();
			
			Cafezinho.Pergunta1=Convert.ToString(txtAcucar.Text);
			Cafezinho.Pergunta2=Convert.ToString(txtleite.Text);
			
			string resposta = Cafezinho.Servir();
			lblResultado.Text = " "+resposta+ " ";
			txtAcucar.Clear();
			txtleite.Clear();
			
		}
	}
}
