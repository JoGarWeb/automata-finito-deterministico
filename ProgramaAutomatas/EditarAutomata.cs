using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System;

namespace ProgramaAutomatas
{
	public partial class frmAutomata : Form
	{
		public frmAutomata()
		{
			InitializeComponent();
		}
		
		void EditarAutomataLoad(object sender, EventArgs e)
		{
			//tratando de abrir el automata.txt que esta en escritorio, si no esta
			//no hará nada, y continuará ejecutándose sin problema.
			try{
				string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				System.IO.Directory.CreateDirectory(mydocpath + @"\Automatas");
				txtTexto.Text=File.ReadAllText(mydocpath + @"\Automatas\" + @"\Estados.txt");
				txtLenguaje.Text=File.ReadAllText(mydocpath + @"\Automatas\" + @"\Lenguaje.txt");
				txtEstadosFinales.Text=File.ReadAllText(mydocpath + @"\Automatas\" + @"\Finales.txt");
				//lblLenguaje.Text=mydocpath;
			}catch(System.IO.FileNotFoundException){}
		}
		
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			//Guardando el automata en el escritorio.
			string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			File.WriteAllText(mydocpath + @"\Automatas\" + @"\Estados.txt", txtTexto.Text);
			File.WriteAllText(mydocpath + @"\Automatas\" + @"\Lenguaje.txt",txtLenguaje.Text);
			File.WriteAllText(mydocpath + @"\Automatas\" + @"\Finales.txt", txtEstadosFinales.Text);
			
			//Cerrando la ventana
			this.Close();
		}
		
		
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Ejemplo1ToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.txtTexto.Text="$1,0 $2,1 $3,2 $1,3";
			this.txtEstadosFinales.Text="3";
			this.txtLenguaje.Text="10";
		}
		
		void Ejemplo2ToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.txtTexto.Text="$1,0 $2,0 $2,2";
			this.txtEstadosFinales.Text="0,1";
			this.txtLenguaje.Text="01";
		}
	}
}
