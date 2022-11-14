using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public sealed class VisitorMax
    {
        private readonly static VisitorMax _instance = new VisitorMax();
 
        private VisitorMax()
        {
        }
    
        public static VisitorMax Instance
        {
            get
            {
                return _instance;
            }
        }

        public int getMax(ReadOnlyCollection<Person> childs)
        {
            int max = 0;
            if(childs.Count==0) return 0;
            foreach (var child in childs){
                if(child.Age>max) max = child.Age;
                int childMax = VisitorMax.Instance.getMax(child.Children);
                if(childMax> max) max = childMax;
            }
            return max;
        }
        
    }
}
