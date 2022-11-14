using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> myPersons = new List<Person>();
            Person n1 = new Person(1, "a");
            Person n2 = new Person(2, "a");
            Person n3 = new Person(3, "a");
            Person n4 = new Person(4, "NicoCrack");
            Person n5 = new Person(5, "a");
            Person n6 = new Person(6, "a");
            Person n7 = new Person(7, "aaa");

            myPersons.Add(n1);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            Console.WriteLine(Visitor.Instance.countChilds(myPersons.AsReadOnly()));
            Console.WriteLine(VisitorMax.Instance.getMax(myPersons.AsReadOnly()));
            Console.WriteLine(VisitorName.Instance.getLonger(myPersons.AsReadOnly()));
        }
    }
}
