using System;

namespace hospital
{

	public abstract class Profesional
	{
		protected string nombre;
		protected int cedula;
		protected Single sueldoXHora;
		protected int horasTrabajadas;
		
		public string Nombre {get {return nombre;} set {nombre = value;}}
		public int Cedula {get {return cedula;} set {cedula = value;}}
		public Single SueldoXHora {get {return sueldoXHora;} set {sueldoXHora = value;}}
		public int HorasTrabajadas {get {return horasTrabajadas;} set {horasTrabajadas = value;}}
			
		public Profesional(string n, int c, Single s) 
		{
			nombre = n;
			cedula = c;
			sueldoXHora=s;
			horasTrabajadas=0;
			
			
		}
		
		abstract public void Capacitarce();
		
		public Single CalculoSueldoMensual() {
			return horasTrabajadas*sueldoXHora;
		}
		
		public int AumentarHorasTrabajadas(int h){
			horasTrabajadas=horasTrabajadas+h;
			return horasTrabajadas;
		}
		
		public virtual void ParticiparCirujia(int n, string nombre, string nombreCirujia){
			Console.WriteLine("CIRUJIA");
		}
		
		public override string ToString()
		{
			return string.Format("[Profesional Nombre={0}, Cedula={1}, SueldoXHora={2}, HorasTrabajadas={3}]", nombre, cedula, sueldoXHora, horasTrabajadas);
		}

	}
}

