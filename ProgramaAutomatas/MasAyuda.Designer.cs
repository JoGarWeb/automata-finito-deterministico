/*
 * Created by SharpDevelop.
 * User: JoGarWeb
 * Date: 10/09/2016
 * Time: 12:24 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProgramaAutomatas
{
	partial class MasAyuda
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasAyuda));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(366, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "\"La generación de una tabla está representada de la siguente manera:\"";
			//this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "En el lenguaje:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(199, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Como concepto:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(180, 194);
			this.label4.TabIndex = 3;
			this.label4.Text = "Si se tiene:\r\n\r\nElementos del lenguaje:\r\n0123\r\n\r\nEstados del autómata:\r\n$1,51,1,9" +
			"\r\n$2,9,5,63\r\n$111,96,96,5\r\n\r\nEstados Finales:\r\n1,9,20";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(199, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(180, 151);
			this.label5.TabIndex = 4;
			this.label5.Text = " #  |  0   |  1  | 2   | 3   |\r\n\r\nq0 |  1   | 51 | 1   | 9   |\r\n\r\nq2 |  2   | 9  " +
			" | 5   |63  |\r\n\r\nq3 |111 | 96 | 96 |5    |\r\n\r\n\r\nEstados finales: {1,9,20}";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(199, 226);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(179, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "&Aceptar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MasAyuda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MasAyuda";
			this.Text = "¿Cómo se prepresenta una tabla?";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		void Button1Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
