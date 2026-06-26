/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 09:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ATIVIDADE_15
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblDiploma;
		private System.Windows.Forms.Label lblIdade;
		private System.Windows.Forms.Button btnVerificarVaga;
		private System.Windows.Forms.TextBox txtDiploma;
		private System.Windows.Forms.TextBox txtIdade;
		private System.Windows.Forms.Label LBLresultado;
		
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
			this.lblDiploma = new System.Windows.Forms.Label();
			this.lblIdade = new System.Windows.Forms.Label();
			this.btnVerificarVaga = new System.Windows.Forms.Button();
			this.txtDiploma = new System.Windows.Forms.TextBox();
			this.txtIdade = new System.Windows.Forms.TextBox();
			this.LBLresultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDiploma
			// 
			this.lblDiploma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDiploma.Location = new System.Drawing.Point(12, 20);
			this.lblDiploma.Name = "lblDiploma";
			this.lblDiploma.Size = new System.Drawing.Size(384, 76);
			this.lblDiploma.TabIndex = 0;
			this.lblDiploma.Text = "Possui diploma de ensino superior? (sim/não):";
			// 
			// lblIdade
			// 
			this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdade.Location = new System.Drawing.Point(12, 138);
			this.lblIdade.Name = "lblIdade";
			this.lblIdade.Size = new System.Drawing.Size(384, 76);
			this.lblIdade.TabIndex = 1;
			this.lblIdade.Text = "Idade:";
			// 
			// btnVerificarVaga
			// 
			this.btnVerificarVaga.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnVerificarVaga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnVerificarVaga.Location = new System.Drawing.Point(382, 268);
			this.btnVerificarVaga.Name = "btnVerificarVaga";
			this.btnVerificarVaga.Size = new System.Drawing.Size(170, 75);
			this.btnVerificarVaga.TabIndex = 2;
			this.btnVerificarVaga.Text = "Verificar qualificação";
			this.btnVerificarVaga.UseVisualStyleBackColor = false;
			this.btnVerificarVaga.Click += new System.EventHandler(this.BtnVerificarVagaClick);
			// 
			// txtDiploma
			// 
			this.txtDiploma.Location = new System.Drawing.Point(12, 87);
			this.txtDiploma.Name = "txtDiploma";
			this.txtDiploma.Size = new System.Drawing.Size(100, 35);
			this.txtDiploma.TabIndex = 3;
			// 
			// txtIdade
			// 
			this.txtIdade.Location = new System.Drawing.Point(12, 179);
			this.txtIdade.Name = "txtIdade";
			this.txtIdade.Size = new System.Drawing.Size(100, 35);
			this.txtIdade.TabIndex = 4;
			// 
			// LBLresultado
			// 
			this.LBLresultado.ForeColor = System.Drawing.SystemColors.Highlight;
			this.LBLresultado.Location = new System.Drawing.Point(31, 254);
			this.LBLresultado.Name = "LBLresultado";
			this.LBLresultado.Size = new System.Drawing.Size(333, 110);
			this.LBLresultado.TabIndex = 5;
			this.LBLresultado.Text = "Resultado";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(564, 373);
			this.Controls.Add(this.LBLresultado);
			this.Controls.Add(this.txtIdade);
			this.Controls.Add(this.txtDiploma);
			this.Controls.Add(this.btnVerificarVaga);
			this.Controls.Add(this.lblIdade);
			this.Controls.Add(this.lblDiploma);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ATIVIDADE 15";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
