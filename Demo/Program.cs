using Demo.AnonymousMethod;
using Demo.Extension_Method;

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

			#region Extension Method
			//int X = 12345;
			//int ReversedNumber = IntExtensions.Reverse(X);
			//Console.WriteLine(ReversedNumber); // 54321

			//ReversedNumber = X.Reverse();
			//Console.WriteLine(ReversedNumber); // 54321

			#endregion

			#region Anonymous Type 

			////Employee employee = new Employee() { Id = 10 , Name = "Ahmed" , Salary = 5000};

			//var employee = new { Id = 10 , Name = "Ahmed" , Salary = 5000};
			//Console.WriteLine(employee.Salary); // Valid

			//int X = 10;
			//Console.WriteLine(X.GetType().Name); // Int32
			//Console.WriteLine(employee.GetType().Name); // <>f__AnonymousType0`3

			////employee.Name = "Mona"; // Invalid 
			////// Object Created From Anonymous Type Is An Immutable Objects 

			//var emp01 = new {Id = employee.Id , Name = "Mona" ,Salary = employee.Salary}; // Till C# 9
			//Console.WriteLine(emp01);
			//Console.WriteLine(emp01.Name); // Mona
			//Console.WriteLine(emp01.GetType().Name); // <>f__AnonymousType0`3

			//var emp02 = employee with { Name = "Mona" }; // C# 10 Feature 
			//Console.WriteLine(emp02);
			//Console.WriteLine(emp02.Name); // Mona
			//Console.WriteLine(emp02.GetType().Name); // <>f__AnonymousType0`3

			//// The Same Anonymous Type As long As :
			//// 1. Same Properties Name [Case Sensitive]
			//// 2. Same Properties Order 

			//var emp03 = new { id = 10, Name = "Ahmed", Salary = 5000 };
			//Console.WriteLine(emp03);
			//Console.WriteLine(emp03.GetType().Name); // <>f__AnonymousType1`3

			//var emp04 = new {  Name = "Ahmed", Id = 10, Salary = 5000 };
			//Console.WriteLine(emp04);
			//Console.WriteLine(emp04.GetType().Name); // <>f__AnonymousType2`3

			//var emp05 = new { Name = "Ahmed", Id = 10 };
			//Console.WriteLine(emp05);
			//Console.WriteLine(emp05.GetType().Name); // <>f__AnonymousType3`2
			#endregion

			#region What Is LINQ 

			//List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			//var EvenNumbers = Numbers.Where(X => X % 2 == 0).ToList();

			//foreach (var EvenNumber in EvenNumbers)
			//	Console.WriteLine(EvenNumber); // 2 4 6 8 10


			#endregion

			#region LINQ Syntax 

			//List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


			#region 1. Fluent Syntax - Method Syntax
			//// 1.2 Call LinQ Operators As Class Member Method 
			//var EvenNumbers = Enumerable.Where(Numbers, X => X % 2 == 0);

			//// 1.1 Call LinQ Operators As object Member Method [Extension Method - Recommended]
			//EvenNumbers = Numbers.Where(X => X % 2 == 0);
			#endregion


			#region 2.Query Syntax

			//// Started With From And Must Ended With "Select" Or "GroupBy"

			///* Select *
			// * From Numbers N
			// * Where N % 2 == 0 */


			//EvenNumbers = from N in Numbers
			//			  where N % 2 == 0
			//			  select N;

			#endregion

			//foreach (int num in EvenNumbers)
			//	Console.WriteLine(num); // 2 4 6 8 10  

			#endregion
		}
	}
}
