using System.Collections;
using System;

namespace proyecto2
{
	/// <summary>
	/// Description of Evento.
	/// </summary>
	public class Evento
	{
		private string nombreEvento;
		private string nombreCliente;
		private int dniCliente;
		private string fecha;
		private string hora;
		private int seña;
		private int costoTotal;
		private Encargado encargado;
		private ArrayList listaServicios;
		
		public Evento(string nombreEvento, string nombreCliente, int dniCliente, string fecha, string hora, int seña, int costoTotal, Encargado encargado)
		{
			this.nombreEvento = nombreEvento;
			this.nombreCliente = nombreCliente;
			this.dniCliente = dniCliente;
			this.fecha = fecha;
			this.hora = hora;
			this.seña = seña;
			this.costoTotal = costoTotal;
			this.encargado = encargado;
			listaServicios = new ArrayList();
		}
		
		public void verAtributos(){
			Console.WriteLine("Información del cliente contratando el evento '{0}':", nombreEvento);
			Console.WriteLine("Nombre: {0}", nombreCliente);
			Console.WriteLine("Dni: {0}", dniCliente);
			Console.WriteLine("Seña: {0}\n", seña);
			
			Console.WriteLine("Información del evento:");
			Console.WriteLine("Fecha: {0}", fecha);
			Console.WriteLine("Hora: {0}", hora);
			Console.WriteLine("Costo total: {0}\n", costoTotal);
			
			Console.WriteLine("Informacion de los servicios contratados:\n");
			foreach (Servicio s in listaServicios){
				s.verAtributos();
			}
			
			encargado.verAtributos();
		}
		
		public void agregarServicio(Servicio s){
			listaServicios.Add(s);
		}
		
		public void quitarServicio(Servicio s){
			listaServicios.Remove(s);
		}
			
	}
}
