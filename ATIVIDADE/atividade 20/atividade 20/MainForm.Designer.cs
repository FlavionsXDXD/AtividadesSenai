/*
 * Created by SharpDevelop.
 * User: Flavio
 * Date: 26/06/2026
 * Time: 09:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_20
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblRespostaCompra;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnConfirmarCompra;
		private System.Windows.Forms.TextBox txtRespostaCompra;
		
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
			this.lblRespostaCompra = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnConfirmarCompra = new System.Windows.Forms.Button();
			this.txtRespostaCompra = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblRespostaCompra
			// 
			this.lblRespostaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRespostaCompra.Location = new System.Drawing.Point(12, 9);
			this.lblRespostaCompra.Name = "lblRespostaCompra";
			this.lblRespostaCompra.Size = new System.Drawing.Size(346, 72);
			this.lblRespostaCompra.TabIndex = 0;
			this.lblRespostaCompra.Text = "Deseja comprar o produto? (sim/s/não):";
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.Red;
			this.lblResultado.Location = new System.Drawing.Point(68, 268);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(354, 166);
			this.lblResultado.TabIndex = 1;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnConfirmarCompra
			// 
			this.btnConfirmarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirmarCompra.Location = new System.Drawing.Point(332, 143);
			this.btnConfirmarCompra.Name = "btnConfirmarCompra";
			this.btnConfirmarCompra.Size = new System.Drawing.Size(143, 82);
			this.btnConfirmarCompra.TabIndex = 2;
			this.btnConfirmarCompra.Text = "Confirmar compra";
			this.btnConfirmarCompra.UseVisualStyleBackColor = true;
			this.btnConfirmarCompra.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtRespostaCompra
			// 
			this.txtRespostaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRespostaCompra.Location = new System.Drawing.Point(12, 95);
			this.txtRespostaCompra.Name = "txtRespostaCompra";
			this.txtRespostaCompra.Size = new System.Drawing.Size(100, 31);
			this.txtRespostaCompra.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(502, 443);
			this.Controls.Add(this.txtRespostaCompra);
			this.Controls.Add(this.btnConfirmarCompra);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblRespostaCompra);
			this.Name = "MainForm";
			this.Text = "atividade 20";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
