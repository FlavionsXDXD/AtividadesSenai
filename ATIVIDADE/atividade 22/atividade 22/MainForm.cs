using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_22
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			gerencia numerol = new gerencia();
			
			numerol.Numero = Convert.ToInt32(txtNumero.Text);
			
			string final = numerol.Validar();
			
			lblResultado.Text = " " +final+ " ";
			txtNumero.Clear();
		}
	}
}
