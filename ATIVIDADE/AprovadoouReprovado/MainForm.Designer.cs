/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 17/06/2026
 * Time: 08:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AprovadoouReprovado
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblNota1;
		private System.Windows.Forms.Label lblNota2;
		private System.Windows.Forms.Label lblNota3;
		private System.Windows.Forms.TextBox txtNota2;
		private System.Windows.Forms.TextBox txtNota1;
		private System.Windows.Forms.TextBox txtNota3;
		private System.Windows.Forms.Button btnCalcularMedia;
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
			this.lblNota1 = new System.Windows.Forms.Label();
			this.lblNota2 = new System.Windows.Forms.Label();
			this.lblNota3 = new System.Windows.Forms.Label();
			this.txtNota2 = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtNota1 = new System.Windows.Forms.TextBox();
			this.txtNota3 = new System.Windows.Forms.TextBox();
			this.btnCalcularMedia = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNome
			// 
			this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblNome.Location = new System.Drawing.Point(26, 85);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(211, 58);
			this.lblNome.TabIndex = 0;
			this.lblNome.Text = "Nome do aluno :";
			// 
			// lblNota1
			// 
			this.lblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNota1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblNota1.Location = new System.Drawing.Point(26, 143);
			this.lblNota1.Name = "lblNota1";
			this.lblNota1.Size = new System.Drawing.Size(211, 58);
			this.lblNota1.TabIndex = 2;
			this.lblNota1.Text = "Primeira nota :";
			// 
			// lblNota2
			// 
			this.lblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNota2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblNota2.Location = new System.Drawing.Point(26, 201);
			this.lblNota2.Name = "lblNota2";
			this.lblNota2.Size = new System.Drawing.Size(211, 58);
			this.lblNota2.TabIndex = 3;
			this.lblNota2.Text = "Segunda nota :";
			// 
			// lblNota3
			// 
			this.lblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNota3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblNota3.Location = new System.Drawing.Point(26, 259);
			this.lblNota3.Name = "lblNota3";
			this.lblNota3.Size = new System.Drawing.Size(211, 58);
			this.lblNota3.TabIndex = 4;
			this.lblNota3.Text = "Terceira Nota :";
			// 
			// txtNota2
			// 
			this.txtNota2.BackColor = System.Drawing.Color.Black;
			this.txtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNota2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.txtNota2.Location = new System.Drawing.Point(243, 210);
			this.txtNota2.Name = "txtNota2";
			this.txtNota2.Size = new System.Drawing.Size(192, 26);
			this.txtNota2.TabIndex = 7;
			// 
			// txtNome
			// 
			this.txtNome.BackColor = System.Drawing.Color.Black;
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.txtNome.Location = new System.Drawing.Point(243, 89);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(192, 26);
			this.txtNome.TabIndex = 8;
			// 
			// txtNota1
			// 
			this.txtNota1.BackColor = System.Drawing.Color.Black;
			this.txtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNota1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.txtNota1.Location = new System.Drawing.Point(243, 147);
			this.txtNota1.Name = "txtNota1";
			this.txtNota1.Size = new System.Drawing.Size(192, 26);
			this.txtNota1.TabIndex = 9;
			// 
			// txtNota3
			// 
			this.txtNota3.BackColor = System.Drawing.Color.Black;
			this.txtNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNota3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.txtNota3.Location = new System.Drawing.Point(243, 263);
			this.txtNota3.Name = "txtNota3";
			this.txtNota3.Size = new System.Drawing.Size(192, 26);
			this.txtNota3.TabIndex = 10;
			// 
			// btnCalcularMedia
			// 
			this.btnCalcularMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnCalcularMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCalcularMedia.Font = new System.Drawing.Font("Monospac821 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcularMedia.Location = new System.Drawing.Point(491, 148);
			this.btnCalcularMedia.Name = "btnCalcularMedia";
			this.btnCalcularMedia.Size = new System.Drawing.Size(199, 88);
			this.btnCalcularMedia.TabIndex = 11;
			this.btnCalcularMedia.Text = "Calcular média";
			this.btnCalcularMedia.UseVisualStyleBackColor = false;
			this.btnCalcularMedia.Click += new System.EventHandler(this.BtnCalcularMediaClick);
			// 
			// lblResultado
			// 
			this.lblResultado.BackColor = System.Drawing.Color.Black;
			this.lblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.Green;
			this.lblResultado.Location = new System.Drawing.Point(46, 345);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(666, 131);
			this.lblResultado.TabIndex = 12;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(742, 485);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnCalcularMedia);
			this.Controls.Add(this.txtNota3);
			this.Controls.Add(this.txtNota1);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtNota2);
			this.Controls.Add(this.lblNota3);
			this.Controls.Add(this.lblNota2);
			this.Controls.Add(this.lblNota1);
			this.Controls.Add(this.lblNome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AprovadoouReprovado";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
