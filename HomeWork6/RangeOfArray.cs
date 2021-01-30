using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6
{
    public class RangeOfArray
    {
        private int[] _array;
        public RangeOfArray()
        {
            Size = 1;
            _array = new int[Size];
        }
        public RangeOfArray(int size)
        {
            Size = size;
            _array = new int[Size];
        }
        public int Size { get; set; }
        public int this[int i]
        {
            get
            {
                return _array[i];
            }
            set
            {
                _array[i] = (int)Math.Pow((double)value, 2);
            }
        }
    }
}
