 'the where clause is used to specify constraints on 
 the types that can be used as arguments for a type parameter 
 defined in a generic declaration. '


 'For example, you can declare a generic class, MyGenericClass, 
 such that the type parameter T implements the IComparable<T> interface:'

 public class MyGenericClass<T> where T:IComparable { }  


class MyClass<T, U>
        where T : class
        where U : struct
    { }


public class MyGenericClass<T> where T : IComparable, new()
{
    // The following line is not possible without new() constraint:
    T item = new T();
}



interface IMyInterface
{
}

class Dictionary<TKey, TVal>
    where TKey : IComparable, IEnumerable
    where TVal : IMyInterface
{
    public void Add(TKey key, TVal val)
    {
    }
}


public bool MyMethod<T>(T t) where T : IMyInterface { }  
