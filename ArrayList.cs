using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    public class ArrayList<E> : List<E>
    {
        public const int CAPACITY = 3;
        private E[] data;
        private int size = 0;

        //constructors
        public ArrayList() : this(CAPACITY)
        {
        }

        public ArrayList(int capacity)
        {
            data = new E[capacity];
        }

        public void Add(int i, E e)
        {
            CheckIndex(i, size + 1);
            if(size == data.Length)
            {
                throw new FullArrayException("The array is full.");
            }

            //shifting the rightmost elements and succeeding elements
            for(int k = size - 1; k >= i; k--)
            {
                data[k + 1] = data[k];
            }

            data[i] = e;
            size++;
        }

        public E Get(int i)
        {
            CheckIndex(i, size);
            return data[i];
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public E Remove(int i)
        {
            CheckIndex(i, size);
            E temp = data[i];

            //shift elements to the right to fill the empty space
            for(int k = i; k < size - 1; k++)
            {
                data[k] = data[k + 1];
            }

            data[size - 1] = default;
            size--;
            return temp;
        }

        public E Set(int i, E e)
        {
            CheckIndex(i, size);
            E temp = data[i];
            data[i] = e;
            return temp;
        }

        public int Size()
        {
            return size;
        }

        private void CheckIndex(int i, int n)
        {
            if(i < 0 || i >= n)
            {
                throw new IndexOutOfRangeException("Illegal index: " + n);
            }
        }
    }
}
