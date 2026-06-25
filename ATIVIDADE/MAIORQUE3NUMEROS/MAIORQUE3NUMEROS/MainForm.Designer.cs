/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 22/06/2026
 * Time: 08:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MAIORQUE3NUMEROS
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNumero1;
		private System.Windows.Forms.Label lblNumero2;
		private System.Windows.Forms.Label lblNumero3;
		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.TextBox txtNumero2;
		private System.Windows.Forms.TextBox txtNumero3;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnEncontrarMaior;
		
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
			this.lblNumero1 = new System.Windows.Forms.Label();
			this.lblNumero2 = new System.Windows.Forms.Label();
			this.lblNumero3 = new System.Windows.Forms.Label();
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.txtNumero3 = new System.Windows.Forms.TextBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnEncontrarMaior = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNumero1
			// 
			this.lblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.lblNumero1.Location = new System.Drawing.Point(112, 83);
			this.lblNumero1.Name = "lblNumero1";
			this.lblNumero1.Size = new System.Drawing.Size(266, 40);
			this.lblNumero1.TabIndex = 0;
			this.lblNumero1.Text = "Primeiro número:";
			// 
			// lblNumero2
			// 
			this.lblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.lblNumero2.Location = new System.Drawing.Point(112, 138);
			this.lblNumero2.Name = "lblNumero2";
			this.lblNumero2.Size = new System.Drawing.Size(266, 40);
			this.lblNumero2.TabIndex = 1;
			this.lblNumero2.Text = "Segundo número:";
			// 
			// lblNumero3
			// 
			this.lblNumero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.lblNumero3.Location = new System.Drawing.Point(112, 197);
			this.lblNumero3.Name = "lblNumero3";
			this.lblNumero3.Size = new System.Drawing.Size(266, 40);
			this.lblNumero3.TabIndex = 2;
			this.lblNumero3.Text = "Terceiro número:";
			// 
			// txtNumero1
			// 
			this.txtNumero1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtNumero1.Location = new System.Drawing.Point(348, 83);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(100, 31);
			this.txtNumero1.TabIndex = 3;
			// 
			// txtNumero2
			// 
			this.txtNumero2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtNumero2.Location = new System.Drawing.Point(348, 138);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(100, 31);
			this.txtNumero2.TabIndex = 4;
			// 
			// txtNumero3
			// 
			this.txtNumero3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtNumero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtNumero3.Location = new System.Drawing.Point(348, 197);
			this.txtNumero3.Name = "txtNumero3";
			this.txtNumero3.Size = new System.Drawing.Size(100, 31);
			this.txtNumero3.TabIndex = 5;
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.lblResultado.Location = new System.Drawing.Point(3, 272);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(849, 160);
			this.lblResultado.TabIndex = 6;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnEncontrarMaior
			// 
			this.btnEncontrarMaior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnEncontrarMaior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEncontrarMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEncontrarMaior.ForeColor = System.Drawing.Color.White;
			this.btnEncontrarMaior.Location = new System.Drawing.Point(552, 103);
			this.btnEncontrarMaior.Name = "btnEncontrarMaior";
			this.btnEncontrarMaior.Size = new System.Drawing.Size(133, 100);
			this.btnEncontrarMaior.TabIndex = 7;
			this.btnEncontrarMaior.Text = "Encontrar maior";
			this.btnEncontrarMaior.UseVisualStyleBackColor = false;
			this.btnEncontrarMaior.Click += new System.EventHandler(this.BtnEncontrarMaiorClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(857, 441);
			this.Controls.Add(this.btnEncontrarMaior);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.txtNumero3);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.Controls.Add(this.lblNumero3);
			this.Controls.Add(this.lblNumero2);
			this.Controls.Add(this.lblNumero1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MAIORQUE3NUMEROS";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
