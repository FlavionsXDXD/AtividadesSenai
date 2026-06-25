using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade10
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		void BtnClassificarCategoriaClick(object sender, EventArgs e)
		{
			nadador lista = new nadador();
			
			lista.Idade = Convert.ToInt16(txtIdade.Text);
			
			string Final = lista.Categoria();
			
			lblResultado.Text = " "+Final+" ";
			
			txtIdade.Clear();
		}
	}
}
