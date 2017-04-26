// https://msdn.microsoft.com/en-us//library/bb383977.aspx


namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, 
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }   
}

//////////////// using extension method /////////////////
using ExtensionMethods;  
string s = "Hello Extension Methods";  
int i = s.WordCount();  