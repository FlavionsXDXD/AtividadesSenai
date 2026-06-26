/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 10:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace novaatividade16
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblAssinante;
		private System.Windows.Forms.Button btnVerificarTemporada;
		private System.Windows.Forms.Label lblAssistiu;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtAssistiu;
		private System.Windows.Forms.TextBox txtAssinante;
		
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
			this.lblAssinante = new System.Windows.Forms.Label();
			this.btnVerificarTemporada = new System.Windows.Forms.Button();
			this.lblAssistiu = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtAssistiu = new System.Windows.Forms.TextBox();
			this.txtAssinante = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblAssinante
			// 
			this.lblAssinante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAssinante.Location = new System.Drawing.Point(12, 9);
			this.lblAssinante.Name = "lblAssinante";
			this.lblAssinante.Size = new System.Drawing.Size(363, 83);
			this.lblAssinante.TabIndex = 0;
			this.lblAssinante.Text = "É assinante do serviço? (sim/não):";
			// 
			// btnVerificarTemporada
			// 
			this.btnVerificarTemporada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnVerificarTemporada.Location = new System.Drawing.Point(381, 163);
			this.btnVerificarTemporada.Name = "btnVerificarTemporada";
			this.btnVerificarTemporada.Size = new System.Drawing.Size(137, 68);
			this.btnVerificarTemporada.TabIndex = 1;
			this.btnVerificarTemporada.Text = "Verificar acesso";
			this.btnVerificarTemporada.UseVisualStyleBackColor = true;
			this.btnVerificarTemporada.Click += new System.EventHandler(this.BtnVerificarTemporadaClick);
			// 
			// lblAssistiu
			// 
			this.lblAssistiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAssistiu.Location = new System.Drawing.Point(12, 121);
			this.lblAssistiu.Name = "lblAssistiu";
			this.lblAssistiu.Size = new System.Drawing.Size(363, 92);
			this.lblAssistiu.TabIndex = 2;
			this.lblAssistiu.Text = "Já assistiu à série anterior? (sim/não):";
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblResultado.Location = new System.Drawing.Point(12, 248);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(382, 96);
			this.lblResultado.TabIndex = 3;
			this.lblResultado.Text = "Resultado";
			// 
			// txtAssistiu
			// 
			this.txtAssistiu.Location = new System.Drawing.Point(27, 216);
			this.txtAssistiu.Name = "txtAssistiu";
			this.txtAssistiu.Size = new System.Drawing.Size(100, 29);
			this.txtAssistiu.TabIndex = 4;
			// 
			// txtAssinante
			// 
			this.txtAssinante.Location = new System.Drawing.Point(27, 89);
			this.txtAssinante.Name = "txtAssinante";
			this.txtAssinante.Size = new System.Drawing.Size(100, 29);
			this.txtAssinante.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(546, 353);
			this.Controls.Add(this.txtAssinante);
			this.Controls.Add(this.txtAssistiu);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblAssistiu);
			this.Controls.Add(this.btnVerificarTemporada);
			this.Controls.Add(this.lblAssinante);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "novaatividade16";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
