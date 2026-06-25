/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 10:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade11
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblValorA;
		private System.Windows.Forms.Label lblValorB;
		private System.Windows.Forms.Label lblValorC;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtValorA;
		private System.Windows.Forms.TextBox txtValorB;
		private System.Windows.Forms.TextBox txtValorC;
		private System.Windows.Forms.Button btnCalcularEquacao;
		
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
			this.lblValorA = new System.Windows.Forms.Label();
			this.lblValorB = new System.Windows.Forms.Label();
			this.lblValorC = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtValorA = new System.Windows.Forms.TextBox();
			this.txtValorB = new System.Windows.Forms.TextBox();
			this.txtValorC = new System.Windows.Forms.TextBox();
			this.btnCalcularEquacao = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblValorA
			// 
			this.lblValorA.AutoSize = true;
			this.lblValorA.Font = new System.Drawing.Font("Monospac821 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblValorA.Location = new System.Drawing.Point(90, 66);
			this.lblValorA.Name = "lblValorA";
			this.lblValorA.Size = new System.Drawing.Size(226, 39);
			this.lblValorA.TabIndex = 0;
			this.lblValorA.Text = "Valor de A:";
			// 
			// lblValorB
			// 
			this.lblValorB.AutoSize = true;
			this.lblValorB.Font = new System.Drawing.Font("Monospac821 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblValorB.Location = new System.Drawing.Point(90, 134);
			this.lblValorB.Name = "lblValorB";
			this.lblValorB.Size = new System.Drawing.Size(226, 39);
			this.lblValorB.TabIndex = 1;
			this.lblValorB.Text = "Valor de B:";
			// 
			// lblValorC
			// 
			this.lblValorC.AutoSize = true;
			this.lblValorC.Font = new System.Drawing.Font("Monospac821 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblValorC.Location = new System.Drawing.Point(90, 211);
			this.lblValorC.Name = "lblValorC";
			this.lblValorC.Size = new System.Drawing.Size(226, 39);
			this.lblValorC.TabIndex = 2;
			this.lblValorC.Text = "Valor de C:";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Monospac821 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.lblResultado.Location = new System.Drawing.Point(12, 373);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(188, 39);
			this.lblResultado.TabIndex = 3;
			this.lblResultado.Text = "Resultado";
			// 
			// txtValorA
			// 
			this.txtValorA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.txtValorA.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValorA.ForeColor = System.Drawing.Color.Red;
			this.txtValorA.Location = new System.Drawing.Point(337, 72);
			this.txtValorA.Name = "txtValorA";
			this.txtValorA.Size = new System.Drawing.Size(100, 34);
			this.txtValorA.TabIndex = 4;
			// 
			// txtValorB
			// 
			this.txtValorB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.txtValorB.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValorB.ForeColor = System.Drawing.Color.Red;
			this.txtValorB.Location = new System.Drawing.Point(337, 139);
			this.txtValorB.Name = "txtValorB";
			this.txtValorB.Size = new System.Drawing.Size(100, 34);
			this.txtValorB.TabIndex = 5;
			// 
			// txtValorC
			// 
			this.txtValorC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.txtValorC.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValorC.ForeColor = System.Drawing.Color.Red;
			this.txtValorC.Location = new System.Drawing.Point(337, 216);
			this.txtValorC.Name = "txtValorC";
			this.txtValorC.Size = new System.Drawing.Size(100, 34);
			this.txtValorC.TabIndex = 6;
			// 
			// btnCalcularEquacao
			// 
			this.btnCalcularEquacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnCalcularEquacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCalcularEquacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcularEquacao.Location = new System.Drawing.Point(575, 114);
			this.btnCalcularEquacao.Name = "btnCalcularEquacao";
			this.btnCalcularEquacao.Size = new System.Drawing.Size(124, 73);
			this.btnCalcularEquacao.TabIndex = 7;
			this.btnCalcularEquacao.Text = "Calcular raízes";
			this.btnCalcularEquacao.UseVisualStyleBackColor = false;
			this.btnCalcularEquacao.Click += new System.EventHandler(this.BtnCalcularEquacaoClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(781, 475);
			this.Controls.Add(this.btnCalcularEquacao);
			this.Controls.Add(this.txtValorC);
			this.Controls.Add(this.txtValorB);
			this.Controls.Add(this.txtValorA);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblValorC);
			this.Controls.Add(this.lblValorB);
			this.Controls.Add(this.lblValorA);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "atividade11";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
