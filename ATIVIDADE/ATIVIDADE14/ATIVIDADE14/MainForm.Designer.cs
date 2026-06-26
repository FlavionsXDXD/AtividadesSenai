/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 08:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ATIVIDADE14
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblDesejoCarro;
		private System.Windows.Forms.Label lblDinheiro;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnVerificarCompra;
		private System.Windows.Forms.TextBox txtDesejoCarro;
		private System.Windows.Forms.TextBox txtDinheiro;
		
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
			this.lblDesejoCarro = new System.Windows.Forms.Label();
			this.lblDinheiro = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnVerificarCompra = new System.Windows.Forms.Button();
			this.txtDesejoCarro = new System.Windows.Forms.TextBox();
			this.txtDinheiro = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblDesejoCarro
			// 
			this.lblDesejoCarro.AutoSize = true;
			this.lblDesejoCarro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.lblDesejoCarro.Location = new System.Drawing.Point(12, 9);
			this.lblDesejoCarro.Name = "lblDesejoCarro";
			this.lblDesejoCarro.Size = new System.Drawing.Size(567, 31);
			this.lblDesejoCarro.TabIndex = 0;
			this.lblDesejoCarro.Text = "Deseja comprar um carro novo? (sim/não):";
			// 
			// lblDinheiro
			// 
			this.lblDinheiro.AutoSize = true;
			this.lblDinheiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.lblDinheiro.Location = new System.Drawing.Point(12, 103);
			this.lblDinheiro.Name = "lblDinheiro";
			this.lblDinheiro.Size = new System.Drawing.Size(472, 31);
			this.lblDinheiro.TabIndex = 1;
			this.lblDinheiro.Text = "Tem dinheiro suficiente? (sim/não):";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.lblResultado.Location = new System.Drawing.Point(12, 232);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(131, 29);
			this.lblResultado.TabIndex = 2;
			this.lblResultado.Text = "Resultado";
			// 
			// btnVerificarCompra
			// 
			this.btnVerificarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnVerificarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnVerificarCompra.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnVerificarCompra.Location = new System.Drawing.Point(17, 156);
			this.btnVerificarCompra.Name = "btnVerificarCompra";
			this.btnVerificarCompra.Size = new System.Drawing.Size(141, 73);
			this.btnVerificarCompra.TabIndex = 3;
			this.btnVerificarCompra.Text = "Verificar compra";
			this.btnVerificarCompra.UseVisualStyleBackColor = false;
			this.btnVerificarCompra.Click += new System.EventHandler(this.BtnVerificarCompraClick);
			// 
			// txtDesejoCarro
			// 
			this.txtDesejoCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtDesejoCarro.Location = new System.Drawing.Point(450, 43);
			this.txtDesejoCarro.Name = "txtDesejoCarro";
			this.txtDesejoCarro.Size = new System.Drawing.Size(100, 38);
			this.txtDesejoCarro.TabIndex = 4;
			// 
			// txtDinheiro
			// 
			this.txtDinheiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtDinheiro.Location = new System.Drawing.Point(450, 157);
			this.txtDinheiro.Name = "txtDinheiro";
			this.txtDinheiro.Size = new System.Drawing.Size(100, 38);
			this.txtDinheiro.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(626, 332);
			this.Controls.Add(this.txtDinheiro);
			this.Controls.Add(this.txtDesejoCarro);
			this.Controls.Add(this.btnVerificarCompra);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblDinheiro);
			this.Controls.Add(this.lblDesejoCarro);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ATIVIDADE14";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
