using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    internal class Rational
    {
		public int Numerator { get; private set; }
		public int Denominator { get; private set; }

		public Rational(int numerator = 0, int denominator = 1)
		{
			this.Numerator = numerator;
			this.Denominator = denominator;
		}

		public void IncreaseBy(Rational other)
		{
			int tempDen = this.Denominator * other.Denominator;
			int tempNum = (this.Denominator * other.Numerator) + (this.Numerator * other.Denominator);
			this.Denominator = tempDen;
			this.Numerator = tempNum;
		}

		public void DecreaseBy(Rational other)
		{
			int tempDen = this.Denominator * other.Denominator;
			int tempNum = (this.Numerator * other.Denominator) - (this.Denominator * other.Numerator);

			this.Denominator = tempDen;
			this.Numerator = tempNum;
		}

		// To overriden string method to display objects in a specific format
		public override string ToString()
		{
			return string.Format($"{Numerator}/{Denominator}");
		}
	}
}
