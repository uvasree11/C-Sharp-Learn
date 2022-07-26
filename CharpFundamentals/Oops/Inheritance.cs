using System;
using System.Collections.Generic;
using System.Text;

namespace CharpFundamentals.Oops
{
    public class Inheritance
    {
        internal int count = 0;
        public int check = 1;
        protected int multiple = 10;
         public abstract class A
        {
            private int value = 10; //Can be used only inside the class or nested class
            protected int sum = 10;//can be used in derived class
            internal int result = 10;
            //Method Inheritance
            public void baseClassMethod()
            {
                Console.WriteLine("Iam Base Class");
            }
            //Virtual Base class Method -- If the base class method have virtual keyword, then only derived class method can override the method
            public virtual void baseVirtualClassMethod()
            {
                 int total = 100;            
            }
            //Abstract Base class method --If the base class method have abstract keyword, then only derived class method can override the method
            public abstract void baseAbstractClassMethod();
            
            public class B :A//Nested class
            {
                public override void baseAbstractClassMethod() //Abstract method must be used in derived class
                {
                    throw new NotImplementedException();
                }

                public void inheritstaticVariable() {
                    Console.WriteLine($"print private value: {value}"); //We can use static variable in nested class
                    Console.WriteLine(result);//Internal value can be used in derived class and class inside same assembly
                    Console.WriteLine(sum);//Protected value can be used in derived class of same or different assembly
                }

               
            }
        }
        public class C :A
        {
            public void inheritstaticVariable()
            {
                //Console.WriteLine($"print private value: {value}"); //It will throw error, since it is not nested class
                Console.WriteLine(sum);//Protected variable can be used in derived class

            }
            //Override base class method -- If we want to override base class method, then base class method should have virtual keyword and derived class method should have override keyword
            public override void baseVirtualClassMethod()
            {
                int count = 10;
            }
            //abstract base class method - If we want to override base class method, then base class method should be abstract/virtual. If it is abstract then we must use that abstract mehtod in dervied class and derived class should have override keyword
            public override void baseAbstractClassMethod() ////Abstract method must be used in derived class
            {

            }
        }
}
