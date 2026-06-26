/*
 * Created by SharpDevelop.
 * User: Flavio
 * Date: 26/06/2026
 * Time: 11:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_25
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblCancelar;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnVerificarCancelamento;
		private System.Windows.Forms.TextBox txtCancelar;
		
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
			this.lblCancelar = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnVerificarCancelamento = new System.Windows.Forms.Button();
			this.txtCancelar = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblCancelar
			// 
			this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCancelar.Location = new System.Drawing.Point(37, 22);
			this.lblCancelar.Name = "lblCancelar";
			this.lblCancelar.Size = new System.Drawing.Size(525, 80);
			this.lblCancelar.TabIndex = 0;
			this.lblCancelar.Text = "Você não deseja cancelar a operação? (sim/não):";
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.lblResultado.Location = new System.Drawing.Point(37, 294);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(615, 121);
			this.lblResultado.TabIndex = 1;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnVerificarCancelamento
			// 
			this.btnVerificarCancelamento.BackColor = System.Drawing.Color.Maroon;
			this.btnVerificarCancelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerificarCancelamento.Location = new System.Drawing.Point(483, 159);
			this.btnVerificarCancelamento.Name = "btnVerificarCancelamento";
			this.btnVerificarCancelamento.Size = new System.Drawing.Size(169, 87);
			this.btnVerificarCancelamento.TabIndex = 2;
			this.btnVerificarCancelamento.Text = "Verificar cancelamento";
			this.btnVerificarCancelamento.UseVisualStyleBackColor = false;
			this.btnVerificarCancelamento.Click += new System.EventHandler(this.BtnVerificarCancelamentoClick);
			// 
			// txtCancelar
			// 
			this.txtCancelar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCancelar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.txtCancelar.Location = new System.Drawing.Point(186, 57);
			this.txtCancelar.Name = "txtCancelar";
			this.txtCancelar.Size = new System.Drawing.Size(179, 31);
			this.txtCancelar.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(684, 424);
			this.Controls.Add(this.txtCancelar);
			this.Controls.Add(this.btnVerificarCancelamento);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblCancelar);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "atividade 25";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
