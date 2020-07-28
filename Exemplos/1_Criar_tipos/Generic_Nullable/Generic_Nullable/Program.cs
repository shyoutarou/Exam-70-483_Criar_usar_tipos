using System;

namespace Generic_Nullable
{
    class MyClass<T> where T : class, new()
    {
        public MyClass()
        {
            MyProperty = new T();
        }
        T MyProperty { get; set; }
    }

//[Serializable]
//public struct Nullable<T> where T : struct
//{
//    public bool HasValue { get; }

//    public T Value { get; }

//    // other implementation
//}

    //struct Nullable<T> where T : struct
    //{
    //    private bool hasValue;
    //    private T value;
    //    public Nullable(T value)
    //    {
    //        this.hasValue = true;
    //        this.value = value;
    //    }
    //    public bool HasValue { get { return this.hasValue; } }
    //    public T Value
    //    {
    //        get
    //        {
    //            if (!this.HasValue) throw new ArgumentException();
    //            return this.value;
    //        }
    //    }
    //    public T GetValueOrDefault()
    //    {
    //        return this.value;
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;

            if (i.HasValue)
                Console.WriteLine(i.Value); // or Console.WriteLine(i)
            else
                Console.WriteLine("Null");

            Console.WriteLine(i.GetValueOrDefault());
            MyGenericMethod(1);

            Console.ReadKey();
        }

        public static void MyGenericMethod<T>(T first)
        {
            T defaultValue = default(T);
        }
    }
}
