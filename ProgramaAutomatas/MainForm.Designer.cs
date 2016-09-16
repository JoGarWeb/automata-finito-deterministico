using System.Linq.Expressions;
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
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnAnalizar = new System.Windows.Forms.Button();
			this.txtCadenaPrincipal = new System.Windows.Forms.TextBox();
			this.lblCadenaAnalizar = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.lenguajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.atributosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDelAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rchLog = new System.Windows.Forms.RichTextBox();
			this.lblRespuestaFinal = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAnalizar
			// 
			this.btnAnalizar.Location = new System.Drawing.Point(359, 31);
			this.btnAnalizar.Name = "btnAnalizar";
			this.btnAnalizar.Size = new System.Drawing.Size(75, 23);
			this.btnAnalizar.TabIndex = 2;
			this.btnAnalizar.Text = "&Analizar";
			this.btnAnalizar.UseVisualStyleBackColor = true;
			this.btnAnalizar.Click += new System.EventHandler(this.BtnAnalizarClick);
			// 
			// txtCadenaPrincipal
			// 
			this.txtCadenaPrincipal.Location = new System.Drawing.Point(119, 31);
			this.txtCadenaPrincipal.MaxLength = 100;
			this.txtCadenaPrincipal.Name = "txtCadenaPrincipal";
			this.txtCadenaPrincipal.Size = new System.Drawing.Size(233, 20);
			this.txtCadenaPrincipal.TabIndex = 1;
			// 
			// lblCadenaAnalizar
			// 
			this.lblCadenaAnalizar.Location = new System.Drawing.Point(12, 34);
			this.lblCadenaAnalizar.Name = "lblCadenaAnalizar";
			this.lblCadenaAnalizar.Size = new System.Drawing.Size(100, 23);
			this.lblCadenaAnalizar.TabIndex = 5;
			this.lblCadenaAnalizar.Text = "Cadena a Analizar:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.lenguajeToolStripMenuItem,
									this.acercaDeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(451, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "mnsPrincipal";
			// 
			// lenguajeToolStripMenuItem
			// 
			this.lenguajeToolStripMenuItem.Name = "lenguajeToolStripMenuItem";
			this.lenguajeToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
			this.lenguajeToolStripMenuItem.Text = "&Editar Autómata";
			this.lenguajeToolStripMenuItem.Click += new System.EventHandler(this.LenguajeToolStripMenuItemClick);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.atributosToolStripMenuItem,
									this.acercaDelAutorToolStripMenuItem});
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.acercaDeToolStripMenuItem.Text = "&Acerca de...";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItemClick);
			// 
			// atributosToolStripMenuItem
			// 
			this.atributosToolStripMenuItem.Name = "atributosToolStripMenuItem";
			this.atributosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.atributosToolStripMenuItem.Text = "A&tributos";
			this.atributosToolStripMenuItem.Click += new System.EventHandler(this.AtributosToolStripMenuItemClick);
			// 
			// acercaDelAutorToolStripMenuItem
			// 
			this.acercaDelAutorToolStripMenuItem.Name = "acercaDelAutorToolStripMenuItem";
			this.acercaDelAutorToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.acercaDelAutorToolStripMenuItem.Text = "A&cerca del autor";
			this.acercaDelAutorToolStripMenuItem.Click += new System.EventHandler(this.AcercaDelAutorToolStripMenuItemClick);
			// 
			// rchLog
			// 
			this.rchLog.EnableAutoDragDrop = true;
			this.rchLog.Location = new System.Drawing.Point(13, 61);
			this.rchLog.Name = "rchLog";
			this.rchLog.ReadOnly = true;
			this.rchLog.Size = new System.Drawing.Size(426, 188);
			this.rchLog.TabIndex = 8;
			this.rchLog.Text = "";
			// 
			// lblRespuestaFinal
			// 
			this.lblRespuestaFinal.Location = new System.Drawing.Point(13, 256);
			this.lblRespuestaFinal.Name = "lblRespuestaFinal";
			this.lblRespuestaFinal.Size = new System.Drawing.Size(426, 23);
			this.lblRespuestaFinal.TabIndex = 9;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 286);
			this.Controls.Add(this.lblRespuestaFinal);
			this.Controls.Add(this.rchLog);
			this.Controls.Add(this.btnAnalizar);
			this.Controls.Add(this.txtCadenaPrincipal);
			this.Controls.Add(this.lblCadenaAnalizar);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Programa de Autómatas";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem acercaDelAutorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem atributosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		
		private System.Windows.Forms.Label lblRespuestaFinal;
		private System.Windows.Forms.RichTextBox rchLog;
		private System.Windows.Forms.ToolStripMenuItem lenguajeToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label lblCadenaAnalizar;
		private System.Windows.Forms.TextBox txtCadenaPrincipal;
		private System.Windows.Forms.Button btnAnalizar;
		
		void BtnAnalizarClick(object sender, System.EventArgs e)
		{
			
			lblRespuestaFinal.Text = " ";
			this.txtCadenaPrincipal.Enabled=false;
			this.btnAnalizar.Enabled=false;			
			lblRespuestaFinal.ForeColor = System.Drawing.Color.Aqua;
			lblRespuestaFinal.Text = "Analizando...";
			
			string[,] tablaAutomata = verificarAutomata();
			
			//Verificando que no haya salido la cadena de error.
			if(tablaAutomata[0,0]=="Error"){
				this.rchLog.Text += DateTime.Now + "Ocurrió un error inesperado, revisa tu autómata y vuelve a intentarlo.\n";
				lblRespuestaFinal.ForeColor = System.Drawing.Color.Red;
				lblRespuestaFinal.Text = "Ocurrió un error inesperado, revisa tu autómata y vuelve a intentarlo.\n";
				this.txtCadenaPrincipal.Enabled=true;
				this.btnAnalizar.Enabled=true;
				return;
			}
			
			bool cadenaValida = verificandoCadenaLenguaje(tablaAutomata,txtCadenaPrincipal.Text);
			
			if(cadenaValida==true){
				lblRespuestaFinal.ForeColor = System.Drawing.Color.Green;
				lblRespuestaFinal.Text = "La cadena introducida es válida.";
			}else{
				lblRespuestaFinal.ForeColor = System.Drawing.Color.Red;
				lblRespuestaFinal.Text = "La cadena no es válida o ocurrió un error. (Verifique el log).";
			}
						
			this.txtCadenaPrincipal.Enabled=true;
			this.btnAnalizar.Enabled=true;
		}
		
		//verificando que el autómata introducido sea correcto
		public string[,] verificarAutomata(){
			try{
				//Abriendo y/o creando archivos en desktop\automatas\...
				string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				System.IO.Directory.CreateDirectory(mydocpath + @"\Automatas");
				string Lenguaje=File.ReadAllText(mydocpath + @"\Automatas\" + @"\Lenguaje.txt");
				string Estados=File.ReadAllText(mydocpath + @"\Automatas\" + @"\Estados.txt");
				Estados += " ";
				this.rchLog.Text+= DateTime.Now + " ¡Archivos de autómatas abiertos con éxito!\n";
				
				//transformando strings a cadenas
				char[] cadenaLenguaje = Lenguaje.ToCharArray();
				char[] cadenaEstados = Estados.ToCharArray();
				this.rchLog.Text+= DateTime.Now + " ¡Strings de autómatas convertidos a cadenas con éxito!\n";
				
				//ignorando espacios del alfabeto
				int i,tamannoLenguaje;
				for(i=0,tamannoLenguaje=-1;i<cadenaLenguaje.Length;i++){
					if(cadenaLenguaje[i]==' '){
						
					}else{
						tamannoLenguaje++;
					}
				}
				
				//calculando el tamaño de las cadenas
				//int tamannoLenguaje = cadenaLenguaje.Length-1;
				int tamannoEstados = cadenaEstados.Length-1;
				this.rchLog.Text+= DateTime.Now + " ¡Cálculos del tamaño de los autómatas calculados con éxito!\n";
				this.rchLog.Text+= DateTime.Now + "El autómata tiene " + (tamannoLenguaje+1) + " Símbolos \n";
				this.rchLog.Text+= DateTime.Now + "El autómata tiene " + (tamannoEstados+1) + " Símbolos en estados \n";
				
				//Otras variables
				int contadorParaRecorrerCadena=0;
				int estadosDelAutomata=0;
				string[,] cadenaError = new string[1,1];
				cadenaError[0,0]="Error";
				
				//Contando los estados que tiene el autómata
				for(contadorParaRecorrerCadena=0 ; contadorParaRecorrerCadena<=tamannoEstados ; contadorParaRecorrerCadena++){
					if(cadenaEstados[contadorParaRecorrerCadena]=='$')
						estadosDelAutomata++;
				}
				this.rchLog.Text+= DateTime.Now + " ¡Se han contado los estados que tiene el autómata!\n";
				this.rchLog.Text+= DateTime.Now + " El autómata tiene " + estadosDelAutomata + " estados\n";
				
				//creando el arreglo bidimensional
				string[,] tablaDelAutomata = new string[(estadosDelAutomata+1),(tamannoLenguaje+1)];
				this.rchLog.Text+= DateTime.Now + " ¡Se ha creado el arreglo del autómata!\n";
				this.rchLog.Text+= DateTime.Now + "El automata se ha creado con tamaño [" + (tamannoLenguaje+1) + "" +
					"][" + (estadosDelAutomata+1) + "]. \n";
				
				/////Generando el arrreglo bidimensional con datos
				this.rchLog.Text+= DateTime.Now + " ¡Iniciando la creación de datos del autómata!\n";
				//Primero en la posición 
				for(contadorParaRecorrerCadena=0,i=0; tamannoLenguaje>=contadorParaRecorrerCadena ; contadorParaRecorrerCadena++,i++){
					//Eliminando los espacios de la cadena para introducir solo los simbolos
					while(cadenaLenguaje[i]==' '){
						this.rchLog.Text+= DateTime.Now + " ¡Se ha ignorado un caracter de espacio de la cadena de lenguaje!\n";
						i++;
					}
					tablaDelAutomata[0,contadorParaRecorrerCadena]=cadenaLenguaje[i].ToString();
					this.rchLog.Text+= DateTime.Now + " Se han ingresado: de cadenaLenguaje [" + i + "]" + "" +
						"el símbolo '" + cadenaLenguaje[i] + "' a tablaDelAutomata[" + "" +
						"0," + contadorParaRecorrerCadena + "].\n";
				}
				
				this.rchLog.Text+= DateTime.Now + " ¡Se ha puesto el alfabeto en el arreglo bidimensional!\n";
				
				//return cadenaError;
				
				//Verificando que los estados tengan el mismo numero de elementos
				int espacios=0;
				int pivote=0;
				int[] cadenaTemporal=new int[(estadosDelAutomata+1)];
				//Llenando un arreglo con el número de comas del lenguaje
				//Esto para saber que todos los estados tienen el mismo numero de elementos válidos
				for(contadorParaRecorrerCadena=0 ; tamannoEstados>=contadorParaRecorrerCadena ; contadorParaRecorrerCadena++){
					if(cadenaEstados[contadorParaRecorrerCadena]=='$'){
						this.rchLog.Text+= DateTime.Now + " ¡Se Encontró un $! Se guardó el numero de espacios en un arreglo\n";
						cadenaTemporal[pivote]+=espacios;
						this.rchLog.Text+= DateTime.Now + "Se agregó: " + espacios + " a la cadena temporal\n";
						espacios=0;
						pivote++;
					}else if(cadenaEstados[contadorParaRecorrerCadena]==','){
						this.rchLog.Text+= DateTime.Now + " ¡Se Encontró una coma ','!\n";
						espacios++;
						this.rchLog.Text+= DateTime.Now + " Número de espacios: " + espacios + "\n";
					}else{
						this.rchLog.Text+= DateTime.Now + " ¡Se Encontró algo! No se hizo ninguna acción.\n";
					}
				}
				this.rchLog.Text+= DateTime.Now + " ¡Se Encontró el final de la cadena!\n";
				cadenaTemporal[pivote]+=espacios;
				this.rchLog.Text+= DateTime.Now + "Se agregó: " + espacios + " a la cadena temporal\n";
				
				//Imprimiendo la candena resultante anterior en el log
				this.rchLog.Text+= DateTime.Now + " La cadena resultante con la cantidad de espacios es: ";
				for(contadorParaRecorrerCadena=0;contadorParaRecorrerCadena<(estadosDelAutomata+1);contadorParaRecorrerCadena++){
					this.rchLog.Text+= cadenaTemporal[contadorParaRecorrerCadena];
				}
				this.rchLog.Text+= " \n";
								
				//comprobando que los elementos 
				int tamannoCadenaTemporal=cadenaTemporal.Length-1;
				for(contadorParaRecorrerCadena=1 ; tamannoCadenaTemporal>0 ; tamannoCadenaTemporal--,contadorParaRecorrerCadena++){
					if(cadenaTemporal[contadorParaRecorrerCadena]==cadenaTemporal[1]){
						this.rchLog.Text+= DateTime.Now + " ¡Caracteres correctos!\n";
					}else{
						this.rchLog.Text+= DateTime.Now + " ¡Error! Algún Estado tiene elementos de más o de menos, verifique el autómata" +
							"desde la pestaña 'Autómata' en el menú de arriba.\n";
						return cadenaError;
					}
				}
				
				//Metiendo los caracteres al arreglo bidimensional
				int recorridoIzquierdo,recorridoDerecho,contadorParaRecorrerOtraCadena=1;
				string cadenaTemporalDeNumeros="";
				pivote=0;
				contadorParaRecorrerCadena=1;
				
				for(recorridoIzquierdo=1;recorridoIzquierdo<(estadosDelAutomata+1);recorridoIzquierdo++){
					for(recorridoDerecho=0;recorridoDerecho<(tamannoLenguaje+1);recorridoDerecho++){
						this.rchLog.Text+= DateTime.Now + " Me encuentro en: tablaDelAutomata[" + recorridoIzquierdo + "," + recorridoDerecho + "]\n";
						cadenaTemporalDeNumeros="";
						contadorParaRecorrerOtraCadena=0;
						try{
							do{
								if(cadenaEstados[contadorParaRecorrerCadena]=='$'){
									this.rchLog.Text+= DateTime.Now + " ¡Se encontró un $! No hubo cambios\n";
									pivote=0;
								}else if(cadenaEstados[contadorParaRecorrerCadena]==' '){
									this.rchLog.Text+= DateTime.Now + " ¡Se encontró un ' '! No hubo cambios\n";
								pivote=1;
								}else if(cadenaEstados[contadorParaRecorrerCadena]==','){
									this.rchLog.Text+= DateTime.Now + " ¡Se encontró una ','! No hubo cambios\n";
									pivote=0;
								}else{
									cadenaTemporalDeNumeros+=Convert.ToString(cadenaEstados[contadorParaRecorrerCadena]);
									this.rchLog.Text+= DateTime.Now + " Se agregó a cadenaTemporalDeNumeros[" + contadorParaRecorrerOtraCadena + "" +
										"] el simbolo '" + Convert.ToString(cadenaEstados[contadorParaRecorrerCadena]) + "'" + "\n";
									//contadorParaRecorrerOtraCadena++;
									pivote=1;
								}
							
								if(contadorParaRecorrerCadena<=(tamannoEstados)){
									contadorParaRecorrerCadena++;
								}else{pivote=1;}
								
						}while(pivote==1&&contadorParaRecorrerCadena<=(tamannoEstados-1));
						}catch(System.IndexOutOfRangeException){
							this.rchLog.Text+= DateTime.Now + " ¡Error Desconocido! Envíando cadena de Error.\n";
							return cadenaError;
						}
						
						//agregando la cadena
						try{
							int verificar = Convert.ToInt32(cadenaTemporalDeNumeros);
							this.rchLog.Text+= DateTime.Now + " Cadena de números transforamadas con éxito.\n";
							if (verificar<-1){
								this.rchLog.Text += DateTime.Now + " ¡Error! No puede introducir un autómata con estados menores a '-1'. " +
									"Si quiere representar un loop, deberá ser representado con un '-1'." +
									"El autómata tiene estado '" + verificar + "' y no puede ser posible.\n";
								return cadenaError;
							}
						}catch(System.InvalidCastException){
							this.rchLog.Text+= DateTime.Now + " ¡Error! No se pudo transformar a entero. Revise el lenguaje.\n";
							return cadenaError;
						}catch(System.FormatException){
							this.rchLog.Text+= DateTime.Now + " ¡Error! No se pudo transformar a entero. Revise el lenguaje.\n";
							return cadenaError;
						}
						try{
							tablaDelAutomata[recorridoIzquierdo,recorridoDerecho]=Convert.ToString(cadenaTemporalDeNumeros);
							this.rchLog.Text+= DateTime.Now + " Se agregó: '" + Convert.ToString(cadenaTemporalDeNumeros) + "' a tablaDelAutomata[" + "" +
							recorridoIzquierdo + "," + recorridoDerecho + "]\n";
						}catch(System.IndexOutOfRangeException){
							this.rchLog.Text+= DateTime.Now + " ¡Error Desconocido!, envíando cadena de Error.\n";
							return cadenaError;
						}
					}
				}
				
				this.rchLog.Text+= DateTime.Now + " ¡Creación de tabla exitosa! Envíando tabla del autómata. \n";
				return tablaDelAutomata;
				
			}catch(System.IO.FileNotFoundException){
				this.rchLog.Text+= DateTime.Now + " ¡Archivos no encontrados! Verifique el autómata " +
					"desde la pestaña de 'Autómata'\n";
			}
			
			string[,] error = new string[1,1];
			error[0,0]="Error";
			this.rchLog.Text+= DateTime.Now + " ¡Error Desconocido! Envíando cadena de Error.\n";
			return error;
			
		}
		
		public bool verificandoCadenaLenguaje(string[,] tablaAutomatas,string stringAEvaluar){
			
			try{
				//Abriendo los archivos necesarios
				string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				System.IO.Directory.CreateDirectory(mydocpath + @"\Automatas");
				string Finales=File.ReadAllText(mydocpath + @"\Automatas\" + @"\Finales.txt");
				this.rchLog.Text += DateTime.Now + " Archivos abiertos con éxito.\n";
				
				//Convirtiendo el string a cadena
				char[] cadenaAEvaluar = stringAEvaluar.ToCharArray();
				char[] cadenaDeFinales = Finales.ToCharArray();
				this.rchLog.Text += DateTime.Now + " Strings transformadas a cadenas exitosamente. \n";
				
				//saber el tamanno de la matríz.
				int izquierdo = tablaAutomatas.GetLength(0);
				int derecho = tablaAutomatas.GetLength(1);
				this.rchLog.Text += DateTime.Now + " La matriz es de [" + izquierdo + "," + derecho + "]. \n";
				
				//Comprobando que la cadena contenga solo símbolos del lenguaje.
				int contadorParaRecorrerUnaCadena,contadorPivote;
				bool validacion;
				for(contadorParaRecorrerUnaCadena=0;contadorParaRecorrerUnaCadena<cadenaAEvaluar.Length-1;contadorParaRecorrerUnaCadena++){
					for(contadorPivote=0,validacion=false;contadorPivote<(derecho);contadorPivote++){
						if(cadenaAEvaluar[contadorParaRecorrerUnaCadena] == Convert.ToChar(tablaAutomatas[0,contadorPivote])){
							this.rchLog.Text += DateTime.Now + "La cadena: '" + cadenaAEvaluar[contadorParaRecorrerUnaCadena] + "" +
								"' es igual a '" + Convert.ToChar(tablaAutomatas[0,contadorPivote]) + "'\n";
							validacion=true;
						}else{
							if(validacion==false){
								this.rchLog.Text += DateTime.Now + "La cadena: '" + cadenaAEvaluar[contadorParaRecorrerUnaCadena] + "" +
									"' NO es igual a '" + Convert.ToChar(tablaAutomatas[0,contadorPivote]) + "'.\n";
								validacion=false;
							}else{
								this.rchLog.Text += DateTime.Now + "La cadena: '" + cadenaAEvaluar[contadorParaRecorrerUnaCadena] + "" +
									"' NO es igual a '" + Convert.ToChar(tablaAutomatas[0,contadorPivote]) + "' Pero ya fue validada" +
									" antes, y no abrá modificación.\n";
								validacion=true;
							}
						}
					}
					if(validacion==false){
						this.rchLog.Text += DateTime.Now + " Algún elemento de la cadena a comparar no es válida, " +
							"verifique el lenguaje y/o la cadena a evaluar.\n";
						return false;
					}
				}
				
				//saber cuantos espacios requiere el arreglo de estados finales.
				int numeroDeEstadosFinales;
				for(contadorParaRecorrerUnaCadena=0,numeroDeEstadosFinales=1;contadorParaRecorrerUnaCadena<(cadenaDeFinales.Length);contadorParaRecorrerUnaCadena++){
					if(cadenaDeFinales[contadorParaRecorrerUnaCadena]==',')
						numeroDeEstadosFinales++;
				}
				this.rchLog.Text += DateTime.Now + " Se han encontrado: '" + numeroDeEstadosFinales + "'Estados Finales." +
					" Creando Arreglo.\n";
				
				//creando el arreglo que contendrá a los estados finales
				string[] estadosFinales = new string[numeroDeEstadosFinales];
				string cadenaTemporalDeEstado="";
				this.rchLog.Text += DateTime.Now + " Se ha creado el arreglo de estados finales con éxito.\n";
				
				//Separando las ',' de la cadena de Estados Finales a un arreglo exclusivamente de estados finales
				this.rchLog.Text += DateTime.Now + " Empezando a crear el arreglo de strings de Estados Finales.\n";
				contadorParaRecorrerUnaCadena=0;
				int contadorParaRecorrerUnArreglo=0,banderaDeParo,evaluacionDeCadenaTemporal;
				for(;contadorParaRecorrerUnaCadena<(cadenaDeFinales.Length);contadorParaRecorrerUnArreglo++){
					//Recorriendo primero el string de estados finales, moviendo a una cadena temporal lo que se encuentre si
					//no hay una coma.
					cadenaTemporalDeEstado="";
					do{
						if(cadenaDeFinales[contadorParaRecorrerUnaCadena]==','){
							banderaDeParo=0;
							contadorParaRecorrerUnaCadena++;
							this.rchLog.Text += DateTime.Now + " Se ha encontrado una coma ',' No se realizó ninguna acción.\n";
						}else{
							cadenaTemporalDeEstado+=cadenaDeFinales[contadorParaRecorrerUnaCadena];
							banderaDeParo=1;
							this.rchLog.Text += DateTime.Now + " Se encontró: '" + cadenaDeFinales[contadorParaRecorrerUnaCadena] + "" +
								"' se agregó a un string temporar para poder evaluarla después. Continuando con la evaluación de la cadena\n";
							contadorParaRecorrerUnaCadena++;
						}
					}while(banderaDeParo!=0&&contadorParaRecorrerUnaCadena<(cadenaDeFinales.Length));
					
					//tratando de convertir la cadena temporal a numero, si sale bien continúa, si no regresa error
					try{
						//Convirtiendo cadena de estado a entero
						evaluacionDeCadenaTemporal=Convert.ToInt32(cadenaTemporalDeEstado);
						this.rchLog.Text += DateTime.Now + " Se ha transformado '" + evaluacionDeCadenaTemporal + "' con éxito.\n";
						//Pasando ese valor a el arreglo de strings
						estadosFinales[contadorParaRecorrerUnArreglo]=cadenaTemporalDeEstado;
						this.rchLog.Text += DateTime.Now + "Se ha pasado '" + cadenaTemporalDeEstado + "' a la cadena de estadoFinales[" +
							"" + contadorParaRecorrerUnArreglo + "] con éxito.\n";
					}catch(System.FormatException){
						this.rchLog.Text += DateTime.Now + " La cadena '" + cadenaTemporalDeEstado + "' no es un número válido." +
							" Revise el lenguaje del autómata. Solo debe contener números. Regresando error.\n";
						return false;
					}
					
				}
				
				this.rchLog.Text += DateTime.Now + " Se ha terminado el arreglo de strings de estados finales con éxito.\n";
				
				//Haciendo esto si se quiere evaluar la cadena vacía
				if(stringAEvaluar==""){
					for(contadorParaRecorrerUnaCadena=0;contadorParaRecorrerUnaCadena<estadosFinales.Length;contadorParaRecorrerUnaCadena++){
						if(estadosFinales[contadorParaRecorrerUnaCadena]=="0"){
							this.rchLog.Text += DateTime.Now + "Se ha evaluado la cadena con éxito, la cadena pertenece " +
							"al lenguaje, regresando respuesta positiva.\n";
							return true;
						}
					}
					
					this.rchLog.Text += DateTime.Now + "Se ha evaluado la cadena con éxito, la cadena NO pertenece " +
							"al lenguaje, regresando respuesta negativa.\n";
					return false;
				}
				
				
				//Recorriendo el arreglo bidimensional, meter valores en delta.
				string[] delta = new string[2];
				int estado=1;
				for(contadorParaRecorrerUnaCadena=0;contadorParaRecorrerUnaCadena<(cadenaAEvaluar.Length);contadorParaRecorrerUnaCadena++){
					this.rchLog.Text += DateTime.Now + " Evaluando el caracter '" + cadenaAEvaluar[contadorParaRecorrerUnaCadena] + "'.\n";
					//buscando caracter de la cadena a evaluar en arreglo bidimensional
					for(contadorParaRecorrerUnArreglo=0;contadorParaRecorrerUnArreglo<derecho;contadorParaRecorrerUnArreglo++){
						if(cadenaAEvaluar[contadorParaRecorrerUnaCadena].ToString()==tablaAutomatas[0,contadorParaRecorrerUnArreglo]){
							this.rchLog.Text += DateTime.Now + " Encontré que '" + cadenaAEvaluar[contadorParaRecorrerUnaCadena] + "" +
								"' es igual a '" + tablaAutomatas[0,contadorParaRecorrerUnArreglo] + "'.\n";
							delta[1]=tablaAutomatas[0,contadorParaRecorrerUnArreglo];
							this.rchLog.Text += DateTime.Now + " Se ha puesto el valor '" + delta[1] + "' en delta[1].\n";
							try{
								delta[0]=tablaAutomatas[estado,contadorParaRecorrerUnArreglo];
							}catch(System.IndexOutOfRangeException){
								this.rchLog.Text+= DateTime.Now + " ¡Error! No puede introducir un autómata con estados menores" +
									" a '-1'. si quiere representar un loop, deberá ser representado con un '-1'.\n";
								return false;
							}
						this.rchLog.Text += DateTime.Now + " He puesto el valor '" + delta[0] + "' en delta[0].\n";
						estado=(Convert.ToInt32(delta[0]))+1;
						this.rchLog.Text += DateTime.Now + " El nuevo delta es: delta['" + delta[0] + "" +
							"','" + delta[1] + "']. El nuevo estado es: '" + estado + "'.\n";
						
						}
						
					}
					//verificando que no se haya caído a un estado de error
					if(delta[0]=="-1"){
						this.rchLog.Text += DateTime.Now + " La cadena no es válida, ha introducido un " +
							"carácter de más a la cadena a analizar de lo que permite el lenguaje. " +
							"Revise su autómata introducido. Error: Delta[0]=-1.\n ";
						return false;
					}
				}
				
				//Verificando que la cadena es válida.
				for(contadorParaRecorrerUnaCadena=0;contadorParaRecorrerUnaCadena<estadosFinales.Length;contadorParaRecorrerUnaCadena++){
					if(estadosFinales[contadorParaRecorrerUnaCadena]==delta[0]){
						this.rchLog.Text += DateTime.Now + " Se ha evaluado la cadena con éxito, la cadena pertenece " +
							"al lenguaje, regresando respuesta positiva.\n";
						return true;
					}
				}
				
				this.rchLog.Text += DateTime.Now + " Se ha terminado de evaluar la cadena con éxito pero " +
					"el autómata regresó error, regresando respuesta negativa.\n";
				return false;
				
				
			}catch(System.IO.FileNotFoundException){
				this.rchLog.Text+= DateTime.Now + " ¡Archivos no encontrados! Verifique el autómata " +
					"desde la pestaña de 'Autómata'\n";
				return false;
			}
			//return true;
		}
		
		
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
	}
}
