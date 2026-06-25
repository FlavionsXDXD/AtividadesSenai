/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 23/06/2026
 * Time: 11:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace aitvidade_9
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNumero1;
		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.Label lblNumero2;
		private System.Windows.Forms.TextBox txtNumero2;
		private System.Windows.Forms.Label lblNumero3;
		private System.Windows.Forms.TextBox txtNumero3;
		private System.Windows.Forms.Button btnOrdenarDecresente;
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
			this.lblNumero1 = new System.Windows.Forms.Label();
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.lblNumero2 = new System.Windows.Forms.Label();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.lblNumero3 = new System.Windows.Forms.Label();
			this.txtNumero3 = new System.Windows.Forms.TextBox();
			this.btnOrdenarDecresente = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNumero1
			// 
			this.lblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblNumero1.Location = new System.Drawing.Point(12, 21);
			this.lblNumero1.Name = "lblNumero1";
			this.lblNumero1.Size = new System.Drawing.Size(214, 29);
			this.lblNumero1.TabIndex = 0;
			this.lblNumero1.Text = "Numero1:";
			// 
			// txtNumero1
			// 
			this.txtNumero1.BackColor = System.Drawing.SystemColors.InfoText;
			this.txtNumero1.ForeColor = System.Drawing.Color.Lime;
			this.txtNumero1.Location = new System.Drawing.Point(178, 30);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(100, 20);
			this.txtNumero1.TabIndex = 1;
			// 
			// lblNumero2
			// 
			this.lblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblNumero2.Location = new System.Drawing.Point(12, 68);
			this.lblNumero2.Name = "lblNumero2";
			this.lblNumero2.Size = new System.Drawing.Size(160, 34);
			this.lblNumero2.TabIndex = 2;
			this.lblNumero2.Text = "Numero2:";
			// 
			// txtNumero2
			// 
			this.txtNumero2.BackColor = System.Drawing.SystemColors.InfoText;
			this.txtNumero2.ForeColor = System.Drawing.Color.Lime;
			this.txtNumero2.Location = new System.Drawing.Point(178, 80);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(100, 20);
			this.txtNumero2.TabIndex = 3;
			// 
			// lblNumero3
			// 
			this.lblNumero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblNumero3.Location = new System.Drawing.Point(12, 125);
			this.lblNumero3.Name = "lblNumero3";
			this.lblNumero3.Size = new System.Drawing.Size(153, 31);
			this.lblNumero3.TabIndex = 4;
			this.lblNumero3.Text = "Numero3:";
			// 
			// txtNumero3
			// 
			this.txtNumero3.BackColor = System.Drawing.SystemColors.InfoText;
			this.txtNumero3.ForeColor = System.Drawing.Color.Lime;
			this.txtNumero3.Location = new System.Drawing.Point(178, 137);
			this.txtNumero3.Name = "txtNumero3";
			this.txtNumero3.Size = new System.Drawing.Size(100, 20);
			this.txtNumero3.TabIndex = 5;
			// 
			// btnOrdenarDecresente
			// 
			this.btnOrdenarDecresente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnOrdenarDecresente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOrdenarDecresente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrdenarDecresente.Location = new System.Drawing.Point(519, 153);
			this.btnOrdenarDecresente.Name = "btnOrdenarDecresente";
			this.btnOrdenarDecresente.Size = new System.Drawing.Size(257, 88);
			this.btnOrdenarDecresente.TabIndex = 6;
			this.btnOrdenarDecresente.Text = "Ordernar Descresente ";
			this.btnOrdenarDecresente.UseVisualStyleBackColor = false;
			this.btnOrdenarDecresente.Click += new System.EventHandler(this.BtnOrdenarDecresenteClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.Lime;
			this.lblResultado.Location = new System.Drawing.Point(166, 304);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(436, 110);
			this.lblResultado.TabIndex = 7;
			this.lblResultado.Text = "Ordenar Decresente ";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(819, 462);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnOrdenarDecresente);
			this.Controls.Add(this.txtNumero3);
			this.Controls.Add(this.lblNumero3);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.lblNumero2);
			this.Controls.Add(this.txtNumero1);
			this.Controls.Add(this.lblNumero1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "aitvidade 9";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
