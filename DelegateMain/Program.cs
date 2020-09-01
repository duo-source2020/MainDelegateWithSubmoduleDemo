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
			//var thirdInt = int.Parse(Console.ReadLine());

			//original
			//var addOperation = new MathOperation(Add);

			//c# 2.0 - inline
			//MathOperation addOperation = delegate(int a, int b) { return a + b; };

			//C# 3.0 - lambda
			//MathOperation addOperation =  (a, b)=>( a + b );

			
			Console.WriteLine("Add result: {0}", Operation.Run(firstInt, secondInt, MathOperations.Add));
			Console.WriteLine("Multiply result: {0}", Operation.Run(firstInt, secondInt, MathOperations.Multiply));
			Console.WriteLine("Union result: {0}", Operation.Run(firstInt, secondInt, MathOperations.Union));
			Console.WriteLine("Remainder result: {0}", Operation.Run(firstInt, secondInt,MathOperations.Remainder));


			Console.ReadLine();
		}

		
	}

}
