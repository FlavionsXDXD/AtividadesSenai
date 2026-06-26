/*
 * Created by SharpDevelop.
 * User: Flavio
 * Date: 26/06/2026
 * Time: 11:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_24
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnVerificarPalavra;
		private System.Windows.Forms.TextBox txtPalavra;
		private System.Windows.Forms.Label lblPalavra;
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
			this.btnVerificarPalavra = new System.Windows.Forms.Button();
			this.txtPalavra = new System.Windows.Forms.TextBox();
			this.lblPalavra = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnVerificarPalavra
			// 
			this.btnVerificarPalavra.AutoSize = true;
			this.btnVerificarPalavra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnVerificarPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerificarPalavra.Location = new System.Drawing.Point(484, 154);
			this.btnVerificarPalavra.Name = "btnVerificarPalavra";
			this.btnVerificarPalavra.Size = new System.Drawing.Size(237, 123);
			this.btnVerificarPalavra.TabIndex = 0;
			this.btnVerificarPalavra.Text = "Verificar palavra";
			this.btnVerificarPalavra.UseVisualStyleBackColor = false;
			this.btnVerificarPalavra.Click += new System.EventHandler(this.BtnVerificarPalavraClick);
			// 
			// txtPalavra
			// 
			this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPalavra.Location = new System.Drawing.Point(339, 29);
			this.txtPalavra.Name = "txtPalavra";
			this.txtPalavra.Size = new System.Drawing.Size(100, 35);
			this.txtPalavra.TabIndex = 1;
			// 
			// lblPalavra
			// 
			this.lblPalavra.AutoSize = true;
			this.lblPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPalavra.Location = new System.Drawing.Point(47, 31);
			this.lblPalavra.Name = "lblPalavra";
			this.lblPalavra.Size = new System.Drawing.Size(286, 33);
			this.lblPalavra.TabIndex = 2;
			this.lblPalavra.Text = "Digite uma palavra:";
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(104, 304);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(475, 177);
			this.lblResultado.TabIndex = 3;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(751, 506);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblPalavra);
			this.Controls.Add(this.txtPalavra);
			this.Controls.Add(this.btnVerificarPalavra);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "atividade 24";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
