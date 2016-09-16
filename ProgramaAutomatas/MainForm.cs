/*
 * Created by SharpDevelop.
 * User: JoGarWeb
 * Date: 01/09/2016
 * Time: 09:42 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramaAutomatas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
		void LenguajeToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmAutomata frmAutomata = new frmAutomata();
			frmAutomata.Show();
		}
		
		void AtributosToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show ("Algunos o todos los iconos podrían tener derechos reservados. Consultar: http://goo.gl/Yup5IH para más información.", "Algunas licencias...", 
			MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		
		void AcercaDelAutorToolStripMenuItemClick(object sender, EventArgs e)
		{
			Autor Autor = new Autor();
			Autor.Show();
		}
	}
}
