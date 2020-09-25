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
	class Chofer: Persona
	{
		static int numLegajo=0;
		int numLeg=0;
		public Chofer(string nombre, string apellido, int dni)
		{
			this.Nombre=nombre;
			this.Apellido=apellido;
			this.Dni=dni;
			numLegajo=numLegajo+1;
			numLeg=numLegajo;
			
		}
		
		public int NumLegajo {
			get { return this.numLeg; }
		}
	}
}
