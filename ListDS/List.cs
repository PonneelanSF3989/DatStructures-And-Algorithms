namespace ListDS
{
    public partial class List<Type>
    {
       private int _count;
       private int _capacity;
        private Type [] _array;
       public int Count { get{return _count;} }
       public int Capacity { get{return _capacity;}  }
       public Type this [int i] 
        {
            get{return _array[i];}
            set{_array[i] = value;}
        }
       
       

      

       public List()
       {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
       }

       public List(int size)
       {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];

       }
       public void Add(Type data)
       {
            if(_capacity == _count)
            {
                GrowSize();
            }
            _array[Count] = data;
            _count++;
       }

       public void GrowSize()
       {    //Double the Capacity 
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
       
       public void AddRange(List<Type> dataList)
       {
            Type[] temp = new Type[_count + dataList.Count];
            for (int i = 0 ; i < _count ; i++)
            {
                temp[i] = _array[i];
            }
            for (int i = 0 ; i < dataList.Count ; i++)
            {
                temp[_count+i] = dataList[i];
            }
            _count += dataList.Count;
            _array = temp;
           
       }
       
       
       
        
        
    }
}