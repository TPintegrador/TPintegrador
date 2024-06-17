
using System;

namespace proyecto2
{
	/// <summary>
	/// Description of Encargado.
	/// </summary>
	public class Encargado:Empleado
	{
		private int plus;
		
		public Encargado(string nombre, string apellido, int dni, int sueldo, string tarea, int plus) : base(nombre, apellido, dni, sueldo, tarea)
		{
//			this.plus = plus;
			this.sueldo = sueldo + plus;
		}
		
		public override void verAtributos(){
			Console.WriteLine("Informacion del encargado {0} {1}",nombre, apellido);
			Console.WriteLine("Dni: " + dni);
			Console.WriteLine("Sueldo: " + "$" + sueldo);
			Console.WriteLine("Tarea: " + tarea);
		}
	}
}
