
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace aitvidade_9
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void BtnOrdenarDecresenteClick(object sender, EventArgs e)
		{
			Decresente posiçao = new Decresente();
			
			posiçao.Numero1 = Convert.ToInt32(txtNumero1.Text);
			posiçao.Numero2 = Convert.ToInt32(txtNumero2.Text);
			posiçao.Numero3 = Convert.ToInt32(txtNumero3.Text);
			
			string Final = posiçao.MudarPosicao();
			
			lblResultado.Text = " "+Final+" ";
		}
	}
}
