
using System;

namespace proyecto2
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public class Empleado
	{
		protected string nombre;
		protected string apellido;
		protected int dni;
		protected int sueldo;
		protected string tarea;
		
		
		public Empleado(string nombre, string apellido, int dni, int sueldo, string tarea)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.sueldo = sueldo;
			this.tarea = tarea;
		}
		
		public virtual void verAtributos(){
			Console.WriteLine("Informacion del empleado {0} {1}",nombre, apellido);
			Console.WriteLine("Dni: " + dni);
			Console.WriteLine("Sueldo: " + "$" + sueldo);
			Console.WriteLine("Tarea: " + tarea);
		}
	}
}
