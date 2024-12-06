
using System;

namespace hospital
{

	public class Paramedico : AtencionPrimaria 
	{
		
		protected int numeroDeAmbulancia;
		public int Ambulancia {get {return numeroDeAmbulancia;} set {numeroDeAmbulancia=value;}}
		
		public Paramedico(string n, int c, Single s, int numero) : base(n,c,s)
		{
			numeroDeAmbulancia=numero;
		}
		
		public override void Capacitarce()
		{
			Console.WriteLine("ESTUDIAR CURSO INTENSIVO");
		}
		
		public override void ParticiparCirujia(int n, string nombre, string nombreCirujia)
		{
			Console.WriteLine("Los paramedicos no pueden participar en cirujias");
		}
		
		public void ConducirAmbulancia(){
			Console.WriteLine("Ambulancia " + Ambulancia + "Sale de emergencia");
		}
	}
}
