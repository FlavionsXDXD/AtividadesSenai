using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VerificadorParÍmpar
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
		
		}
		void BtnVerificarClick(object sender, EventArgs e)
		{
			//a variavel do numero solicitado
			string valorcaixa = txtNumero.Text;
			int Numero;
			//a declaraçao da variavel tem que ser em numero inteiro
			if (int.TryParse(valorcaixa, out  Numero))
				//faz a verificaçao do numero se a divisao por 2 restar 0
				{
					if (Numero  % 2 == 0)
					{//mensagem caso for par
						lblResultado.Text = "Esse numero: "+valorcaixa+" e Par: ";
						
					}
					
					else 
					{//caso for impar
						lblResultado.Text = "Esse numero: "+valorcaixa+" e Impar ";
					}
			}
			//caso o usuario deixe a caixa vazia
			else if  (string.IsNullOrWhiteSpace(valorcaixa))
			{
				MessageBox.Show("Caixa vazia, Digite um numero");
			}
			
			//erro da mensagem caso colocar qualquer coisa que nao seja um numero
				else
				{
					MessageBox.Show("Invalido digite um numero");
				}
				//apagar a caixa onde o numero foi digitado
				    txtNumero.Clear();
                    txtNumero.Focus();
				}
		
			}
	}


