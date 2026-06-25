/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 08:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade10
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnClassificarCategoria;
		private System.Windows.Forms.Label lblIdade;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtIdade;
		
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
			this.btnClassificarCategoria = new System.Windows.Forms.Button();
			this.lblIdade = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtIdade = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnClassificarCategoria
			// 
			this.btnClassificarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClassificarCategoria.Location = new System.Drawing.Point(639, 222);
			this.btnClassificarCategoria.Name = "btnClassificarCategoria";
			this.btnClassificarCategoria.Size = new System.Drawing.Size(119, 62);
			this.btnClassificarCategoria.TabIndex = 0;
			this.btnClassificarCategoria.Text = "Classificar categoria";
			this.btnClassificarCategoria.UseVisualStyleBackColor = true;
			this.btnClassificarCategoria.Click += new System.EventHandler(this.BtnClassificarCategoriaClick);
			// 
			// lblIdade
			// 
			this.lblIdade.AutoSize = true;
			this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdade.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblIdade.Location = new System.Drawing.Point(176, 79);
			this.lblIdade.Name = "lblIdade";
			this.lblIdade.Size = new System.Drawing.Size(250, 31);
			this.lblIdade.TabIndex = 1;
			this.lblIdade.Text = "Idade do nadador:";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblResultado.Location = new System.Drawing.Point(358, 343);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(141, 31);
			this.lblResultado.TabIndex = 2;
			this.lblResultado.Text = "Categoria";
			// 
			// txtIdade
			// 
			this.txtIdade.BackColor = System.Drawing.SystemColors.InfoText;
			this.txtIdade.ForeColor = System.Drawing.SystemColors.Info;
			this.txtIdade.Location = new System.Drawing.Point(432, 90);
			this.txtIdade.Name = "txtIdade";
			this.txtIdade.Size = new System.Drawing.Size(100, 20);
			this.txtIdade.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(875, 479);
			this.Controls.Add(this.txtIdade);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblIdade);
			this.Controls.Add(this.btnClassificarCategoria);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "atividade10";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
