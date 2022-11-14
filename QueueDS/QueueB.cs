using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace QueueDS
{
    public partial  class Queue<Type> : IEnumerable,IEnumerator
    {
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator) this;
        }
    }
}