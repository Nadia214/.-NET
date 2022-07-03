using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAssignment;

namespace MyAssignment
{
	
	class Program
	{
		static void Main(string[] args)
		{
		
			MyAssignment.Rational obj1 = new Rational();
			MyAssignment.Rational obj2 = new Rational(7);
			MyAssignment.Rational obj3 = new Rational(numerator: 1, denominator: 9);
			MyAssignment.Rational obj4 = new Rational(numerator: 2, denominator: 5);

			Console.WriteLine("Before calling Increasedby(Rational other) method:");
			Console.WriteLine("\nthe 1st fraction obj1: " + obj1.ToString());
			Console.WriteLine("the 2nd fraction obj22: " + obj2.ToString());

			obj1.IncreaseBy(obj2);

			Console.WriteLine("\nAfter current obj1 increased ny obj2 :");
			Console.WriteLine("\nthe 1st fraction obj1: " + obj1.ToString());
			Console.WriteLine("the 2nd fraction obj2: " + obj2.ToString());

			//Task - 3. Select another two pairs of the above objects,
			//print them then call the DecreasedBy(Rational) method and print the objects again
			Console.WriteLine("\nBefore calling Decreasedby(Rational other) method:");
			Console.WriteLine("\nthe 3rd fraction obj3: " + obj3.ToString());
			Console.WriteLine("the 4th fraction obj4: " + obj4.ToString());

			obj3.DecreaseBy(obj4);

			Console.WriteLine("\nAfter Cuurent obj3 decreased by obj4: ");
			Console.WriteLine("\nthe 3rd fraction obj3: " + obj3.ToString());
			Console.WriteLine("the 4th fraction obj4: " + obj4.ToString());
		}
	}
}
