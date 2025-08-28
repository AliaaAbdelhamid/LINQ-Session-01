namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region Implicitly Typed Local Variable

			#region var 
			////string Name = "Ahmed";

			//var Data = "Ahmed"; // Implicit Type 
			//					// Compiler Will Detect its type at compile time based on its Initial Value 

			//var X = null; // Invalid Can Not Initialize With Null
			//var Y; // Invalid Must Be Initialized 

			//Data = null; // Valid 
			//Data = 5; // Invalid
			//		  // after Initialization , Can Not Change Variable Type 
			//Data = "Amr";

			#endregion

			#region Dynamic 
			//dynamic Data = "Ali";
			//// CLR Will Detect Type Of Variable At RunTime
			//// Based On Its Last Assigned Value 

			//Data = 5;
			//// After Initialization , You Can Change Data Type Of Variable 
			//Data = null;
			//Data = true;

			//dynamic X;
			//// Can Declare Variable With Dynamic Without Initialization

			//dynamic Y = null;
			//// Can Be Initialized With null;

			#endregion

			//for (var i = 0; i < 10; i++) { }
			//foreach (var item in args) { }

			////var X = null; // Invalid
			//dynamic X = null;
			//Console.WriteLine(X); // RuntimeBinderException

			#endregion

		}
	}
}
