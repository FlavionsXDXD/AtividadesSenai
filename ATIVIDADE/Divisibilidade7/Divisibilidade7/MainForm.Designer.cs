/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 18/06/2026
 * Time: 11:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Divisibilidade7
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnVerificarDivisores;
		private System.Windows.Forms.Label lblNumero;
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
			this.btnVerificarDivisores = new System.Windows.Forms.Button();
			this.lblNumero = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnVerificarDivisores
			// 
			this.btnVerificarDivisores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnVerificarDivisores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVerificarDivisores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerificarDivisores.Location = new System.Drawing.Point(450, 197);
			this.btnVerificarDivisores.Name = "btnVerificarDivisores";
			this.btnVerificarDivisores.Size = new System.Drawing.Size(154, 92);
			this.btnVerificarDivisores.TabIndex = 0;
			this.btnVerificarDivisores.Text = "Verificar divisores";
			this.btnVerificarDivisores.UseVisualStyleBackColor = false;
			this.btnVerificarDivisores.Click += new System.EventHandler(this.BtnVerificarDivisoresClick);
			// 
			// lblNumero
			// 
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero.ForeColor = System.Drawing.Color.Lime;
			this.lblNumero.Location = new System.Drawing.Point(83, 133);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(235, 59);
			this.lblNumero.TabIndex = 1;
			this.lblNumero.Text = "Digite um número:";
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.Lime;
			this.lblResultado.Location = new System.Drawing.Point(12, 310);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(620, 126);
			this.lblResultado.TabIndex = 2;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNumero
			// 
			this.txtNumero.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtNumero.Location = new System.Drawing.Point(312, 133);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 35);
			this.txtNumero.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(668, 445);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.btnVerificarDivisores);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "Divisibilidade7";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
