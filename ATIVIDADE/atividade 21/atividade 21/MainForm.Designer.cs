/*
 * Created by SharpDevelop.
 * User: Flavio
 * Date: 26/06/2026
 * Time: 09:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_21
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Button btnVerificarUsuario;
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
			this.btnVerificarUsuario = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNome
			// 
			this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(12, 28);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(574, 93);
			this.lblNome.TabIndex = 0;
			this.lblNome.Text = "Digite seu nome:";
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.ForeColor = System.Drawing.Color.Fuchsia;
			this.txtNome.Location = new System.Drawing.Point(12, 124);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(195, 44);
			this.txtNome.TabIndex = 1;
			this.txtNome.TextChanged += new System.EventHandler(this.TxtNomeTextChanged);
			// 
			// btnVerificarUsuario
			// 
			this.btnVerificarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnVerificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerificarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnVerificarUsuario.Location = new System.Drawing.Point(426, 206);
			this.btnVerificarUsuario.Name = "btnVerificarUsuario";
			this.btnVerificarUsuario.Size = new System.Drawing.Size(211, 81);
			this.btnVerificarUsuario.TabIndex = 2;
			this.btnVerificarUsuario.Text = "Verificar usuário";
			this.btnVerificarUsuario.UseVisualStyleBackColor = false;
			this.btnVerificarUsuario.Click += new System.EventHandler(this.BtnVerificarUsuarioClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(37, 366);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(574, 93);
			this.lblResultado.TabIndex = 3;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(680, 481);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnVerificarUsuario);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblNome);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "atividade 21";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
