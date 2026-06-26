/*
 * Created by SharpDevelop.
 * User: Flavio
 * Date: 26/06/2026
 * Time: 08:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_18
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblAcucar;
		private System.Windows.Forms.Label lblLeite;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtAcucar;
		private System.Windows.Forms.TextBox txtleite;
		
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
			this.lblAcucar = new System.Windows.Forms.Label();
			this.lblLeite = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txtAcucar = new System.Windows.Forms.TextBox();
			this.txtleite = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblAcucar
			// 
			this.lblAcucar.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAcucar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblAcucar.Location = new System.Drawing.Point(12, 21);
			this.lblAcucar.Name = "lblAcucar";
			this.lblAcucar.Size = new System.Drawing.Size(447, 114);
			this.lblAcucar.TabIndex = 0;
			this.lblAcucar.Text = "Deseja adicionar açúcar? (sim/não):";
			// 
			// lblLeite
			// 
			this.lblLeite.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLeite.ForeColor = System.Drawing.SystemColors.Control;
			this.lblLeite.Location = new System.Drawing.Point(12, 152);
			this.lblLeite.Name = "lblLeite";
			this.lblLeite.Size = new System.Drawing.Size(447, 114);
			this.lblLeite.TabIndex = 1;
			this.lblLeite.Text = "Deseja adicionar leite? (sim/não):";
			// 
			// lblResultado
			// 
			this.lblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblResultado.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.SystemColors.Info;
			this.lblResultado.Location = new System.Drawing.Point(34, 313);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(613, 94);
			this.lblResultado.TabIndex = 2;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(34, 252);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(137, 68);
			this.button1.TabIndex = 3;
			this.button1.Text = "Preparar café";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtAcucar
			// 
			this.txtAcucar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAcucar.Location = new System.Drawing.Point(486, 21);
			this.txtAcucar.Name = "txtAcucar";
			this.txtAcucar.Size = new System.Drawing.Size(100, 38);
			this.txtAcucar.TabIndex = 4;
			// 
			// txtleite
			// 
			this.txtleite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtleite.Location = new System.Drawing.Point(486, 152);
			this.txtleite.Name = "txtleite";
			this.txtleite.Size = new System.Drawing.Size(100, 38);
			this.txtleite.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(675, 437);
			this.Controls.Add(this.txtleite);
			this.Controls.Add(this.txtAcucar);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblLeite);
			this.Controls.Add(this.lblAcucar);
			this.Name = "MainForm";
			this.Text = "atividade 18";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
