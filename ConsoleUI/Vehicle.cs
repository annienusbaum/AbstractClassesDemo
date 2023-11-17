using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public int Year { get; set; } = 1;
		public string Make { get; set; } = "Default Model";
		public string Model { get; set; } = "Default Model";

		public abstract void DriveAbstract(); //stubbed out method -has no implementation

		public virtual void DriveVirtual()
		{
			Console.WriteLine($"This {GetType().Name} is virtually in drive");
		}
	}
}

