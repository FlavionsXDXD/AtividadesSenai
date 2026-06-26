using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace novaatividade16
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void BtnVerificarTemporadaClick(object sender, EventArgs e)
		{
			stream HBO = new stream();
			
			HBO.Assistir = Convert.ToString(txtAssistiu.Text);
			HBO.Assinar = Convert.ToString(txtAssinante.Text);
			
			string final = HBO.Netflix();
			
			lblResultado.Text = " " +final+ " ";
		}
		
	}
}
