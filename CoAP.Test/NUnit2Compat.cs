using NUnit.Framework;

namespace CoAP
{
	public static partial class Assert
	{
		public static void IsTrue(this bool condition) => NUnit.Framework.Assert.That(condition);

		public static void IsTrue(this bool condition, string message) => NUnit.Framework.Assert.That(condition, message);

		public static void IsFalse(this bool condition) => NUnit.Framework.Assert.That(!condition);

		public static void AreEqual<T>(this T expected, T actual) => NUnit.Framework.Assert.That(actual, Is.EqualTo(expected));

		public static void AreNotEqual<T>(this T expected, T actual) => NUnit.Framework.Assert.That(actual, Is.Not.EqualTo(expected));

		public static void IsNotNull<T>(this T actual) => NUnit.Framework.Assert.That(actual, Is.Not.Null);

		public static void Fail() => NUnit.Framework.Assert.Fail();

		public static void Fail(this string message) => NUnit.Framework.Assert.Fail(message);
	}
}
