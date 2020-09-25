using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace travelrock
{
	public class Micritos
	{
		static ArrayList Dias=new ArrayList(new string[]{"lunes","martes","miercoles","jueves","viermes"});
		static ArrayList Terminales=new ArrayList();
		static ArrayList Micros=new ArrayList();
		static ArrayList Recorridos=new ArrayList();
		static ArrayList Choferes=new ArrayList();
		static ArrayList usuarios=new ArrayList();
		static ArrayList RecorridosAsignados=new ArrayList();
		static ArrayList PasajesVendidos=new ArrayList();
		static ArrayList TerminalesDeArribo=new ArrayList();
		static ArrayList TerminalesDePartida=new ArrayList();
		static int venta=0;
		public static void altaTerminal()//funcion para dar de alta a una nueva terminal
		{
			try
			{
				Console.WriteLine("Ingrese los siguientes datos de la terminal");
				Terminal terminal=new Terminal();
				Console.Write("Ciudad: ");
				terminal.Ciudad=Console.ReadLine();
				Console.Write("Nombre: ");
				terminal.NomTerminal=Console.ReadLine();
				terminal.CantVoletosPartida=0;
				terminal.CantVoletosArribo=0;
				
				if(terminal.Ciudad=="" | terminal.NomTerminal=="") // contro que no se ingrese datos vacios
				{
					throw new CaracterErroneoException();
				}
				
				bool existe=false;
				foreach(Terminal a in Terminales)//comprueba si las terminales son iguales 
				{
					if(a.Ciudad==terminal.Ciudad)
					{
						throw new TerminalExistenteException();
						
					}
				}
				
				if(existe==false){//si los datos se ingresaron bien la terminal se da alta
					Terminales.Add(terminal);
					Console.WriteLine("La terminal a sido dada de alta correctamente");
					Console.WriteLine("Por favor precione una tecla para continuar...");
				}
			}
			catch (CaracterErroneoException)
			{
				Console.WriteLine("A ingresado un caracter erroneo");
				Console.WriteLine("Por favor precione una tecla para intentarlo de nuevo...");
			}
			catch (TerminalExistenteException)
			{
				Console.WriteLine("La terminal ya exite en el registro");
				Console.WriteLine("por favor precione una tecla para intentarlo de nuevo...");
			}
			catch 
			{
				Console.WriteLine("Ha ocurrido un error inesperado, por favor precione una tecla para continuar...");
			}
		}
		public static void AltaOmnibus()//funcion para dar de alta un omnibus
		{
			try
			{
				Console.WriteLine("Ingrese los datos del omnibus");
				Console.Write("Marca: ");
				string marca=Console.ReadLine();
				Console.Write("Modelo: ");
				int modelo=int.Parse(Console.ReadLine());
				Console.Write("Capacidad: ");
				int capacidad=int.Parse(Console.ReadLine());
				Console.Write("Tipo: ");
			    string tipo=Console.ReadLine();
			    if((marca==""|modelo<=0|capacidad<=20|tipo!="basico")&(tipo!="semi-cama")&(tipo!="coche-cama")&(tipo!="suite"))//comprueba que los datos no hayas sido ingresados de manera erronea
				{
					throw new CaracterErroneoException();
				}
			    else
			    	Micros.Add(new Omnibus(marca,modelo,capacidad,tipo));
			    Console.Write("El omnibus a sido dado de alta correctamente");
			    foreach(Omnibus a in Micros)
			    {
			    	if(a.Modelo==modelo)
			    	{
			    		Console.WriteLine(", A la unidad se le asigno el numero "+a.NumUnidad);
			    	}
			    }
			    Console.WriteLine("Por favor precione una tecla para continuar...");
			}
			catch (CaracterErroneoException)
			{
				Console.WriteLine("A ingresado un caracter erroneo");
				Console.WriteLine("Por favor precione una tecla para intentarlo de nuevo...");
			}
			catch 
			{
				Console.WriteLine("Ha ocurrido un error inesperado, por favor precione una tecla para continuar...");
			}
		}

		public static void AltaRecorrido()//funcion para dar de alta un recorrrido
		{
			try
			{
				ArrayList Recorrido=new ArrayList();
				
				int selec;
				do{//bucle para agregar terminales a un recorrido // se ingresa 0 para salir del bucle
					Console.Clear();
					int num=1;
					Console.WriteLine("Por favor selecione una termianal para agregarla al recorrido o 0 para finalizar");
				foreach(Terminal a in Terminales)//busca los objetos (Terminal) dentro del array terminales y los imprime
				{
					Console.WriteLine((num++)+")"+a.Ciudad);
				}
				Console.WriteLine("");
				Console.WriteLine("Lista de recorrido:");
				foreach(Terminal a in Recorrido)//busca los objetos que ya agregamos al array recorrido y imprime las ciudades
					{
						Console.WriteLine(a.Ciudad);
					}
					selec=int.Parse(Console.ReadLine());
					if((selec>Terminales.Count)&(selec<Terminales.Count))//verifica que se ingrese un numero que este dentro del rango de la cantidad de terminales en el array
				{
					throw new CaracterErroneoException();
				}
					if((selec>0)&(selec<=Terminales.Count))//si se ingreso bien el int se agrega la ciudad al recorrido
				{
					Recorrido.Add(Terminales[selec-1]);
				}
					if(selec==0){
					Console.WriteLine("El recorrido a sido dado de alta correctamente");
					Console.ReadKey();
					}
				}
				while(selec!=0);
				Recorridos.Add(Recorrido);//al salir del modulo el recorrido creado se agrega los recorridos
				
			}
			catch (CaracterErroneoException)
			{
				Console.WriteLine("A ingresado un caracter erroneo");
				Console.WriteLine("Por favor precione una tecla para intentarlo de nuevo...");
			}
			catch
			{
				Console.WriteLine("Ha ocurrido un error inesperado, por favor ingrese una tecla para finalizar...");
			}
		}
		
		public static void AltaChofer()//funcion para dar de alta un chofer
		{
			try
			{
				Console.WriteLine("Ingrese los iguientes datos del chofer");
				Console.Write("nombre: ");
				string Nombre=Console.ReadLine();
				Console.Write("apellido: ");
				string Apellido=Console.ReadLine();
				Console.Write("dni: ");
				int Dni=int.Parse(Console.ReadLine());
				bool existe1=false;
				foreach(Chofer a in Choferes)//comprueba que el dni del chofer no se repita
				{
					if(a.Dni==Dni)
					{
						throw new ChoferExistenteExeption();
					}
				}
				if(existe1==false)//si no se repite el dni, el chofer es dado de alta
				{
					Choferes.Add(new Chofer(Nombre,Apellido,Dni));
					Console.WriteLine("El chofer a sido dado de alta correctamente");
					foreach(Chofer a in Choferes)//comprueba que dni que se agrego exista dentro del array choferes
					{
						if(a.Dni==Dni)
						{
							Console.WriteLine("Su numero de legajo es "+a.NumLegajo);// y muestra su numero de legajo
						}
					}
					Console.WriteLine("Por favor precione una tecla para continuar...");
				}
				
			}
			catch (ChoferExistenteExeption)
			{
				Console.WriteLine("El chofer ya existe en el registro");
				Console.WriteLine("Por favor precione una tecla para continuar...");
			}
			catch 
			{
				Console.WriteLine("Ha ocurrido un error inesperado, por favor precione una tecla para continuar...");
			}
		}
		public static void AsignacionDeRecorrido()//funcion para asignarle a un chofer, un omnibus, un recorrido "X" y un dia
		{
			ArrayList ChoferRecorrido=new ArrayList();
			try
			{
				int num=1;
				Console.WriteLine("Seleccione el chofer");
				Console.WriteLine("");
				foreach(Chofer a in Choferes)//busca el objeto chofer en el array choferes y muestra su nombre,apellido,numero de legajo
				{
					Console.WriteLine((num++)+")"+a.Nombre+" "+a.Apellido+"("+a.NumLegajo+")");//cada chofer tiene un numero en la lista que se imprime para saber como seleccionarlo
				}
				int selec=int.Parse(Console.ReadLine());//ingrese el numero del chofer seleccionado
				if((selec<Choferes.Count)&(selec>Choferes.Count))//verifica que se ingrese bien el int
				{
					throw new CaracterErroneoException();
				}
				else
				{
					Console.Clear();
					int num1=1;
					Console.WriteLine("Selecione el omnibus");
					foreach(Omnibus a in Micros)//busca los objetos omnibus
					{
						Console.WriteLine((num1++)+")"+" "+"("+a.Marca+" "+a.Modelo+" "+a.Tipo+" ("+a.Capacidad+")");//muestra sus datos en una lista enumerada
					}
					int selecA=int.Parse(Console.ReadLine());//se selecciona el numero del omnibus 
					if(selecA>0 | selecA<=Micros.Count)
					{
						Console.Clear();
					    int num2=1;
					Console.WriteLine("Seleccione un recorrido");
					foreach(ArrayList a in Recorridos)//muestra todos los recorridos
					{
						Console.WriteLine();//para q los recorridos se impriman uno abajo del otro
						Console.Write((num2++)+")");//para imprimir un numero de seleccion en los recorridos
						foreach(Terminal b in a)//busca los objetos terminal en el array recorrido
						{
							Console.Write("-"+b.Ciudad);
						}
					}
					Console.WriteLine("");
					int num3=1;
					int selecB=int.Parse(Console.ReadLine());//se selecciona el recorrido
					if(selecB>0|selecB<=Recorridos.Count)
					{
						Console.Clear();
						Console.WriteLine("Seleccione un dia");
						foreach(string a in Dias)//se imprime los dias
						{
							Console.WriteLine((num3++)+") "+a);
						}
						int selecC=int.Parse(Console.ReadLine());//se selecciona el dia 
						if(selecC>0 | selecC<=Dias.Count)
						{
							bool existe=false;
							foreach(ArrayList a in RecorridosAsignados)//foreach anidado para verificar que el chofer no tenga dos recorridos un mismo dia
							{
								if((Micros[selecA-1]==a[1])&(Dias[selecC-1]==a[3]))
								{
									throw new DatosExistentesException();
								}
							}
							if(existe==false)
							{
								ChoferRecorrido.Add(Recorridos[(selecB-1)]);
								ChoferRecorrido.Add(Micros[(selecA-1)]);
								ChoferRecorrido.Add(Choferes[(selec-1)]);
								ChoferRecorrido.Add(Dias[(selecC-1)]);
								RecorridosAsignados.Add(ChoferRecorrido);
								Console.WriteLine("La asignacion de recorrido fue dada de alta correctamente");
								Console.WriteLine("Por favor precione una tecla para continuar");
								Console.ReadKey(true);
							}
							
						}
					}
				}
				}
			}
			
			catch (DatosExistentesException)
			{
				Console.WriteLine("El omnibus seleccionado ya tiene un recorrido asignado ese dia, por favor precione una tecla pra continuar...");
				Console.ReadKey();
			}
			catch (CaracterErroneoException)
			{
				Console.WriteLine("Ha ingresado un opcion erronea, por favor precione una tecla pra continuar...");
				Console.ReadKey();
			}
		}
		
		public static void AltaDeUsuario()
		{
			try
			{
				Console.WriteLine("Ingrese los datos del usuario");
				Console.Write("Nombre: ");
				string Nombre=Console.ReadLine();
				Console.Write("Apellido: ");
				string Apellido=Console.ReadLine();
				Console.Write("DNI: ");
				int Dni=int.Parse(Console.ReadLine());
				Console.Write("Fecha de nacimiento: ");
				string FechaNacimiento=Console.ReadLine();
				bool existe=false;
				foreach(Usuario a in usuarios)
				{
					if(a.Dni==Dni)
					{
						throw new UsuarioExistenteException();
					}
				}
				if(existe==false)
				{
					usuarios.Add(new Usuario(Nombre,Apellido,Dni,FechaNacimiento));
					Console.WriteLine("El usuario a sido dado de alta correctamente");
					foreach(Usuario a in usuarios)
					{
						if(a.Dni==Dni)
						{
							Console.WriteLine("Su numero de usuario es "+a.NumUsuario);
						}
					}
					Console.WriteLine("Por favor precione una tecla para continuar...");
					Console.ReadKey();
				}
			}
			catch (UsuarioExistenteException)
			{
				Console.WriteLine("el usuario ya existe, por favor precione una tecla pra continuar...");
				Console.ReadKey();
			}
			catch
			{
				Console.WriteLine("Ha ocurrido un error inesperado, por favor precione una tecla para continuar....");
				Console.ReadKey();
			}
		}
		
		public static void CompraDePasaje()
		{
			ArrayList UsuarioPasaje=new ArrayList();
			try
			{
				Console.WriteLine("ingrese el numero del usuario");
				int numusuario=int.Parse(Console.ReadLine());
				Console.WriteLine("ingrese el DNI del usuario");
				int dni=int.Parse(Console.ReadLine());
				bool existe=true;
				foreach(Usuario a in usuarios)
				{
					if((numusuario!=a.NumUsuario)&(dni!=a.Dni))
					{
						throw new UsuarioInexistenteException();
					}
				}
				if(existe==true)
				{
					foreach(Usuario a in usuarios)
					{
						if((numusuario==a.NumUsuario)&(dni==a.Dni))
						{
							UsuarioPasaje.Add(a);
						}
					}
					int num=1;
					Console.WriteLine("Seleccione la terminal de partida");
					foreach(Terminal a in Terminales)
					{
						Console.WriteLine((num++)+") "+a.Ciudad);
					}
					int selecA=int.Parse(Console.ReadLine());
					if((selecA>0)&(selecA<=Terminales.Count))
					{
						int numA=1;
						Console.WriteLine("Seleccione la terminal de arribo");
						foreach(Terminal a in Terminales)
						{
							Console.WriteLine((numA++)+") "+a.Ciudad);
						}
						int selecB=int.Parse(Console.ReadLine());
						if((selecB>0)&(selecB<=Terminales.Count))
						{
							int numa=1;
							int i=0;
							foreach(ArrayList a in RecorridosAsignados)
							{
									ArrayList lista=(ArrayList)a[0];
									foreach(Terminal b in lista)
									{
										if(Terminales[selecA-1]==b)
										{
											i++;
											for(int h=i;h<=lista.Count;h++)
											{
												if(Terminales[selecB-1]==lista[h])
												{
													Console.WriteLine("Seleccione el itinerario");
													foreach(Terminal k in Terminales)
													{
														if(Terminales[selecA-1]==k)
														{
															Console.Write((numa++)+") Saliendo de "+k.Ciudad);
														}
														if(Terminales[selecB-1]==k)
														{
															Omnibus omni=(Omnibus)a[1];
															Console.WriteLine(" Y llegando a "+k.Ciudad+"("+(h-i)+" paradas intermedias, "+a[3]+", "+omni.Tipo+")");
														}
													}
													break;
												}
											}
										}
										
									}
							}
							int selecX=int.Parse(Console.ReadLine());
							if((selecX>0)&&(selecX<=RecorridosAsignados.Count))
							{
								
								UsuarioPasaje.Add(RecorridosAsignados[selecX-1]);
								Console.WriteLine("¿cuantos pasajes desea comprar?");
								int selecD=int.Parse(Console.ReadLine());
								UsuarioPasaje.Add(selecD);
								bool existeA=false;
								
								foreach(Terminal a in Terminales)
								{
									if(a==Terminales[selecA-1])
									{
										a.CantVoletosPartida+=selecD;
									}
									if(a==Terminales[selecB-1])
									{
										a.CantVoletosArribo+=selecD;
									}
								}
								foreach(Usuario a in usuarios)
								{
									if(a.Dni==dni)
									{
										a.CantVoletosComprados+=selecD;
									}									
								}
								if(existeA==false)
								{
									PasajesVendidos.Add(UsuarioPasaje);
								
								Console.WriteLine("La venta se ha realizado con éxito.");
								Console.WriteLine("Precione un tecla para continuar...");
								Console.ReadKey(true);
								}
								venta+=selecD;
							}
							else
							{
								throw new CaracterErroneoException();
							}
						}
						
						else
						{
							throw new CaracterErroneoException();
						}
					}
					else
					{
						throw new CaracterErroneoException();
					}
				}
				
			}
			/*catch (ArgumentOutOfRangeException)
			{
				Console.WriteLine("No existe un recorrido para las terminales selecionadas");
				Console.WriteLine("Por favor precione un tecla para continuar...");
				Console.ReadKey();
			}*/
			catch (UsuarioInexistenteException)
			{
				Console.WriteLine("El usuario solicitado no existe en el sitemas");
				Console.WriteLine("Por favor precione una tecla para continuar...");
				Console.ReadKey();
			}
			catch (CaracterErroneoException)
			{
				Console.WriteLine("Ha ingresado un opcion erronea, por favor precione una tecla pra continuar...");
				Console.WriteLine("Por favor precione una tecla para continuar...");
				Console.ReadKey();
			}
		}
		
		public static void PasajesVendidosEnTotal()
		{
			Console.WriteLine("En total se han vendido "+venta+" pasajes");
			Console.WriteLine("Por favor precione una tecla para continuar...");
			Console.ReadKey(true);
		}
		public static void VentasPorUsuarios()
		{
			Console.WriteLine("Listado de ventas por usuario");
			foreach(Usuario a in usuarios)
			{
				Console.WriteLine(a.Nombre+" "+a.Apellido+"("+a.CantVoletosComprados+")");
			}
			Console.WriteLine("Por favor precione una tecla para continuar...");
			Console.ReadKey(true);
		}
		public static void TerminalesComoPartida()
		{
			Console.WriteLine("Lista de terminales como partida");
			foreach(Terminal a in Terminales)
			{
				Console.WriteLine(a.Ciudad+"("+a.CantVoletosPartida+")");
			}
			Console.WriteLine("Por favor precione una tecla para continuar...");
			Console.ReadKey(true);
			
		}
		public static void TerminalesComoArribo()
		{
			Console.WriteLine("Lista de terminales como arribo");
			foreach(Terminal a in Terminales)
			{
				Console.WriteLine(a.Ciudad+"("+a.CantVoletosArribo+")");
			}
			Console.WriteLine("Por favor precione una tecla para continuar...");
			Console.ReadKey(true);
			
		}
		public static void pantallaMenu()
		{
			Console.WriteLine("************************************************************************");
			Console.WriteLine("******************************* MICRITOS *******************************");
			Console.WriteLine("************************************************************************");
		}	
	}
}