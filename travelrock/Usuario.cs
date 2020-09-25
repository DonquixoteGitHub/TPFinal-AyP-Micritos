
using System;

namespace travelrock
{

	class Usuario: Persona
	{
		string fechaNacimiento;
		static int numUsuario=0;
		int numU = 0;

		public Usuario(string nombre, string apellido, int dni, string fechaNacimiento)
		{
			this.Nombre=nombre;
			this.Apellido=apellido;
			this.Dni=dni;
			this.FechaNacimiento=fechaNacimiento;
			numUsuario=numUsuario+1;
			numU=numUsuario;
			
		}
		public int NumUsuario {
			get { return this.numU ; }
		}
		
		public string FechaNacimiento {
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}
		private int cantVoletosComprados;
		
		public int CantVoletosComprados {
			get { return cantVoletosComprados; }
			set { cantVoletosComprados = value; }
		}

	}
}
