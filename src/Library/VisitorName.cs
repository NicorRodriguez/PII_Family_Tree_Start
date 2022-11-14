using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public sealed class VisitorName
    {
        private readonly static VisitorName _instance = new VisitorName();
 
        private VisitorName()
        {
        }
    
        public static VisitorName Instance
        {
            get
            {
                return _instance;
            }
        }

        public string getLonger(ReadOnlyCollection<Person> childs)
        {
            string name = "";
            if(childs.Count==0) return name;
            foreach (var child in childs){
                if(child.Name.Length>name.Length) name = child.Name;
                string childMax = VisitorName.Instance.getLonger(child.Children);
                if(childMax.Length> name.Length) name = childMax;
            }
            return name;
        }
        
    }
}
