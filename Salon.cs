
using System;
using System.Collections;

namespace proyecto2
{
	/// <summary>
	/// Description of Salon.
	/// </summary>
	public class Salon
	{
		private string nombre;
		private ArrayList listaEventos;
		private ArrayList listaEmpleados;		
		
		public Salon(string nombre)
		{
			this.nombre = nombre;
			listaEventos = new ArrayList();
			listaEmpleados = new ArrayList();
		}
		
		public void verAtributos(){
			Console.WriteLine("Informacion de los eventos contratados:\n");
			
			foreach(Evento eve in listaEventos){
				eve.verAtributos();
			}
			
			Console.WriteLine("Informacion de los empleados del salon:\n");
			foreach(Empleado emp in listaEmpleados){
				emp.verAtributos();
			}
			
		}

		public void altaEmpleado(Empleado e){
			listaEmpleados.Add(e);
		}
		
		public void bajaEmpleado(Empleado e){
			listaEmpleados.Remove(e);
		}
	}
}
