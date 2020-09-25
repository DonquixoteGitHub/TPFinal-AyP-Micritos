using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace travelrock
{
	class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				int opcion;
			do{
				Console.Clear();
				pantallaMenu();
				Console.WriteLine("¿A que modulo desea ingresar?");
				Console.WriteLine("1) Armado de recorridos");
				Console.WriteLine("2) Gestion de choferes");
				Console.WriteLine("3) Ventas de pasajes");
				Console.WriteLine("4) Estadisticas");
				Console.WriteLine("5) Salir del sistema");
				
				opcion=int.Parse(Console.ReadLine());
				switch(opcion)
				{
					case(1):
						int opcionA;
						do{
							Console.Clear();
							pantallaMenu();
							Console.WriteLine("1) Alta de terminal");
							Console.WriteLine("2) Alta de omnibus");
							Console.WriteLine("3) Alta de recorrido");
							Console.WriteLine("4) Para volver al menu anterio");
							opcionA=int.Parse(Console.ReadLine());
							switch(opcionA)
							{
								case(1):
									Micritos.altaTerminal();
									Console.ReadKey(true);
									break;
								case(2):
									Micritos.AltaOmnibus();
									Console.ReadKey(true);
									break;
								case(3):
									Console.Clear();
									pantallaMenu();
									Micritos.AltaRecorrido();
									break;
							}
						}
						while(opcionA<4);
						break;
					case(2):
						int opcionB;
						do{
							Console.Clear();
							pantallaMenu();
							Console.WriteLine("1) Alta de chofer");
						    Console.WriteLine("2) Asignacion de recorrido");
						    Console.WriteLine("3) Volver al menu anterior");
						    opcionB=int.Parse(Console.ReadLine());
						    switch(opcionB)
						    {
						    	case(1):
						    		Micritos.AltaChofer();
						    		Console.ReadKey(true);
						    		break;
						    	case(2):
						    		Console.Clear();
						    		pantallaMenu();
						    		Micritos.AsignacionDeRecorrido();
						    		break;
						    }
							
						}
						while(opcionB<3);
						break;
					case(3):
						int opcionC;
						do{
							Console.Clear();
							pantallaMenu();
							Console.WriteLine("1) Alta de usuarios");
						    Console.WriteLine("2) Compra de pasajes");
						    Console.WriteLine("3) Volver");
						    opcionC=int.Parse(Console.ReadLine());
						    switch(opcionC)
						    {
						    	case(1):
						    		Micritos.AltaDeUsuario();
						    		break;
						    	case(2):
						    		Micritos.CompraDePasaje();
						    		break;
						    }
						}
						while(opcionC<3);
						break;
					case(4):
						int opcionD;
						do{
							Console.Clear();
							pantallaMenu();
							Console.WriteLine("1) Consoltar la cantidad total de pasajes vendidos");
						    Console.WriteLine("2) Consultar usuarios");
						    Console.WriteLine("3) Consultar terminal como partida");
						    Console.WriteLine("4) Consultar terminal como arribo");
						    Console.WriteLine("5) Volver");
						    opcionD=int.Parse(Console.ReadLine());
						    switch(opcionD)
						    {
						    	case(1):
						    		Micritos.PasajesVendidosEnTotal();
						    		break;
						    	case(2):
						    		Micritos.VentasPorUsuarios();
						    		break;
						    	case(3):
						    		Micritos.TerminalesComoPartida();
						    		break;
						    	case(4):
						    		Micritos.TerminalesComoArribo();
						    		break;
						    }
						}
						while(opcionD<5);
						break;
				}
				
			}
			while(opcion<5);
			Console.Clear();
			Console.Write("Precione una tecla para finalizar...");
			Console.ReadKey(true);
			}
			catch (FormatException)
				{
				Console.WriteLine("Ha ingresado un opcion erronea, por favor precione una tecla pra continuar...");
				Console.WriteLine("Por favor precione una tecla para continuar...");
				Console.ReadKey(true);
				}
		}
		public static void pantallaMenu()
		{
			Console.WriteLine("************************************************************************");
			Console.WriteLine("******************************* MICRITOS *******************************");
			Console.WriteLine("************************************************************************");
		}
	}
	class CaracterErroneoException : Exception
    {
    }
	class UsuarioExistenteException:Exception
	{
	}
	class UsuarioInexistenteException:Exception
	{
	}
	class TerminalExistenteException:Exception
	{
	}
	class OmnibusExistenteException:Exception
	{
	}
	class ChoferExistenteExeption:Exception
	{
	}
	class DatosExistentesException:Exception
	{
	}
	class DatosInexistentesException:Exception
	{
	}
}