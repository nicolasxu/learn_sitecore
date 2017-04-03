// https://msdn.microsoft.com/en-us/library/bb549151(v=vs.110).aspx


public delegate TResult Func<in T, out TResult>(
  T arg
)


// example 1:  by instantiating the Func<T, TResult> delegate instead of explicitly 
// defining a new delegate and assigning a named method to it
// 

using System;

public class GenericFunc
{
   public static void Main()
   {
      // Instantiate delegate to reference UppercaseString method
      Func<string, string> convertMethod = UppercaseString;
      string name = "Dakota";
      // Use delegate instance to call UppercaseString method
      Console.WriteLine(convertMethod(name));
   }

   private static string UppercaseString(string inputString)
   {
      return inputString.ToUpper();
   }
}

/// example 2, use the Func<T, TResult> delegate with anonymous methods in C#

using System;

public class Anonymous
{
   public static void Main()
   {
      Func<string, string> convert = delegate(string s)
         { return s.ToUpper();}; 

      string name = "Dakota";
      Console.WriteLine(convert(name));   
   }
}


/// example 3, with lambda

using System;

public class LambdaExpression
{
   public static void Main()
   {
      Func<string, string> convert = s => s.ToUpper();

      string name = "Dakota";
      Console.WriteLine(convert(name));   
   }
}