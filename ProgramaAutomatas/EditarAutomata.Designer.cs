/*
 * Created by SharpDevelop.
 * User: JoGarWeb
 * Date: 01/09/2016
 * Time: 09:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProgramaAutomatas
{
	partial class frmAutomata
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutomata));
			this.txtTexto = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejemplo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejemplo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.lblLenguaje = new System.Windows.Forms.Label();
			this.txtLenguaje = new System.Windows.Forms.TextBox();
			this.lblEstados = new System.Windows.Forms.Label();
			this.txtEstadosFinales = new System.Windows.Forms.TextBox();
			this.lblEstadosFinales = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtTexto
			// 
			this.txtTexto.Location = new System.Drawing.Point(13, 107);
			this.txtTexto.Multiline = true;
			this.txtTexto.Name = "txtTexto";
			this.txtTexto.Size = new System.Drawing.Size(259, 141);
			this.txtTexto.TabIndex = 2;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(116, 306);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "A&ceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ayudaToolStripMenuItem,
									this.ayudaToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ejemplo1ToolStripMenuItem,
									this.ejemplo2ToolStripMenuItem});
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.ayudaToolStripMenuItem.Text = "&Ejemplo";
			this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.AyudaToolStripMenuItemClick);
			// 
			// ejemplo1ToolStripMenuItem
			// 
			this.ejemplo1ToolStripMenuItem.Name = "ejemplo1ToolStripMenuItem";
			this.ejemplo1ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.ejemplo1ToolStripMenuItem.Text = "Ejemplo &1";
			this.ejemplo1ToolStripMenuItem.Click += new System.EventHandler(this.Ejemplo1ToolStripMenuItemClick);
			// 
			// ejemplo2ToolStripMenuItem
			// 
			this.ejemplo2ToolStripMenuItem.Name = "ejemplo2ToolStripMenuItem";
			this.ejemplo2ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.ejemplo2ToolStripMenuItem.Text = "Ejemplo &2";
			this.ejemplo2ToolStripMenuItem.Click += new System.EventHandler(this.Ejemplo2ToolStripMenuItemClick);
			// 
			// ayudaToolStripMenuItem1
			// 
			this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
			this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem1.Text = "&Ayuda";
			this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.AyudaToolStripMenuItem1Click);
			// 
			// lblLenguaje
			// 
			this.lblLenguaje.Location = new System.Drawing.Point(13, 28);
			this.lblLenguaje.Name = "lblLenguaje";
			this.lblLenguaje.Size = new System.Drawing.Size(259, 23);
			this.lblLenguaje.TabIndex = 14;
			this.lblLenguaje.Text = "Escribe los elementos del alfabeto:";
			// 
			// txtLenguaje
			// 
			this.txtLenguaje.Location = new System.Drawing.Point(13, 54);
			this.txtLenguaje.Name = "txtLenguaje";
			this.txtLenguaje.Size = new System.Drawing.Size(259, 20);
			this.txtLenguaje.TabIndex = 1;
			// 
			// lblEstados
			// 
			this.lblEstados.Location = new System.Drawing.Point(13, 81);
			this.lblEstados.Name = "lblEstados";
			this.lblEstados.Size = new System.Drawing.Size(259, 23);
			this.lblEstados.TabIndex = 16;
			this.lblEstados.Text = "Escribe los estados:";
			// 
			// txtEstadosFinales
			// 
			this.txtEstadosFinales.Location = new System.Drawing.Point(12, 280);
			this.txtEstadosFinales.Name = "txtEstadosFinales";
			this.txtEstadosFinales.Size = new System.Drawing.Size(259, 20);
			this.txtEstadosFinales.TabIndex = 3;
			// 
			// lblEstadosFinales
			// 
			this.lblEstadosFinales.Location = new System.Drawing.Point(13, 251);
			this.lblEstadosFinales.Name = "lblEstadosFinales";
			this.lblEstadosFinales.Size = new System.Drawing.Size(259, 23);
			this.lblEstadosFinales.TabIndex = 18;
			this.lblEstadosFinales.Text = "Escribe los estados finales aquí:";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(197, 306);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Ca&ncelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// frmAutomata
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 335);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.lblEstadosFinales);
			this.Controls.Add(this.txtEstadosFinales);
			this.Controls.Add(this.lblEstados);
			this.Controls.Add(this.txtLenguaje);
			this.Controls.Add(this.lblLenguaje);
			this.Controls.Add(this.txtTexto);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.menuStrip1);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAutomata";
			this.Text = "Editar Autómata";
			this.Load += new System.EventHandler(this.EditarAutomataLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem ejemplo2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejemplo1ToolStripMenuItem;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblEstadosFinales;
		private System.Windows.Forms.TextBox txtEstadosFinales;
		private System.Windows.Forms.Label lblEstados;
		private System.Windows.Forms.TextBox txtLenguaje;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblLenguaje;
		private System.Windows.Forms.TextBox txtTexto;
		
		void AyudaToolStripMenuItemClick(object sender, System.EventArgs e)
		{
		}
		
		void AyudaToolStripMenuItem1Click(object sender, System.EventArgs e)
		{
			frmAyudaAutomatas frmAyudaAutomatas = new frmAyudaAutomatas();
			frmAyudaAutomatas.Show();
		}
	}
}
