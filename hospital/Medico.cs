using System;

namespace hospital
{

	public class Medico : AtencionPrimaria, IRecetar
	{
		
		protected int numeroEstacionamiento;
		
		public int NumeroEstacionamiento {get {return numeroEstacionamiento;} set {numeroEstacionamiento=value;}}

			
		public Medico(string n, int c, Single s, int numero) : base(n,c,s)
		{
			numeroEstacionamiento= numero;
        }
		
		
		
		public override void Capacitarce()
		{
			Console.WriteLine("ESTUDIAR CURSO INTENSIVO");
		}
		
		public void RecetarMedicamentos(string[] sintomas){
			foreach (string sintoma in sintomas) {
				Console.WriteLine("Para el sintoma " + sintoma +" Sana sana culito de rana");
			}
		}
		
	

	}
}
