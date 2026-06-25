/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 18/06/2026
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Classificaçao
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnClassificarNumero;
		
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
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnClassificarNumero = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNumero
			// 
			this.lblNumero.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero.ForeColor = System.Drawing.Color.Lime;
			this.lblNumero.Location = new System.Drawing.Point(96, 93);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(374, 62);
			this.lblNumero.TabIndex = 0;
			this.lblNumero.Text = "Digite um número:";
			// 
			// txtNumero
			// 
			this.txtNumero.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtNumero.Location = new System.Drawing.Point(387, 99);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(152, 31);
			this.txtNumero.TabIndex = 1;
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.Lime;
			this.lblResultado.Location = new System.Drawing.Point(12, 270);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(644, 122);
			this.lblResultado.TabIndex = 2;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnClassificarNumero
			// 
			this.btnClassificarNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnClassificarNumero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClassificarNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClassificarNumero.ForeColor = System.Drawing.Color.Lime;
			this.btnClassificarNumero.Location = new System.Drawing.Point(387, 177);
			this.btnClassificarNumero.Name = "btnClassificarNumero";
			this.btnClassificarNumero.Size = new System.Drawing.Size(156, 78);
			this.btnClassificarNumero.TabIndex = 3;
			this.btnClassificarNumero.Text = "Classificar";
			this.btnClassificarNumero.UseVisualStyleBackColor = false;
			this.btnClassificarNumero.Click += new System.EventHandler(this.BtnClassificarNumeroClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(682, 414);
			this.Controls.Add(this.btnClassificarNumero);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblNumero);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Classificaçao";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
