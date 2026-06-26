/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 11:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_17
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblIdade;
		private System.Windows.Forms.TextBox txtIdade;
		private System.Windows.Forms.Button bntValidarAcesso;
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
			this.lblNome = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblIdade = new System.Windows.Forms.Label();
			this.txtIdade = new System.Windows.Forms.TextBox();
			this.bntValidarAcesso = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNome
			// 
			this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(12, 9);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(161, 39);
			this.lblNome.TabIndex = 0;
			this.lblNome.Text = "Nome:";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(133, 21);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(100, 20);
			this.txtNome.TabIndex = 1;
			// 
			// lblIdade
			// 
			this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdade.Location = new System.Drawing.Point(12, 59);
			this.lblIdade.Name = "lblIdade";
			this.lblIdade.Size = new System.Drawing.Size(123, 38);
			this.lblIdade.TabIndex = 2;
			this.lblIdade.Text = "idade:";
			// 
			// txtIdade
			// 
			this.txtIdade.Location = new System.Drawing.Point(133, 71);
			this.txtIdade.Name = "txtIdade";
			this.txtIdade.Size = new System.Drawing.Size(100, 20);
			this.txtIdade.TabIndex = 3;
			// 
			// bntValidarAcesso
			// 
			this.bntValidarAcesso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.bntValidarAcesso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntValidarAcesso.Location = new System.Drawing.Point(13, 366);
			this.bntValidarAcesso.Name = "bntValidarAcesso";
			this.bntValidarAcesso.Size = new System.Drawing.Size(122, 44);
			this.bntValidarAcesso.TabIndex = 4;
			this.bntValidarAcesso.Text = "Validar Acesso ";
			this.bntValidarAcesso.UseVisualStyleBackColor = false;
			this.bntValidarAcesso.Click += new System.EventHandler(this.BntValidarAcessoClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(12, 160);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(272, 39);
			this.lblResultado.TabIndex = 5;
			this.lblResultado.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 435);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.bntValidarAcesso);
			this.Controls.Add(this.txtIdade);
			this.Controls.Add(this.lblIdade);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblNome);
			this.Name = "MainForm";
			this.Text = "atividade 17";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
