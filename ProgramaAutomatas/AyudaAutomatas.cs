/*
 * Created by SharpDevelop.
 * User: JoGarWeb
 * Date: 02/09/2016
 * Time: 06:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramaAutomatas
{
	/// <summary>
	/// Description of AyudaAutomatas.
	/// </summary>
	public partial class frmAyudaAutomatas : Form
	{
		public frmAyudaAutomatas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnAceptarAyudaAutomatasClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MasAyuda MasAyuda = new MasAyuda();
			MasAyuda.Show();
		}
	}
}
