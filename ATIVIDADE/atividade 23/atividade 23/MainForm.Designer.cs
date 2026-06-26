/*
 * Created by SharpDevelop.
 * User: Flavio
 * Date: 26/06/2026
 * Time: 10:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_23
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblMembroAtivo;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnVerificarClube;
		private System.Windows.Forms.TextBox txtMembroAtivo;
		
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
			this.lblMembroAtivo = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnVerificarClube = new System.Windows.Forms.Button();
			this.txtMembroAtivo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblMembroAtivo
			// 
			this.lblMembroAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMembroAtivo.Location = new System.Drawing.Point(48, 23);
			this.lblMembroAtivo.Name = "lblMembroAtivo";
			this.lblMembroAtivo.Size = new System.Drawing.Size(343, 87);
			this.lblMembroAtivo.TabIndex = 0;
			this.lblMembroAtivo.Text = "Você não é um membro inativo? (sim/não):";
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.Lime;
			this.lblResultado.Location = new System.Drawing.Point(48, 327);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(457, 121);
			this.lblResultado.TabIndex = 1;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnVerificarClube
			// 
			this.btnVerificarClube.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerificarClube.Location = new System.Drawing.Point(514, 159);
			this.btnVerificarClube.Name = "btnVerificarClube";
			this.btnVerificarClube.Size = new System.Drawing.Size(127, 68);
			this.btnVerificarClube.TabIndex = 2;
			this.btnVerificarClube.Text = "Verificar inscrição";
			this.btnVerificarClube.UseVisualStyleBackColor = true;
			this.btnVerificarClube.Click += new System.EventHandler(this.BtnVerificarClubeClick);
			// 
			// txtMembroAtivo
			// 
			this.txtMembroAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMembroAtivo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.txtMembroAtivo.Location = new System.Drawing.Point(60, 113);
			this.txtMembroAtivo.Name = "txtMembroAtivo";
			this.txtMembroAtivo.Size = new System.Drawing.Size(100, 31);
			this.txtMembroAtivo.TabIndex = 3;
			this.txtMembroAtivo.TextChanged += new System.EventHandler(this.TxtMembroAtivoTextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(722, 457);
			this.Controls.Add(this.txtMembroAtivo);
			this.Controls.Add(this.btnVerificarClube);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblMembroAtivo);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "atividade 23";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
