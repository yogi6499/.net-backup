using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using static System.Console;
namespace ImportantConcepts
{
	class Customer
	{
		private long id;
		private String name, email, contactNo;
		char gender;
		public long Id { get; set; }

		public Customer(long id, String name, String email, String contactNo, char gender)
		{

			this.id = id;
			this.name = name;
			this.email = email;
			this.contactNo = contactNo;
			this.gender = gender;
		}

		public String Name { get; set; }


		public String Email { get; set; }


		public String ContactNo { get; set; }


		public char Gender { get; set; }


		public String toString()
		{
			return "Customer: " + this.Name + "\n" + "Customer contact details: " + this.ContactNo + ", " + this.Email;
		}

		public int MethodWithParameter(int a, int b) => a + b;
	}
	class Program
    {
        static void Main(string[] args)
        {
            
			Type type = typeof(Customer);
            WriteLine($"Name of class {type.Name}");
            WriteLine($"Namespace of Class {type.Namespace}");
            WriteLine("------------------------------------");
            WriteLine("Properties of class");
            var properties = type.GetProperties();
			foreach (var property in properties)
				WriteLine($"{property.PropertyType.Name} {property.Name}");
			
			WriteLine("------------------------------------");
			
			WriteLine("Methods of class");
			var methods = type.GetMethods();
			foreach (var method in methods)
			{
				WriteLine( $"{method.ReturnType} {method.Name} ");
				var parameters = method.GetParameters();
				WriteLine($"Parameters of {method.Name}");
				foreach (var parameter in parameters)
				{
					
                    
						WriteLine(parameter.ParameterType);
				}
				WriteLine();
			}
			
			WriteLine("------------------------------------");
			WriteLine("Constructor of class");
			var constructors = type.GetConstructors();
			foreach (var constructor in constructors)
				WriteLine($"{constructor.ToString()}");
			ReadLine();
			
		}
    }
}
