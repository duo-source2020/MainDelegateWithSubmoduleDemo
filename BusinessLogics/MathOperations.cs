namespace DelegateDemo
{
	public class MathOperations
	{
		public static int Add(int a, int b)
		{
			return a + b;
		}

		public static int Multiply(int a1, int a2)
		{
			return a1 * a2;
		}

		public static int Union(int a, int b)
		{
			return int.Parse(a.ToString() + b.ToString());
		}

		public static int Remainder(int a, int b)
		{
			return a % b;
		}
	}
}