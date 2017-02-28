using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Generic.Math
{
	//Based on JonSkeet's MiscUtil: http://www.yoda.arachsys.com/csharp/miscutil/licence.txt
	//From: http://www.yoda.arachsys.com/csharp/miscutil/
	/// <summary>
	/// The Operator class provides easy access to the standard operators
	/// (addition, etc) for generic types, using type inference to simplify
	/// usage.
	/// </summary>
	public static class GenericMath
	{
		/// <summary>
		/// Evaluates unary negation (-) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static T Negate<T>(T value)
		{
			return Operator<T>.Negate(value);
		}

		/// <summary>
		/// Evaluates bitwise not (~) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static T Not<T>(T value)
		{
			return Operator<T>.Not(value);
		}

		/// <summary>
		/// Evaluates bitwise or (|) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static T Or<T>(T value1, T value2)
		{
			return Operator<T>.Or(value1, value2);
		}

		/// <summary>
		/// Evaluates bitwise and (&amp;) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static T And<T>(T value1, T value2)
		{
			return Operator<T>.And(value1, value2);
		}

		/// <summary>
		/// Evaluates bitwise xor (^) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static T Xor<T>(T value1, T value2)
		{
			return Operator<T>.Xor(value1, value2);
		}

		/// <summary>
		/// Performs a conversion between the given types; this will throw
		/// an InvalidOperationException if the type T does not provide a suitable cast, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this cast.
		/// </summary>
		public static TTo Convert<TFrom, TTo>(TFrom value)
		{
			return Operator<TFrom, TTo>.Convert(value);
		}

		/// <summary>
		/// Evaluates binary addition (+) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>        
		public static T Add<T>(T value1, T value2)
		{
			return Operator<T>.Add(value1, value2);
		}

		/// <summary>
		/// Evaluates binary addition (+) for the given type(s); this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static TArg1 AddAlternative<TArg1, TArg2>(TArg1 value1, TArg2 value2)
		{
			return Operator<TArg2, TArg1>.Add(value1, value2);
		}

		/// <summary>
		/// Evaluates binary subtraction (-) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static T Subtract<T>(T value1, T value2)
		{
			return Operator<T>.Subtract(value1, value2);
		}

		/// <summary>
		/// Evaluates binary subtraction(-) for the given type(s); this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static TArg1 SubtractAlternative<TArg1, TArg2>(TArg1 value1, TArg2 value2)
		{
			return Operator<TArg2, TArg1>.Subtract(value1, value2);
		}

		/// <summary>
		/// Evaluates binary multiplication (*) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static T Multiply<T>(T value1, T value2)
		{
			return Operator<T>.Multiply(value1, value2);
		}

		/// <summary>
		/// Evaluates binary multiplication (*) for the given type(s); this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static TArg1 MultiplyAlternative<TArg1, TArg2>(TArg1 value1, TArg2 value2)
		{
			return Operator<TArg2, TArg1>.Multiply(value1, value2);
		}

		/// <summary>
		/// Evaluates binary division (/) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static T Divide<T>(T value1, T value2)
		{
			return Operator<T>.Divide(value1, value2);
		}

		/// <summary>
		/// Evaluates binary division (/) for the given type(s); this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static TArg1 DivideAlternative<TArg1, TArg2>(TArg1 value1, TArg2 value2)
		{
			return Operator<TArg2, TArg1>.Divide(value1, value2);
		}

		/// <summary>
		/// Evaluates binary equality (==) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static bool Equal<T>(T value1, T value2)
		{
			return Operator<T>.Equal(value1, value2);
		}

		/// <summary>
		/// Evaluates binary inequality (!=) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static bool NotEqual<T>(T value1, T value2)
		{
			return Operator<T>.NotEqual(value1, value2);
		}

		/// <summary>
		/// Evaluates binary greater-than (&gt;) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static bool GreaterThan<T>(T value1, T value2)
		{
			return Operator<T>.GreaterThan(value1, value2);
		}

		/// <summary>
		/// Evaluates binary less-than (&lt;) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static bool LessThan<T>(T value1, T value2)
		{
			return Operator<T>.LessThan(value1, value2);
		}

		/// <summary>
		/// Evaluates binary greater-than-on-eqauls (&gt;=) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static bool GreaterThanOrEqual<T>(T value1, T value2)
		{
			return Operator<T>.GreaterThanOrEqual(value1, value2);
		}

		/// <summary>
		/// Evaluates binary less-than-or-equal (&lt;=) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static bool LessThanOrEqual<T>(T value1, T value2)
		{
			return Operator<T>.LessThanOrEqual(value1, value2);
		}

		/// <summary>
		/// Evaluates integer division (/) for the given type; this will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary><remarks>
		/// This operation is particularly useful for computing averages and
		/// similar aggregates.
		/// </remarks>
		public static T DivideInt32<T>(T value, int divisor)
		{
			return Operator<int, T>.Divide(value, divisor);
		}
	}

	/// <summary>
	/// Provides standard operators (such as addition) that operate over operands of
	/// different types. For operators, the return type is assumed to match the first
	/// operand.
	/// </summary>
	/// <seealso cref="Operator&lt;T&gt;"/>
	/// <seealso cref="Operator"/>
	public static class Operator<TValue, TResult>
	{
		private static readonly Lazy<Func<TValue, TResult>> convert;

		/// <summary>
		/// Returns a delegate to convert a value between two types; this delegate will throw
		/// an InvalidOperationException if the type T does not provide a suitable cast, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this cast.
		/// </summary>
		public static Func<TValue, TResult> Convert => convert.Value;

		static Operator()
		{
			convert = new Lazy<Func<TValue, TResult>>(() => ExpressionUtil.CreateExpression<TValue, TResult>(body => Expression.Convert(body, typeof(TResult))), true);
			add = new Lazy<Func<TResult, TValue, TResult>>(() => ExpressionUtil.CreateExpression<TResult, TValue, TResult>(Expression.Add, true), true);
			subtract = new Lazy<Func<TResult, TValue, TResult>>(() => ExpressionUtil.CreateExpression<TResult, TValue, TResult>(Expression.Subtract, true), true);
			multiply = new Lazy<Func<TResult, TValue, TResult>>(() => ExpressionUtil.CreateExpression<TResult, TValue, TResult>(Expression.Multiply, true), true);
			divide = new Lazy<Func<TResult, TValue, TResult>>(() => ExpressionUtil.CreateExpression<TResult, TValue, TResult>(Expression.Divide, true), true);
		}

		private static readonly Lazy<Func<TResult, TValue, TResult>> add, subtract, multiply, divide;

		/// <summary>
		/// Returns a delegate to evaluate binary addition (+) for the given types; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<TResult, TValue, TResult> Add => add.Value;

		/// <summary>
		/// Returns a delegate to evaluate binary subtraction (-) for the given types; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<TResult, TValue, TResult> Subtract => subtract.Value;

		/// <summary>
		/// Returns a delegate to evaluate binary multiplication (*) for the given types; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<TResult, TValue, TResult> Multiply => multiply.Value;

		/// <summary>
		/// Returns a delegate to evaluate binary division (/) for the given types; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<TResult, TValue, TResult> Divide => divide.Value;
	}

	/// <summary>
	/// Provides standard operators (such as addition) over a single type
	/// </summary>
	/// <seealso cref="Operator"/>
	/// <seealso cref="Operator&lt;TValue,TResult&gt;"/>
	public static class Operator<T>
	{
		/// <summary>
		/// Returns the zero value for value-types (even full Nullable&lt;TInner&gt;) - or null for reference types
		/// </summary>
		public static T Zero { get; } = default(T);

		static readonly Lazy<Func<T, T>> negate, not;
		static readonly Lazy<Func<T, T, T>> or, and, xor;

		/// <summary>
		/// Returns a delegate to evaluate unary negation (-) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T> Negate => negate.Value;

		/// <summary>
		/// Returns a delegate to evaluate bitwise not (~) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T> Not => not.Value;

		/// <summary>
		/// Returns a delegate to evaluate bitwise or (|) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T, T> Or => or.Value;

		/// <summary>
		/// Returns a delegate to evaluate bitwise and (&amp;) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T, T> And => and.Value;

		/// <summary>
		/// Returns a delegate to evaluate bitwise xor (^) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T, T> Xor => xor.Value;

		static readonly Lazy<Func<T, T, T>> add, subtract, multiply, divide;

		/// <summary>
		/// Returns a delegate to evaluate binary addition (+) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T, T> Add => add.Value;

		/// <summary>
		/// Returns a delegate to evaluate binary subtraction (-) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T, T> Subtract => subtract.Value;

		/// <summary>
		/// Returns a delegate to evaluate binary multiplication (*) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T, T> Multiply => multiply.Value;

		/// <summary>
		/// Returns a delegate to evaluate binary division (/) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T, T> Divide => divide.Value;

		static readonly Lazy<Func<T, T, bool>> equal, notEqual, greaterThan, lessThan, greaterThanOrEqual, lessThanOrEqual;

		/// <summary>
		/// Returns a delegate to evaluate binary equality (==) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T, bool> Equal => equal.Value;

		/// <summary>
		/// Returns a delegate to evaluate binary inequality (!=) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T, bool> NotEqual => notEqual.Value;

		/// <summary>
		/// Returns a delegate to evaluate binary greater-then (&gt;) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T, bool> GreaterThan => greaterThan.Value;

		/// <summary>
		/// Returns a delegate to evaluate binary less-than (&lt;) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T, bool> LessThan => lessThan.Value;

		/// <summary>
		/// Returns a delegate to evaluate binary greater-than-or-equal (&gt;=) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T, bool> GreaterThanOrEqual => greaterThanOrEqual.Value;

		/// <summary>
		/// Returns a delegate to evaluate binary less-than-or-equal (&lt;=) for the given type; this delegate will throw
		/// an InvalidOperationException if the type T does not provide this operator, or for
		/// Nullable&lt;TInner&gt; if TInner does not provide this operator.
		/// </summary>
		public static Func<T, T, bool> LessThanOrEqual => lessThanOrEqual.Value;

		static Operator()
		{
			Type typeT = typeof(T);
			if (typeT.GetTypeInfo().IsValueType && typeT.GetTypeInfo().IsGenericType && (typeT.GetGenericTypeDefinition() == typeof(Nullable<>)))
			{
				throw new InvalidOperationException($"Generic math between {nameof(Nullable)} types is not implemented. Type: {typeof(T).FullName} is nullable.");
			}

			add = new Lazy<Func<T, T, T>>(() => ExpressionUtil.CreateExpression<T, T, T>(Expression.Add), true);
			subtract = new Lazy<Func<T, T, T>>(() => ExpressionUtil.CreateExpression<T, T, T>(Expression.Subtract), true);
			divide = new Lazy<Func<T, T, T>>(() => ExpressionUtil.CreateExpression<T, T, T>(Expression.Divide), true);
			multiply = new Lazy<Func<T, T, T>>(() => ExpressionUtil.CreateExpression<T, T, T>(Expression.Multiply), true);

			greaterThan = new Lazy<Func<T, T, bool>>(() => ExpressionUtil.CreateExpression<T, T, bool>(Expression.GreaterThan), true);
			greaterThanOrEqual = new Lazy<Func<T, T, bool>>(() => ExpressionUtil.CreateExpression<T, T, bool>(Expression.GreaterThanOrEqual), true);
			lessThan = new Lazy<Func<T, T, bool>>(() => ExpressionUtil.CreateExpression<T, T, bool>(Expression.LessThan), true);
			lessThanOrEqual = new Lazy<Func<T, T, bool>>(() => ExpressionUtil.CreateExpression<T, T, bool>(Expression.LessThanOrEqual), true);
			equal = new Lazy<Func<T, T, bool>>(() => ExpressionUtil.CreateExpression<T, T, bool>(Expression.Equal), true);
			notEqual = new Lazy<Func<T, T, bool>>(() => ExpressionUtil.CreateExpression<T, T, bool>(Expression.NotEqual), true);

			negate = new Lazy<Func<T, T>>(() => ExpressionUtil.CreateExpression<T, T>(Expression.Negate), true);
			and = new Lazy<Func<T, T, T>>(() => ExpressionUtil.CreateExpression<T, T, T>(Expression.And), true);
			or = new Lazy<Func<T, T, T>>(() => ExpressionUtil.CreateExpression<T, T, T>(Expression.Or), true);
			not = new Lazy<Func<T, T>>(() => ExpressionUtil.CreateExpression<T, T>(Expression.Not), true);
			xor = new Lazy<Func<T, T, T>>(() => ExpressionUtil.CreateExpression<T, T, T>(Expression.ExclusiveOr), true);
		}
	}
}