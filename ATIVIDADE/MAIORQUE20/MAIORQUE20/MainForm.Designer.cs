/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 18/06/2026
 * Time: 08:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MAIORQUE20
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button btnVerificarMetade;
		private System.Windows.Forms.Label lblResultado;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblNumero = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnVerificarMetade = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNumero
			// 
			this.lblNumero.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.lblNumero.Location = new System.Drawing.Point(57, 86);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(313, 51);
			this.lblNumero.TabIndex = 0;
			this.lblNumero.Text = "Digite um número:";
			// 
			// txtNumero
			// 
			this.txtNumero.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtNumero.Location = new System.Drawing.Point(310, 93);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 29);
			this.txtNumero.TabIndex = 1;
			// 
			// btnVerificarMetade
			// 
			this.btnVerificarMetade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnVerificarMetade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnVerificarMetade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerificarMetade.ForeColor = System.Drawing.Color.White;
			this.btnVerificarMetade.Location = new System.Drawing.Point(456, 175);
			this.btnVerificarMetade.Name = "btnVerificarMetade";
			this.btnVerificarMetade.Size = new System.Drawing.Size(157, 86);
			this.btnVerificarMetade.TabIndex = 2;
			this.btnVerificarMetade.Text = "Verificar número";
			this.btnVerificarMetade.UseVisualStyleBackColor = false;
			this.btnVerificarMetade.Click += new System.EventHandler(this.Button1Click);
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.lblResultado.Location = new System.Drawing.Point(88, 304);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(501, 101);
			this.lblResultado.TabIndex = 3;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(657, 440);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnVerificarMetade);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblNumero);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MAIORQUE20";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
