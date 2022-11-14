using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackDS
{
    public partial class Stack<Type>
    {
        public Type Pop()
        {
           if(_count > 0)
           {
             _count -= 1;
            return _array[_count];
           }
            else
            {
                return default(Type);
            }
        }
        public Type Peek()
        {
            return _array[_count-1];
        }
        public bool Contains(Type data)
        {
            bool isContain = false;
            for(int i = 0 ; i < _count  ; i++)
            {
                if(data.Equals(_array[i]))
                {
                    isContain = true;
                }
               
                
            }
            return isContain;
        }
    }
}