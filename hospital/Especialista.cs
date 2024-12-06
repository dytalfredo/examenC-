
using System;

namespace hospital
{
	/// <summary>
	/// Description of Especialista.
	/// </summary>
	public class Especialista : Profesional, IRecetar
	{
		
		protected string especialidad;
		
		public string Especialidad {get {return especialidad;} set {especialidad=value;}}

		
		public Especialista(string n, int c, Single s, string espe) : base(n,c,s)
		{
			especialidad=espe;
		}
		
		
		public void RecetarMedicamentos(string[] sintomas){
			foreach (string sintoma in sintomas) {
				Console.WriteLine("Para el sintoma " + sintoma +" Sana sana culito de rana");
			}
		}
		

	
		
		public override void Capacitarce()
		{
			Console.WriteLine("ESTUDIAR CURSO INTENSIVO");
		}
	}
}
