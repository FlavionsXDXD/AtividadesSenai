using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MAIORQUE20
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
			double numero;
			string valor = txtNumero.Text;
			
			if(double.TryParse(valor,out numero))
			   {
			   	if(numero >= 20)
			   	{
			   		lblResultado.Text = "Condiçao atendida Numero:"+ (numero / 2.0).ToString("F2");
			   	}
			   	
			   	else
			   	{
			   		lblResultado.Text = "condiçao nao atendida Numero:"+numero+"";
			   	}
			   }
			else
			{
				MessageBox.Show ("coloque um valor valido");
			}
			txtNumero.Clear();
			
			
		}
		
	}
}
