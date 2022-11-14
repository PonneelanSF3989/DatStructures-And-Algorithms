using System;
using System.Collections.Generic;


namespace ArrayListDS
{
    public partial class ArrayList<dynamic> 
    {
        public int IndexOf(dynamic data)
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
        public void Insert(int position,dynamic data)
        {
           _capacity = _count + 1;
            dynamic[] tempArray = new dynamic[_capacity];
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
        public void Remove(dynamic data)
        {
            int position = IndexOf(data);
            if (position > -1)
            {
                RemoveAt(position);
            }
        }
        public dynamic[] ToArray()
        {
            dynamic[] tempArray = new dynamic[_count];
            for (int i = 0 ; i < _count ; i++)
            {
                tempArray[i] = _array[i];
            }
            return tempArray;
        }
        public void Sort()
        {
            dynamic temp;
            for (int i = 0 ; i < _count -1 ; i++ )
            {
                for(int j = 0 ; i < _count - 2 - i ; j++ )
                {
                   if(IsGreater(_array[i],_array[i+1]))
                   {
                        temp = _array[i];
                        _array[i] = _array[i+1];
                        _array[i+1] = temp;
                   }
                }
            }
        }  
        public bool IsGreater(dynamic value1,dynamic value2)
        {
            var result = Comparer<dynamic>.Default.Compare(value1,value2);
            if (result >= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }  
    }
}