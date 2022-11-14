using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public sealed class Visitor
    {
        private readonly static Visitor _instance = new Visitor();
 
        private Visitor()
        {
        }
    
        public static Visitor Instance
        {
            get
            {
                return _instance;
            }
        }

        public int countChilds(ReadOnlyCollection<Person> childs)
        {
            int suma = 0;
            if(childs.Count==0) return 0;
            foreach (var child in childs){
                suma += child.Age;
                suma += Visitor.Instance.countChilds(child.Children);
            }
            return suma;
        }
        
    }
}
