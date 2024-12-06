/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 5/12/2024
 * Time: 9:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace hospital
{
	/// <summary>
	/// Description of AtencionPrimaria.
	/// </summary>
	public abstract class AtencionPrimaria : Profesional
	{
		
		
		public AtencionPrimaria(string n, int c, Single s) : base(n,c,s)
		{
		}
		
		public void AtenderPaciente(string nombre, DateTime n){
			Console.WriteLine("El paciente " + nombre +"fue atendido el " + n);
		}
		
		public void AdministrarMedicinas(int c, string nombre){
			Console.WriteLine(c + " medicinas administradas al paciente " + nombre);
		}
		
	}
}
