using System.Collections.Generic;


namespace ListDS
{
    public partial class List<Type> 
    {
        public int IndexOf(Type data)
        {
            int index = -1;
            for (int i =0 ; i < Count  ; i++)
            {
                if (data.Equals(_array[i]))
                {
                    index = i;
                    break;
                    
                }
            }

            return index;
        }
        public void Insert(int position,Type data)
        {
           _capacity = _count + 1;
            Type[] tempArray = new Type[_capacity];
            for (int i = 0 ; i < _count+1 ; i++)
            {
                if (i < position)
                {
                    tempArray[i] = _array[i];
                }
                else if (i == position)
                {
                    tempArray[i] = data;
                   
                    
                }
                else
                {
                    tempArray[i] = _array[i-1];
                }
            }
             
            _array = tempArray;
            _count ++;
            
           
        }
   
        public void RemoveAt(int position)
        {
            for (int i = position ; i < _count ; i++)
            {
                _array[i] = _array[i+1];
            }
            _count--;
        }
        public void Remove(Type data)
        {
            int position = IndexOf(data);
            if (position > -1)
            {
                RemoveAt(position);
            }
        }
        public Type[] ToArray()
        {
            Type[] tempArray = new Type[_count];
            for (int i = 0 ; i < _count ; i++)
            {
                tempArray[i] = _array[i];
            }
            return tempArray;
        }
        public void Sort()
        {
            Type temp;
            for (int i = 0 ; i <= _count-2 ; i++ )
            {
                for(int j = 0 ; i <= _count -2   ; j++ )
                {
                   if(IsGreater(_array[j],_array[j+1]))
                   {
                        temp = _array[j];
                        _array[j] = _array[j+1];
                        _array[j+1] = temp;
                   }
                }
            }
        }  
        public bool IsGreater(Type value1,Type value2)
        {
            var result = Comparer<Type>.Default.Compare(value1,value2);
            if (result >= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }  
        public void AddRange(int position, Type data)
        {
            
        }
    
    }
}