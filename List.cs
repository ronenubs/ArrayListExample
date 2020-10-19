using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    public interface List<E>
    {
        int Size();
        bool IsEmpty();

        E Get(int i);
        E Set(int i, E e);
        void Add(int i, E e);
        E Remove(int i);
    }
}
