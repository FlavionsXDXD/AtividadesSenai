/*
 * Created by SharpDevelop.
 * User: Flavio
 * Date: 26/06/2026
 * Time: 09:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_19
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Button btnVerificarDivisibilidade;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtNumero;
		
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
			this.btnVerificarDivisibilidade = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblNumero
			// 
			this.lblNumero.Location = new System.Drawing.Point(12, 19);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(213, 50);
			this.lblNumero.TabIndex = 0;
			this.lblNumero.Text = "Número inteiro:";
			// 
			// btnVerificarDivisibilidade
			// 
			this.btnVerificarDivisibilidade.BackColor = System.Drawing.Color.Maroon;
			this.btnVerificarDivisibilidade.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnVerificarDivisibilidade.Location = new System.Drawing.Point(427, 286);
			this.btnVerificarDivisibilidade.Name = "btnVerificarDivisibilidade";
			this.btnVerificarDivisibilidade.Size = new System.Drawing.Size(159, 72);
			this.btnVerificarDivisibilidade.TabIndex = 1;
			this.btnVerificarDivisibilidade.Text = "Verificar divisibilidade";
			this.btnVerificarDivisibilidade.UseVisualStyleBackColor = false;
			this.btnVerificarDivisibilidade.Click += new System.EventHandler(this.BtnVerificarDivisibilidadeClick);
			// 
			// lblResultado
			// 
			this.lblResultado.ForeColor = System.Drawing.Color.Green;
			this.lblResultado.Location = new System.Drawing.Point(39, 345);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(353, 72);
			this.lblResultado.TabIndex = 2;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(265, 19);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 35);
			this.txtNumero.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(618, 439);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnVerificarDivisibilidade);
			this.Controls.Add(this.lblNumero);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "atividade 19";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
