
using System;

namespace travelrock
{
	/// <summary>
	/// Description of Terminal.
	/// </summary>
	public class Terminal
	{
		private string nomTerminal;
		
		public string NomTerminal {
			get { return nomTerminal; }
			set { nomTerminal = value; }
		}
		private string ciudad;
		
		public string Ciudad {
			get { return ciudad; }
			set { ciudad = value; }
		}
		private int cantVoletosPartida;
		
		public int CantVoletosPartida {
			get { return cantVoletosPartida; }
			set { cantVoletosPartida = value; }
		}
		private int cantVoletosArribo;
		
		public int CantVoletosArribo {
			get { return cantVoletosArribo; }
			set { cantVoletosArribo = value; }
		}	
	}
}
