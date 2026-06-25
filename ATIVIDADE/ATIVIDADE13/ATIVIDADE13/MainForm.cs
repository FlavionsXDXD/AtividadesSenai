using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ATIVIDADE13
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
			
		}
		void BtnVerificarDirecaoClick(object sender, EventArgs e)
		{
			MOTORISTA visualizar = new MOTORISTA();
			
			visualizar.Idade = Convert.ToInt16(txtIdade.Text);
			visualizar.Permissao = Convert.ToString(txtCarteira.Text);
			
			string final = visualizar.Dirigir();
			
			lblResultado.Text = " " +final+ " ";
			txtIdade.Clear();
			txtCarteira.Clear();
		}
	}
}
