using System;


namespace DictionaryDS
{
    public partial  class Dictionary<TKey,TValue>
    {
        private int _count;
        private int _capacity;
        public int  Count { get{return _count;} }
        private KeyValuePair<TKey,TValue>[] _array;

        public TValue this[TKey key]
        {
            get
            {
                int position = SearchKey(key);
                if (position >= 0)
                {
                    return _array[position].Value;
                }
                else
                {
                    return default(TValue);
                }
            }
            set 
            {
                int position = SearchKey(key);
                _array[position].Value = value; 
            }
        }

        public Dictionary()
        {
            _count = 0;
            _capacity = 4;
            _array = new KeyValuePair<TKey,TValue>[_capacity];
        }
         public Dictionary(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new KeyValuePair<TKey,TValue>[_capacity];
        }
        public void Add(TKey key,TValue value)
        {
            if (SearchKey(key) >= 0)
            {
                Console.WriteLine("Duplicate Key");
            }
            else
            {
                if (_count == _capacity)
                {
                    GrowSize();
                }
                KeyValuePair<TKey,TValue> data = new KeyValuePair<TKey, TValue>();
                data.Key = key;
                data.Value = value;
                _array[_count] = data ;
                _count++;
            }
        }

        private void GrowSize()
        {
            _capacity *= 2;
            KeyValuePair<TKey,TValue>[] tempArray = new KeyValuePair<TKey, TValue>[_capacity];
            for (int i = 0 ; i < _count ; i++)
            {
                tempArray[i] = _array[i];
            }
            _array = tempArray;
        }

        private int SearchKey(TKey key)
        {
            int position = -1;
            for (int i = 0 ; i < _count ; i++)
            {
                if(key.Equals(_array[i].Key))
                {
                    position = i;
                    break;
                }
            }
            return position;
        }

        private int SearchValue(TValue value)
        {
            int position = -1;
            for (int i  = 0 ; i < _count ; i++)
            {
                if (value.Equals(_array[i].Value))
                {
                    position = i;
                }
            }
            return position;
        }

        public bool ContainsKey(TKey key)
        {
            bool IsContainKey = false;
            if (SearchKey(key) >= 0 )
            {
                IsContainKey = true;
            }
            return IsContainKey;
        }

        public bool ContainsValue(TValue value)
        {
            bool IsContainValue = false;
            if(SearchValue(value) >= 0)
            {
                IsContainValue = true;
            }
            return IsContainValue;
        }
        public void Remove(TKey key)
        {
            int index = SearchKey(key);
            if (index > 0)
            {
                for (int i = index ; i < _count ; i++)
                {
                    _array[i] = _array[i+1];
                }
                _count --;
            }
            
        }

         
        
        
        

    }
}