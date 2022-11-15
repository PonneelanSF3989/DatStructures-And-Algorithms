using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackDS
{
    public partial class Stack<Type>
    {
        private int _count;
        private int _capacity;

        public int  Count { get{return _count;}  }
        public int Capacity { get{return _capacity;}  }
        
        Type[] _array ;
        

        
        

        public Stack()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        } 
        public Stack(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }

        public void Push(Type data)
        {
            if (_capacity == _count)
            {
                GrowSize();
            }
            _array[_count] = data;
            _count += 1;
        }
        public void GrowSize()
        {    
            //Double the Capacity 
            _capacity = _capacity * 2;

            //initialize the new temp array
            Type[] temp = new Type[_capacity];

            //copy the data from old array to temp array
            for(int i = 0 ; i < _count ; i++)
            {
                temp[i] = _array[i];
            }

            //assign the temp to old array
            _array = temp;
        }

    }
}