using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConstraints
{
    //Constraint: where T : class
    public class ReferenceTypeContainer<T> where T : class
    {
        private T _value;

        public ReferenceTypeContainer(T value)
        {
            _value = value;
        }

        public void Print()
        {
            if (_value != null)
                Console.WriteLine($"Value: {_value.ToString()}");
            else
                Console.WriteLine("Value is null");
        }
    }

    //Constraint: where T : struct
    public class ValueTypeContainer<T> where T : struct
    {
        private T _value;

        public ValueTypeContainer(T value)
        {
            _value = value;
        }

        public void Print()
        {
            Console.WriteLine($"Value: {_value.ToString()}");
        }
    }

    //Constraint: where T : new()
    public class ParameterlessConstructorContainer<T> where T : new()
    {
        private T _value;

        public ParameterlessConstructorContainer()
        {
            _value = new T();
        }

        public void Print()
        {
            Console.WriteLine($"Value: {_value.ToString()}");
        }
    }

    //Constraint: where T : SomeBaseClass
    public class BaseClassContainer<T> where T : BaseClass
    {
        private T _value;

        public BaseClassContainer(T value)
        {
            _value = value;
        }

        public void Print()
        {
            Console.WriteLine($"Value: {_value.ToString()}");
        }
    }

    public class BaseClass
    {
        public override string ToString()
        {
            return "I am a base class object";
        }
    }

    public class DerivedClass : BaseClass
    {
        public override string ToString()
        {
            return "I am a derived class object";
        }
    }

    //Constraint: where T : ISomeInterface
    public interface ISomeInterface
    {
        void SomeMethod();
    }

    public class InterfaceImplementationContainer<T> where T : ISomeInterface
    {
        private T _value;

        public InterfaceImplementationContainer(T value)
        {
            _value = value;
        }

        public void CallInterfaceMethod()
        {
            _value.SomeMethod();
        }
    }

    public class SomeImplementation : ISomeInterface
    {
        public void SomeMethod()
        {
            Console.WriteLine("Calling SomeMethod() from SomeImplementation");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Usage: Using ReferenceTypeContainer<T> with where T : class
            ReferenceTypeContainer<string> stringContainer = new ReferenceTypeContainer<string>("Hello");
            stringContainer.Print(); // Output: Value: Hello

            ReferenceTypeContainer<object> objectContainer = new ReferenceTypeContainer<object>(null);
            objectContainer.Print(); // Output: Value is null

            // Usage: Using ValueTypeContainer<T> with where T : struct
            ValueTypeContainer<int> intContainer = new ValueTypeContainer<int>(42);
            intContainer.Print(); // Output: Value: 42

            ValueTypeContainer<double> doubleContainer = new ValueTypeContainer<double>(3.14);
            doubleContainer.Print(); // Output: Value: 3.14

            // Usage: Using ParameterlessConstructorContainer<T> with where T : new()
            ParameterlessConstructorContainer<SomeImplementation> classContainer = new ParameterlessConstructorContainer<SomeImplementation>();
            classContainer.Print(); // Output: Value: MyClass

            // Error: This will cause a compilation error because SomeClass doesn't have a parameterless constructor
            // ParameterlessConstructorContainer<SomeClass> invalidContainer = new ParameterlessConstructorContainer<SomeClass>();


            // Usage: Using InterfaceImplementationContainer<T> with where T : ISomeInterface
            SomeImplementation someImplementation = new SomeImplementation();
            InterfaceImplementationContainer<SomeImplementation> interfaceContainer = new InterfaceImplementationContainer<SomeImplementation>(someImplementation);
            interfaceContainer.CallInterfaceMethod(); // Output: Calling SomeMethod() from SomeImplementation

            // Error: This will cause a compilation error because SomeClass doesn't implement ISomeInterface
            // InterfaceImplementationContainer<SomeClass> invalidContainer = new InterfaceImplementationContainer<SomeClass>(new SomeClass());

        }
    }
}
