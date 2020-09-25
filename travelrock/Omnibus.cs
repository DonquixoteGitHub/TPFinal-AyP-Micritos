
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace travelrock
{
	public class Omnibus
	{
		private string marca;
		
		public string Marca {
			get { return marca; }
			set { marca = value; }
		}
		private string tipo;
		
		public string Tipo {
			get { return tipo; }
			set { tipo = value; }
		}
		private int modelo;
		
		public int Modelo {
			get { return modelo; }
			set { modelo = value; }
		}
		private int capacidad;
		
		public int Capacidad {
			get { return capacidad; }
			set { capacidad = value; }
		}
		
		static int numUnidad=0;
		int numUni=0;

		public Omnibus(string marca, int modelo, int capacidad, string tipo)
		{
			this.Marca=marca;
			this.Tipo=tipo;
			this.Modelo=modelo;
			this.Capacidad=capacidad;
			numUnidad=numUnidad+1;
			numUni=numUnidad;
		}

		public int NumUnidad {
			get { return this.numUni; }
		}
	}
}
