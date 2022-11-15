using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueDS
{
    public partial class Queue<Type>
    {
        private int _top;
        private int _count;
        private int _capacity;
        private int _front;
       
        public int Count { get{return _count;} }
      
       
        
        
        Type[] _array;
        public Queue()
        {
            _count = 0;
            _front = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        public Queue(int size)
        {
            _count = 0;
            _front = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }

       public void EnQueue(Type data)
       {
        if (_capacity == _top)
        {
            GrowSize();
        }
        _array[_count] = data;
        _count += 1;
        _top += 1;

       }
      
        private void GrowSize()
        {
            _capacity *= 2;
            Type[] tempArray = new Type[_capacity];
            int j = 0;
            for (int i = _front ; i < _top ; i++)
            {
                tempArray[i] = _array[j];
                j++;
            }
            _front = 0;
            _top = _count;
            _array = tempArray;
            
        }
        
        public Type DeQueue()
        {
            Type data = default(Type);
            if(_front != _top)
            {
                data = _array[_front];
                _front++;
                _count--;
                return data;
            }
            else
            {
                return data;
            }
        }

        public Type Peek()
        {
            return _array[_front];
        }
        public bool Contains(Type data)
        {
            bool iSContain = false;
            for (int i = _front ; i < _top ; i++)
            {
                if (data.Equals(_array[i]))
                {
                   iSContain = true;
                }
            }
           return iSContain;
        }

    }
}