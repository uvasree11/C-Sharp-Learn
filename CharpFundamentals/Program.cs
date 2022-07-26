using CharpFundamentals.Collections;
using CharpFundamentals.Oops;
using System;

namespace CharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //Linq1 l1=new Linq1();
            // l1.LinqLearning();
            //LinqToXml lxml = new LinqToXml();
            //lxml.readLinqToXML();
            student std = new student();
            //std.linqGB();
            //std.grpbyValue();
            //std.grpByComparison();
            std.grpByRange();
            //********Inheritance*********//
            Inheritance.C c = new Inheritance.C();
            c.baseClassMethod(); //We can call base class method because C has been inherited from A. We don't need to be define the method in derived class

        }
    }
}
