/*
 * Created by SharpDevelop.
 * User: Cristian Relos
 * Date: 28/06/2017
 * Time: 17:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace travelrock
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		private string nombre;
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
		private string apellido;
		
		public string Apellido {
			get { return apellido; }
			set { apellido = value; }
		}
		private int dni;
		
		public int Dni {
			get { return dni; }
			set { dni = value; }
		}
	}
}
