using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Generic.Math.Tests
{
	//From on JonSkeet's MiscUtil: http://www.yoda.arachsys.com/csharp/miscutil/licence.txt
	//From: http://www.yoda.arachsys.com/csharp/miscutil/
	[TestFixture]
	public class OperatorTest
	{
		[Test]
		public void ConvertInt32ToDouble()
		{
			int from = 280;
			double d = GenericMath.Convert<int, double>(from);
			int i = GenericMath.Convert<double, int>(d);
			Assert.AreEqual(i, from);
			Assert.AreEqual(d, (double)i);
		}

		[Test]
		public void XorInt32()
		{
			Assert.AreEqual(270 ^ 54, GenericMath.Xor(270, 54));
		}


		[Test]
		public void SubtractInt32()
		{
			Assert.AreEqual(270 - 54, GenericMath.Subtract(270, 54));
		}

		[Test]
		public void OrInt32()
		{
			Assert.AreEqual(270 | 54, GenericMath.Or(270, 54));
		}

		[Test]
		public void NotEqualInt32()
		{
			Assert.IsTrue(GenericMath.NotEqual(270, 54));
			Assert.IsFalse(GenericMath.NotEqual(270, 270));

		}


		[Test]
		public void EqualInt32()
		{
			Assert.IsFalse(GenericMath.Equal(54, 270));
			Assert.IsTrue(GenericMath.Equal(54, 54));
		}

		[Test]
		public void NotInt32()
		{
			Assert.AreEqual(~270, GenericMath.Not(270));
		}

		[Test]
		public void NegateInt32()
		{
			Assert.AreEqual(-270, GenericMath.Negate(270));
		}

		[Test]
		public void MultiplyInt32()
		{
			Assert.AreEqual(270 * 54, GenericMath.Multiply(270, 54));
		}

		[Test]
		public void MultiplyString()
		{
			Assert.Throws<InvalidOperationException>(() => GenericMath.Multiply("abc", "def"));
		}

		[Test]
		public void NegateString()
		{
			Assert.Throws<InvalidOperationException>(() => GenericMath.Negate("abc"));
		}

		[Test]
		public void LessThanOrEqualInt32()
		{
			Assert.IsTrue(GenericMath.LessThanOrEqual(54, 270));
			Assert.IsTrue(GenericMath.LessThanOrEqual(270, 270));
			Assert.IsFalse(GenericMath.LessThanOrEqual(270, 54));
		}


		[Test]
		public void LessThanInt32()
		{
			Assert.IsTrue(GenericMath.LessThan(54, 270));
			Assert.IsFalse(GenericMath.LessThan(270, 270));
			Assert.IsFalse(GenericMath.LessThan(270, 54));
		}

		[Test]
		public void GreaterThanOrEqualInt32()
		{
			Assert.IsFalse(GenericMath.GreaterThanOrEqual(54, 270));
			Assert.IsTrue(GenericMath.GreaterThanOrEqual(270, 270));
			Assert.IsTrue(GenericMath.GreaterThanOrEqual(270, 54));
		}

		[Test]
		public void GreaterThanInt32()
		{
			Assert.IsFalse(GenericMath.GreaterThan(54, 270));
			Assert.IsFalse(GenericMath.GreaterThan(270, 270));
			Assert.IsTrue(GenericMath.GreaterThan(270, 54));
		}

		[Test]
		public void DivideInt32DoubleTest()
		{
			Assert.AreEqual(14514.7 / 45, GenericMath.DivideInt32(14514.7, 45));
		}

		[Test]
		public void DivideDouble()
		{
			Assert.AreEqual(14514.7 / 45.2, GenericMath.Divide(14514.7, 45.2));
		}

		[Test]
		public void Zero()
		{
			Assert.AreEqual(GenericMath<int>.Zero, (int)0);
			Assert.AreEqual(GenericMath<float>.Zero, (float)0);
			Assert.AreEqual(GenericMath<decimal>.Zero, (decimal)0);
			Assert.AreEqual(GenericMath<string>.Zero, null);
		}

		[Test]
		public void AndInt32()
		{
			Assert.AreEqual(270 & 54, GenericMath.And(270, 54));
		}

		[Test]
		public void AddInt32()
		{
			Assert.AreEqual(270 + 54, GenericMath.Add(270, 54));
		}

		[Test]
		public void AddDateTimeTimeSpan()
		{
			DateTime from = DateTime.Today;
			TimeSpan delta = TimeSpan.FromHours(73.5);
			Assert.AreEqual(from + delta, GenericMath.AddAlternative(from, delta));
		}

		[Test]
		public void MultiplyFloatInt32()
		{
			float from = 123.43F;
			int factor = 12;
			Assert.AreEqual(from * factor, GenericMath.MultiplyAlternative(from, factor));
		}

		[Test]
		public void DivideFloatInt32()
		{
			float from = 123.43F;
			int divisor = 12;
			Assert.AreEqual(from / divisor, GenericMath.DivideAlternative(from, divisor));
			Assert.AreEqual(from / divisor, GenericMath.DivideInt32(from, divisor));
		}

		[Test]
		public void DivideInt32()
		{
			float from = 123.43F;
			int divisor = 12;
			Assert.AreEqual(from / divisor, GenericMath.DivideAlternative(from, divisor));
		}


		[Test]
		public void SubtractDateTimeTimeSpan()
		{
			DateTime from = DateTime.Today;
			TimeSpan delta = TimeSpan.FromHours(73.5);
			Assert.AreEqual(from - delta, GenericMath.SubtractAlternative(from, delta));
		}

		[Test]
		public void AddTestComplex()
		{
			Complex a = new Complex(12, 3);
			Complex b = new Complex(2, 5);

			Assert.AreEqual(a + b, GenericMath.Add(a, b));
		}

		[Test]
		public void SubtractTestComplex()
		{
			Complex a = new Complex(12, 3);
			Complex b = new Complex(2, 5);

			Assert.AreEqual(a - b, GenericMath.Subtract(a, b));
		}

		/// <summary>
		/// Complex number struct created *solely* for test purposes - hence the lack of completeness
		/// </summary>

	}


	public struct Complex : IEquatable<Complex>
	{
		readonly decimal real;
		readonly decimal imaginary;
		public decimal Real { get { return real; } }
		public decimal Imaginary { get { return imaginary; } }
		public Complex(decimal real, decimal imaginary)
		{
			this.real = real;
			this.imaginary = imaginary;
		}

		public override string ToString()
		{
			return string.Format("({0},{1})", real, imaginary);
		}
		public override int GetHashCode()
		{
			return (real.GetHashCode() * 7) + imaginary.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Complex))
			{
				return false;
			}
			return Equals((Complex)obj);
		}

		public bool Equals(Complex other)
		{
			return this.real == other.real &&
				   this.imaginary == other.imaginary;
		}

		public static Complex operator +(Complex first, Complex second)
		{
			return new Complex(first.real + second.real, first.imaginary + second.imaginary);
		}

		public static Complex operator -(Complex first, Complex second)
		{
			return new Complex(first.real - second.real, first.imaginary - second.imaginary);
		}
		public static Complex operator /(Complex first, int second)
		{
			return new Complex(first.real / second, first.imaginary / second);
		}
		public static IComparer<Complex> MagnitudeComparer
		{
			get { return ComplexMagnitudeComparer.Singleton; }
		}

		class ComplexMagnitudeComparer : IComparer<Complex>
		{
			private ComplexMagnitudeComparer() { }
			internal static readonly IComparer<Complex> Singleton = new ComplexMagnitudeComparer();
			int IComparer<Complex>.Compare(Complex lhs, Complex rhs)
			{
				return Comparer<decimal>.Default.Compare(
					lhs.real * lhs.real + lhs.imaginary * lhs.imaginary,
					rhs.real * rhs.real + rhs.imaginary * rhs.imaginary);
			}
		}
	}
}