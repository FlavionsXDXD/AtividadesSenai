/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 11:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ATIVIDADE13
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblIdade;
		private System.Windows.Forms.TextBox txtIdade;
		private System.Windows.Forms.Label lblCarteira;
		private System.Windows.Forms.TextBox txtCarteira;
		private System.Windows.Forms.Button btnVerificarDirecao;
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
			this.lblIdade = new System.Windows.Forms.Label();
			this.txtIdade = new System.Windows.Forms.TextBox();
			this.lblCarteira = new System.Windows.Forms.Label();
			this.txtCarteira = new System.Windows.Forms.TextBox();
			this.btnVerificarDirecao = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblIdade
			// 
			this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblIdade.Location = new System.Drawing.Point(12, 33);
			this.lblIdade.Name = "lblIdade";
			this.lblIdade.Size = new System.Drawing.Size(160, 32);
			this.lblIdade.TabIndex = 0;
			this.lblIdade.Text = "idade:";
			// 
			// txtIdade
			// 
			this.txtIdade.Location = new System.Drawing.Point(127, 45);
			this.txtIdade.Name = "txtIdade";
			this.txtIdade.Size = new System.Drawing.Size(100, 20);
			this.txtIdade.TabIndex = 1;
			// 
			// lblCarteira
			// 
			this.lblCarteira.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCarteira.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblCarteira.Location = new System.Drawing.Point(12, 99);
			this.lblCarteira.Name = "lblCarteira";
			this.lblCarteira.Size = new System.Drawing.Size(234, 93);
			this.lblCarteira.TabIndex = 2;
			this.lblCarteira.Text = "possui carteira de motorista? (sim/não):";
			// 
			// txtCarteira
			// 
			this.txtCarteira.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCarteira.Location = new System.Drawing.Point(270, 111);
			this.txtCarteira.Multiline = true;
			this.txtCarteira.Name = "txtCarteira";
			this.txtCarteira.Size = new System.Drawing.Size(162, 59);
			this.txtCarteira.TabIndex = 3;
			// 
			// btnVerificarDirecao
			// 
			this.btnVerificarDirecao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnVerificarDirecao.Location = new System.Drawing.Point(46, 347);
			this.btnVerificarDirecao.Name = "btnVerificarDirecao";
			this.btnVerificarDirecao.Size = new System.Drawing.Size(107, 48);
			this.btnVerificarDirecao.TabIndex = 4;
			this.btnVerificarDirecao.Text = "Verificar DIreção";
			this.btnVerificarDirecao.UseVisualStyleBackColor = false;
			this.btnVerificarDirecao.Click += new System.EventHandler(this.BtnVerificarDirecaoClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblResultado.Location = new System.Drawing.Point(173, 288);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(483, 109);
			this.lblResultado.TabIndex = 5;
			this.lblResultado.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(976, 421);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnVerificarDirecao);
			this.Controls.Add(this.txtCarteira);
			this.Controls.Add(this.lblCarteira);
			this.Controls.Add(this.txtIdade);
			this.Controls.Add(this.lblIdade);
			this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Name = "MainForm";
			this.Text = "ATIVIDADE13";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
