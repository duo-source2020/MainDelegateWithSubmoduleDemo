using System;
using DelegateDemo;
using OperationPlatForm;


namespace DelegateMain
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("please enter two integers");

			var firstInt = int.Parse(Console.ReadLine());
			var secondInt = int.Parse(Console.ReadLine());

			Console.WriteLine("Add result: {0}", Operation.Run(firstInt, secondInt, MathOperations.Add));
			Console.WriteLine("Multiply result: {0}", Operation.Run(firstInt, secondInt, MathOperations.Multiply));
			Console.WriteLine("Union result: {0}", Operation.Run(firstInt, secondInt, MathOperations.Union));
			Console.WriteLine("Remainder result: {0}", Operation.Run(firstInt, secondInt,MathOperations.Remainder));

			Console.ReadLine();
		}
	}

}
