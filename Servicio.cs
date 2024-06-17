
using System;

namespace proyecto2
{
	/// <summary>
	/// Description of Servicio.
	/// </summary>
	public class Servicio
	{
		private string nombre;
		private string descripcion;
		private int cant;
		private int costoUnit;
		
		public Servicio(string nombre, string descripcion, int cant, int costoUnit)
		{
			this.nombre = nombre;
			this.descripcion = descripcion;
			this.cant = cant;
			this.costoUnit = costoUnit;
		}
		
		public void verAtributos(){
			Console.WriteLine("Información del servicio '{0}': ",nombre);
			Console.WriteLine("Descripcion: {0}", descripcion);
			Console.WriteLine("Cantidad: {0}", cant);
			Console.WriteLine("Costo unitario: {0}\n", costoUnit);
		}
	}
}
