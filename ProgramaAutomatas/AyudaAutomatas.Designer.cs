/*
 * Created by SharpDevelop.
 * User: JoGarWeb
 * Date: 02/09/2016
 * Time: 06:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProgramaAutomatas
{
	partial class frmAyudaAutomatas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyudaAutomatas));
			this.label1 = new System.Windows.Forms.Label();
			this.btnAceptarAyudaAutomatas = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(449, 240);
			this.label1.TabIndex = 0;
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// btnAceptarAyudaAutomatas
			// 
			this.btnAceptarAyudaAutomatas.Location = new System.Drawing.Point(14, 275);
			this.btnAceptarAyudaAutomatas.Name = "btnAceptarAyudaAutomatas";
			this.btnAceptarAyudaAutomatas.Size = new System.Drawing.Size(447, 23);
			this.btnAceptarAyudaAutomatas.TabIndex = 1;
			this.btnAceptarAyudaAutomatas.Text = "Aceptar";
			this.btnAceptarAyudaAutomatas.UseVisualStyleBackColor = true;
			this.btnAceptarAyudaAutomatas.Click += new System.EventHandler(this.BtnAceptarAyudaAutomatasClick);
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(14, 249);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(447, 23);
			this.linkLabel1.TabIndex = 2;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "¿Cómo el lenguaje se representa en la tabla?";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// frmAyudaAutomatas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 310);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.btnAceptarAyudaAutomatas);
			this.Controls.Add(this.label1);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAyudaAutomatas";
			this.Text = "Ayuda Autómatas";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button btnAceptarAyudaAutomatas;
		private System.Windows.Forms.Label label1;
	}
}
