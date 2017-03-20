using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string helloworld = "Hello World";
			int columbus = 1492;
			bool ihavedog = true;
			DateTime today = DateTime.Now;
			decimal costofburger = 5.45m;
			char marksspot = 'x';
			Console.WriteLine(helloworld);
			string Columbus = "Columbus Sailed the world in";
			Columbus += columbus;
			Console.WriteLine(Columbus);
			Console.WriteLine($"It is {ihavedog} I have a dog at home");
			Console.WriteLine($"Today is {today}");
			Console.WriteLine($"I spent {costofburger:c} on a cheeseburger");
			Console.WriteLine($"{marksspot} marks the spot");











		}
	}
}
