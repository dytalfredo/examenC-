
using System;

namespace hospital
{
	/// <summary>
	/// Description of Enfermeras.
	/// </summary>
	public class Enfermeras : AtencionPrimaria
	{
		private bool instrumentista;
		
		public bool Instrumentista {get{return instrumentista;} set{instrumentista=value;}}
		
		public Enfermeras(string n, int c, Single s, bool i) : base(n,c,s)
		{
			instrumentista=i;
		}
		
		public void PasarInstrumentos(string[] instrumentos){
			if(instrumentista){
				
			
			foreach (string instrumento in instrumentos) {
				Console.WriteLine("Instrumento: " +instrumento + " pasado");
				}}
			else{
				Console.WriteLine("Realizar Curso de instrumentista primero");
			}
			
		}
		public override void Capacitarce()
		{
			if(!instrumentista){
				instrumentista=true;
			}
		}
		
		public override void ParticiparCirujia(int n, string nombre, string nombreCirujia)
		{
			if(instrumentista){
				Console.WriteLine("La enfermera " + nombre + "participa en la cirugia " + nombreCirujia);
			}
		}
		
		public override string ToString()
		{
			return string.Format("[Enfermeras Instrumentista={4} Nombre={0}, Cedula={1}, SueldoXHora={2}, HorasTrabajadas={3}]", nombre, cedula, sueldoXHora, horasTrabajadas, instrumentista);
		}

	}
}
