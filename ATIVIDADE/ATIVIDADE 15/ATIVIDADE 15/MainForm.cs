
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ATIVIDADE_15
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void BtnVerificarVagaClick(object sender, EventArgs e)
		{
			VAGA estudado = new VAGA();
			int numero;
			if(int.TryParse(txtIdade.Text,out numero))
			{
			estudado.Diploma = Convert.ToString(txtDiploma.Text);
			estudado.Idade = Convert.ToInt16(txtIdade.Text);
			
			string final = estudado.Possui();
			
			LBLresultado.Text =" " +final+ " ";
			}
			else
			{
				MessageBox.Show ("coloque um numero valido");
			}
			txtDiploma.Clear();
			txtIdade.Clear();
			
			
			
		}
	}
}
