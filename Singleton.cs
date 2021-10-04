using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    class Singleton
    {
        private static Singleton instance;
        private Singleton() { }

        public static Singleton CreateSingletonInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        public override string ToString()
        {
            return "Hello from tostring() "+instance.GetHashCode();

        }


    }

    class TestSingleton
    {
        public static void Test()
        {
            Singleton instance1 = Singleton.CreateSingletonInstance();
            Console.WriteLine(instance1.GetHashCode());
            Singleton instance2 = Singleton.CreateSingletonInstance();
            Console.WriteLine(instance2.GetHashCode());

        }
    }
}
