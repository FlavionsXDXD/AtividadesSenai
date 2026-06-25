/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 11:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ATIVIDADE_12
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button btnVerificar;
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
			this.btnVerificar = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNumero
			// 
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero.Location = new System.Drawing.Point(12, 28);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(278, 35);
			this.lblNumero.TabIndex = 0;
			this.lblNumero.Text = "Digite o numero: ";
			this.lblNumero.Click += new System.EventHandler(this.Label1Click);
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(296, 41);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 20);
			this.txtNumero.TabIndex = 1;
			// 
			// btnVerificar
			// 
			this.btnVerificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnVerificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnVerificar.Location = new System.Drawing.Point(564, 56);
			this.btnVerificar.Name = "btnVerificar";
			this.btnVerificar.Size = new System.Drawing.Size(104, 56);
			this.btnVerificar.TabIndex = 2;
			this.btnVerificar.Text = "Verificar ";
			this.btnVerificar.UseVisualStyleBackColor = false;
			this.btnVerificar.Click += new System.EventHandler(this.BtnVerificarClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(12, 404);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(883, 59);
			this.lblResultado.TabIndex = 3;
			this.lblResultado.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1038, 472);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnVerificar);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblNumero);
			this.Name = "MainForm";
			this.Text = "ATIVIDADE 12";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
