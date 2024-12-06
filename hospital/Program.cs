using System;

namespace hospital
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
            
			Medico alberto = new Medico ("alfredo", 19431163, 500.00f, 5);
			
			Console.WriteLine(alberto);
			
			alberto.AumentarHorasTrabajadas(10);
			
			Console.WriteLine(alberto);
			
			Especialista alfredo = new Especialista("Jose", 23498213, 150.35f, "Cardiologo");
			
			
			Enfermeras davi = new Enfermeras("Zuzej", 12123123, 130.3f, false);
			
			
			
			
			
			
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}